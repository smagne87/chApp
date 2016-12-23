using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chApp.BLL;
using chApp.UI.Common;

namespace chApp.UI
{
    public partial class AddEditCheques : Form
    {
        private const double DESCUENTO = 0.2;
        private const double IMPUESTO = 4;

        ModelController mc = new ModelController();
        private string error = string.Empty;
        private FirmanteDTO currentFirmante;

        public int currentChequeId;
        public bool checkValidate;
        private Principal mainForm = null;

        public AddEditCheques(Form callingForm)
        {
            mainForm = callingForm as Principal;
            InitializeComponent();
        }

        public AddEditCheques()
        {
            InitializeComponent();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            CalcularMontoExcedido();

            if (!string.IsNullOrWhiteSpace(txtMonto.Text))
                CalculateMontoPorcentajeDescuento();


        }

        private bool TieneChequesRechazados(List<ChequeDTO> cheques)
        {
            return cheques.Any(ch => ch.Rechazado == 1);
        }

        private void CalcularMontoExcedido()
        {
            var cliente = (ClienteDTO)cboBeneficiario.SelectedItem;
            var mcContext = new ModelController();
            cliente.CupoRestante = mcContext.ClienteBL.GetById(cliente.Id) != null ? mcContext.ClienteBL.GetById(cliente.Id).CupoRestante : cliente.CupoRestante;
            cliente.CupoMax = mcContext.ClienteBL.GetById(cliente.Id) != null ? mcContext.ClienteBL.GetById(cliente.Id).CupoMax : cliente.CupoMax;
            if (cliente.Id > 0)
            {
                if (!string.IsNullOrEmpty(txtMonto.Text))
                {
                    Double montoRestante = cliente.CalcularMontoRestante(Convert.ToDouble(txtMonto.Text));

                    if (montoRestante < 0)
                    {
                        var msg = string.Format("El cupo máximo para {0} es de ${1}, se ha excedido ${2}. Desea aumentar el Cupo Máximo?", string.Format("{0} {1}", cliente.Nombre, cliente.Apellido), cliente.CupoMax, (-montoRestante).ToString());
                        DialogResult res = MessageBox.Show(msg, "Pregunta Importante", MessageBoxButtons.YesNo);
                        if (res == DialogResult.No)
                        {
                            DialogResult resClose = MessageBox.Show("Continuar con el cheque", "Pregunta", MessageBoxButtons.YesNo);
                            if (resClose == DialogResult.No)
                                this.Close();
                            else
                                txtCuenta.Focus();
                            //txtMonto.Text = string.Empty;
                        }
                        else
                        {
                            txtMonto.Text = string.Empty;
                            AddEditCliente clienteForm;
                            if (!Common.UiHelper.IsFormOpen(typeof(AddEditCliente)))
                            {
                                clienteForm = new AddEditCliente();
                                clienteForm.Text = "Editar Cliente";
                                clienteForm.currentClienteId = cliente.Id;
                                clienteForm.ShowDialog(this);
                            }
                        }
                    } 
                }
            }
            else
            {
                MessageBox.Show("Debe selecionar un cliente", "Advertencia");
                txtMonto.Text = string.Empty;
            }
        }

        private void CalculateMontoPorcentajeDescuento()
        {
            if (Common.UiHelper.IsMontoValido(txtMonto.Text, lblMonto) && !string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                try
                {
                    double monto = Convert.ToDouble(txtMonto.Text);
                    double resDay = Math.Round((dtpFechaPago.Value - dtpFechaEmision.Value).TotalDays);
                    var dayOfWeek = dtpFechaPago.Value.DayOfWeek;

                    if (dayOfWeek.Equals(System.DayOfWeek.Thursday) || dayOfWeek.Equals(System.DayOfWeek.Friday))
                        resDay += 4;
                    else
                        resDay += 2;

                    var desc = (resDay * DESCUENTO) + IMPUESTO;

                    var montoDesc = (monto * desc / 100);
                    txtMontoDescontar.Text = montoDesc.ToString();
                    txtDescuento.Text = desc.ToString();
                }
                catch (Exception ex)
                {
                    UiHelper.WarningMessage(ex.Message);
                }
            }
        }

        private void AddEditCheques_Load(object sender, EventArgs e)
        {
            var clientesCbo = new List<ClienteDTO>();
            var autoCompleteCollection = AutocompleteCliente(ref clientesCbo);
            FillCombo<ClienteDTO>("Nombre", "Id", autoCompleteCollection, cboBeneficiario, clientesCbo);
            clientesCbo = new List<ClienteDTO>();
            autoCompleteCollection = AutocompleteCliente(ref clientesCbo);
            FillCombo<ClienteDTO>("Nombre", "Id", autoCompleteCollection, cboTenedor, clientesCbo);
            var currentCheque = mc.ChequeBL.GetById(currentChequeId);
            if (currentCheque != null)
            {
                txtCuenta.Text = currentCheque.Cuenta;
                cboBeneficiario.SelectedIndex = cboBeneficiario.FindStringExact(string.Format("{0} {1}", currentCheque.Cliente.Nombre, currentCheque.Cliente.Apellido));
                var _tenedor = mc.ClienteBL.GetById((int)currentCheque.IdTenedor);
                if(_tenedor != null)
                    cboTenedor.SelectedIndex = cboTenedor.FindStringExact(string.Format("{0} {1}", _tenedor.Nombre, _tenedor.Apellido));
                mTxtCuit.Text = currentCheque.Cuit;
                var _librador = mc.FirmanteBL.GetFirmanteByCuit(currentCheque.Cuit);
                if (_librador != null)
                    txtLibrador.Text = _librador.Nombre;
                txtMonto.Text = currentCheque.Monto.ToString();
                txtDescuento.Text = currentCheque.Descuento.ToString();
                cboBancos.Text = currentCheque.Banco;
                dtpFechaEmision.Value = currentCheque.FechaEntrega;
                dtpFechaPago.Value = currentCheque.FechaPago;
                txtLugarEmision.Text = currentCheque.LugarEmision;
                txtMontoDescontar.Text = currentCheque.MontoDescontar.ToString();
                txtNroOrden.Text = currentCheque.NroOrden;
                chbEstado.Checked = currentCheque.Rechazado == 0 ? false : true;
                checkValidate = true;
            }

            CompletarFirmante();

        }

        public AutoCompleteStringCollection AutocompleteCliente(ref List<ClienteDTO> clientesCbo)
        {
            var mc = new ModelController();
            var clientes = mc.ClienteBL.GetAll();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (var c in clientes)
            {
                clientesCbo.Add(c);
                coleccion.Add(c.Nombre + " " + c.Apellido);
            }
            return coleccion;
        }

        private void CompletarFirmante()
        {
            txtLibrador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtLibrador.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtLibrador.AutoCompleteCustomSource = AutocompleteFirmante();
        }

        public AutoCompleteStringCollection AutocompleteFirmante()
        {
            var firmantes = mc.FirmanteBL.GetAll();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (var f in firmantes)
            {
                coleccion.Add(f.Nombre);
            }
            return coleccion;
        }

        public AutoCompleteStringCollection AutocompleteCuit()
        {
            var firmantes = mc.FirmanteBL.GetAll().ToList();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (var f in firmantes)
            {
                coleccion.Add(f.Cuit);
            }
            return coleccion;
        }

        private void FillCombo<T>(string dMember, string vMember, AutoCompleteStringCollection acsc, ComboBox cbo, List<T> items) where T : new()
        {
            T emptySel = new T();
            var pro = emptySel.GetType().GetProperties().SingleOrDefault(pi => pi.Name == dMember);
            pro.SetValue(emptySel, "Seleccionar", null);
            pro = emptySel.GetType().GetProperties().SingleOrDefault(pi => pi.Name == vMember);
            pro.SetValue(emptySel, 0, null);
            items.Insert(0, emptySel);

            cbo.DataSource = items;
            cbo.DisplayMember = dMember;
            cbo.ValueMember = vMember;

            cbo.AutoCompleteCustomSource = acsc;
            cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void mTxtCuit_TextChanged(object sender, EventArgs e)
        {
            if (mTxtCuit.Text.Length == 13 && checkValidate)
            {
                var librador = mc.FirmanteBL.GetFirmanteByCuit(UiHelper.CuitConverter(mTxtCuit.Text));
                if (librador != null)
                {
                    txtLibrador.Text = librador.Nombre;
                    currentFirmante = librador;
                    if (string.IsNullOrWhiteSpace(currentFirmante.Nombre))
                    {

                        if (TieneChequesRechazados(currentFirmante.Cheques))
                        {
                            string msg = string.Format("El Firmante {0} cuenta con cheques rechazados. Cantidad: {1}. Desea continuar?", currentFirmante.Nombre, currentFirmante.Cheques.Count(ch => ch.Rechazado == 1));
                            DialogResult res = MessageBox.Show(msg, "Advertencia", MessageBoxButtons.YesNo);
                            if (res == DialogResult.No)
                                this.Close();
                        }
                    }
                }
                else
                {
                    CreateFirmante();
                }
            }
        }

        private void CreateFirmante()
        {
            DialogResult res = MessageBox.Show("El Librador no existe desea registrarlo?", "Pregunta Importante", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                AddEditFirmante firmanteForm;

                if (!Common.UiHelper.IsFormOpen(typeof(AddEditFirmante)))
                {
                    firmanteForm = new AddEditFirmante(this);
                    firmanteForm.Text = "Nuevo Firmante";
                    firmanteForm.ShowDialog(this);
                    currentFirmante = mc.FirmanteBL.GetById(firmanteForm.currentFirmanteId);
                    this.mainForm.FillGridFirmantes(true);
                }
            }
            else
            {
                try
                {
                    string cuit = UiHelper.CuitConverter(mTxtCuit.Text);
                    FirmanteDTO firmante = new FirmanteDTO();
                    firmante.Nombre = txtLibrador.Text;
                    firmante.Telefono = string.Empty;
                    firmante.Direccion = string.Empty;
                    firmante.Email = string.Empty;
                    firmante.Cuit = cuit;

                    mc.FirmanteBL.Create(firmante);
                    currentFirmante = mc.FirmanteBL.GetFirmanteByCuit(cuit);
                }
                catch (Exception ex)
                {
                    Common.UiHelper.ErrorMessage(ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool isSaved = false;
            if (ValidateCheque())
            {
                var currentCheque = mc.ChequeBL.GetById(currentChequeId);
                if (currentCheque == null)
                {
                    try
                    {
                        var cliente = (ClienteDTO)cboBeneficiario.SelectedItem;

                        if (cliente != null)
                        {
                            currentCheque = new ChequeDTO();
                            currentCheque.IdCliente = cliente.Id;
                            currentCheque.Cuenta = txtCuenta.Text;
                            currentCheque.Cuit = UiHelper.CuitConverter(mTxtCuit.Text);
                            currentCheque.Descuento = Convert.ToDouble(txtDescuento.Text);
                            currentCheque.FechaEntrega = dtpFechaEmision.Value;
                            currentCheque.FechaPago = dtpFechaPago.Value;
                            if (cboTenedor.SelectedIndex > 0)
                                currentCheque.IdTenedor = (cboTenedor.SelectedItem as ClienteDTO).Id;
                            currentCheque.LugarEmision = txtLugarEmision.Text;
                            currentCheque.Monto = Convert.ToDouble(txtMonto.Text);
                            currentCheque.MontoDescontar = Convert.ToDouble(txtMontoDescontar.Text);
                            currentCheque.NroOrden = txtNroOrden.Text;
                            currentCheque.Banco = cboBancos.Text;
                            currentCheque.Rechazado = SetEstadoAlCheque(chbEstado.Checked, chCobrado.Checked);
                            if (currentFirmante == null)
                            {
                                currentFirmante = mc.FirmanteBL.GetFirmanteByCuit(currentCheque.Cuit);
                                if(currentFirmante == null)
                                {
                                    CreateFirmante();
                                }
                            }
                            currentCheque.IdFirmante = currentFirmante.Id;

                            mc.ChequeBL.Create(currentCheque);
                            var newCheque = currentCheque;
                            if (newCheque != null)
                            {
                                isSaved = true;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        UiHelper.WarningMessage(ex.Message);
                    }
                }
                else
                {
                    var cliente = (ClienteDTO)cboBeneficiario.SelectedItem;
                    if (cliente != null)
                    {
                        try
                        {
                            currentCheque.IdCliente = cliente.Id;
                            currentCheque.Cuenta = txtCuenta.Text;
                            currentCheque.Cuit = UiHelper.CuitConverter(mTxtCuit.Text);
                            currentCheque.Descuento = Convert.ToDouble(txtDescuento.Text);
                            currentCheque.FechaEntrega = dtpFechaEmision.Value;
                            currentCheque.FechaPago = dtpFechaPago.Value;
                            if(cboTenedor.SelectedIndex > 0)
                                currentCheque.IdTenedor = (cboTenedor.SelectedItem as ClienteDTO).Id;
                            currentCheque.LugarEmision = txtLugarEmision.Text;
                            currentCheque.Monto = Convert.ToDouble(txtMonto.Text);
                            currentCheque.MontoDescontar = Convert.ToDouble(txtMontoDescontar.Text);
                            currentCheque.NroOrden = txtNroOrden.Text;
                            currentCheque.Rechazado = SetEstadoAlCheque(chbEstado.Checked, chCobrado.Checked);
                            currentCheque.Banco = cboBancos.Text;
                            if (currentFirmante == null)
                            {
                                currentFirmante = mc.FirmanteBL.GetFirmanteByCuit(currentCheque.Cuit);
                                if (currentFirmante == null)
                                {
                                    CreateFirmante();
                                }
                            }
                            currentCheque.IdFirmante = currentFirmante.Id;


                            if (mc.ChequeBL.Update(currentCheque))
                                isSaved = true;
                            else
                                this.Close();
                        }
                        catch (Exception ex)
                        {
                            UiHelper.WarningMessage(ex.Message);
                        }
                    }
                }
            }

            if (isSaved)
            {
                this.mainForm.FillGridCheques(true);
                this.Close();
            }

        }

        private long SetEstadoAlCheque(bool rechazado, bool cobrado)
        {
            if (rechazado)
                return 1;
            else if (cobrado)
                return 2;
            else
                return 0;
        }


        private bool ValidateCheque()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtNroOrden.Text))
            {
                MessageBox.Show("Falta Número de Orden", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Ingrese el Monto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtCuenta.Text))
            {
                MessageBox.Show("Ingrese el Número de Cuenta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (dtpFechaEmision.Value > dtpFechaPago.Value)
            {
                MessageBox.Show("Fecha de Emisión posterior a la de Pago", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (string.IsNullOrEmpty(cboBancos.Text))
            {
                MessageBox.Show("Por Favor seleccione un banco de la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            return isValid;
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            CalculateMontoPorcentajeDescuento();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Common.UiHelper.IsMontoValido(txtMonto.Text, lblMonto) && !string.IsNullOrWhiteSpace(txtDescuento.Text))
                {
                    double monto = Convert.ToDouble(txtMonto.Text);
                    double desc = Convert.ToDouble(txtDescuento.Text);

                    var montoDesc = (monto * desc / 100);
                    txtMontoDescontar.Text = montoDesc.ToString();
                }
            }
            catch (Exception ex)
            {
                UiHelper.WarningMessage(ex.Message);
            }
        }

        private void txtLibrador_TextChanged(object sender, EventArgs e)
        {
            var mc = new ModelController();
            if (!string.IsNullOrWhiteSpace(txtLibrador.Text) && checkValidate)
            {
                var librador = mc.FirmanteBL.GetFirmanteByNombre(txtLibrador.Text);
                if (librador != null)
                {
                    mTxtCuit.Text = librador.Cuit;
                    currentFirmante = librador;
                    if (TieneChequesRechazados(currentFirmante.Cheques))
                    {
                        string msg = string.Format("El Firmante {0} cuenta con cheques rechazados. Cantidad: {1}. Desea continuar?", currentFirmante.Nombre, currentFirmante.Cheques.Count(ch => ch.Rechazado == 1));
                        DialogResult res = MessageBox.Show(msg, "Advertencia", MessageBoxButtons.YesNo);
                        if (res == DialogResult.No)
                            this.Close();
                    }
                }
            }
        }

        private void cboBeneficiarioFormat(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((ClienteDTO)e.ListItem).Nombre;
            string firstname = ((ClienteDTO)e.ListItem).Apellido;
            e.Value = lastname + " " + firstname;
        }

        private void cboTenedorFormat(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((ClienteDTO)e.ListItem).Nombre;
            string firstname = ((ClienteDTO)e.ListItem).Apellido;
            e.Value = lastname + " " + firstname;
        }

        private void chbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chCobrado.Checked == true)
                chCobrado.Checked = false;
        }

        private void chCobrado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEstado.Checked == true)
                chbEstado.Checked = false;
        }

        private void cboBeneficiario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cliente = (ClienteDTO)cboBeneficiario.SelectedItem;
                if (checkValidate && TieneChequesRechazados(cliente.Cheques))
                {
                    string msg = string.Format("El cliente {0} {1} cuenta con cheques rechazados. Cantidad: {2}. Desea continuar?", cliente.Nombre, cliente.Apellido, cliente.Cheques.Count(ch => ch.Rechazado == 1));
                    DialogResult res = MessageBox.Show(msg, "Advertencia", MessageBoxButtons.YesNo);
                    if (res == DialogResult.No)
                        this.Close();
                }
                else if (checkValidate && IsSameTenedorBeneficiario())
                {
                    DialogResult res = MessageBox.Show("El Beneficiario no puede ser el mismo que el Tenedor.", "Advertencia", MessageBoxButtons.OK);
                    cboBeneficiario.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                UiHelper.WarningMessage(ex.Message);
            }
        }

        private void cboTenedor_SelectedValueChanged(object sender, EventArgs e)
        {
            var mc = new ModelController();
            ClienteDTO selectedClient = cboTenedor.SelectedItem as ClienteDTO;
            if (selectedClient != null)
            {
                if (IsSameTenedorBeneficiario())
                {
                    DialogResult res = MessageBox.Show("El Tenedor no puede ser el mismo que el Beneficiario.", "Advertencia", MessageBoxButtons.OK);
                    cboTenedor.SelectedIndex = 0;
                }
                else
                {
                    var librador = mc.ClienteBL.GetById(selectedClient.Id);
                    if (librador != null)
                    {
                        if (TieneChequesRechazados(selectedClient.Cheques))
                        {
                            string msg = string.Format("El Tenedor {0} cuenta con cheques rechazados. Cantidad: {1}. Desea continuar?", selectedClient.Nombre, selectedClient.Cheques.Count(ch => ch.Rechazado == 1));
                            DialogResult res = MessageBox.Show(msg, "Advertencia", MessageBoxButtons.YesNo);
                            if (res == DialogResult.No)
                                this.Close();
                        }
                    }
                }
            }
        }

        private bool IsSameTenedorBeneficiario()
        {
            bool result = false;
            var tenedor = cboTenedor.SelectedItem as ClienteDTO;
            var beneficiario = cboBeneficiario.SelectedItem as ClienteDTO;

            if (cboTenedor.SelectedIndex > 0 && cboBeneficiario.SelectedIndex > 0)
                if (beneficiario.Id == tenedor.Id)
                    result = true;

            return result;
        }
    }
}
