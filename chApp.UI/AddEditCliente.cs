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
    public partial class AddEditCliente : Form
    {
        ModelController mc = new ModelController();
        private string error = string.Empty;

        public const string MatchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                             + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                                        [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                                        [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                             + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        public int currentClienteId { get; set; }

        public AddEditCliente()
        {
            InitializeComponent();
        }



        private Principal mainForm = null;
        public AddEditCliente(Form callingForm)
        {
            mainForm = callingForm as Principal;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Common.UiHelper.IsNameValid(txtNombre.Text) && Common.UiHelper.IsEmailValid(txtMail.Text) && Common.UiHelper.IsMontoValido(txtMonto.Text, lblMonto))
            {
                if (currentClienteId == 0)
                {
                    try
                    {
                        var newCliente = new ClienteDTO();
                        newCliente.Nombre = txtNombre.Text;
                        newCliente.Apellido = txtApellido.Text;
                        newCliente.Telefono = txtTelefono.Text;
                        newCliente.TelefonoAux = txtTelefonoAux.Text;
                        newCliente.Direccion = txtDireccion.Text;
                        newCliente.Email = txtMail.Text;
                        newCliente.CupoMax = Convert.ToDouble(txtMonto.Text);
                        newCliente.CupoRestante = Convert.ToDouble(txtMonto.Text);

                        mc.ClienteBL.Create(newCliente);
                    }
                    catch (Exception ex)
                    {
                        UiHelper.WarningMessage(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        var currentCliente = mc.ClienteBL.GetById(currentClienteId);
                        ClienteDTO cli = currentCliente;
                        cli.Nombre = txtNombre.Text;
                        cli.Apellido = txtApellido.Text;
                        cli.Telefono = txtTelefono.Text;
                        cli.TelefonoAux = txtTelefonoAux.Text;
                        cli.Direccion = txtDireccion.Text;
                        cli.Email = txtMail.Text;
                        cli.CupoMax = Convert.ToDouble(txtMonto.Text);

                        if (cli.Cheques.Count > 0)
                        {
                            double montoPrestado = cli.Cheques.Sum(ch => ch.Monto);
                            double montoRestante = cli.CupoMax - Convert.ToDouble(montoPrestado);
                            if (montoRestante < 0)
                            {
                                string advertencia = string.Format("Se ha Cambiado el Cupo Máximo y ahora el Cliente tiene un saldo negativo de {0}", montoRestante);
                                MessageBox.Show(advertencia, "Advertencia");
                            }
                            else
                                cli.CupoRestante = montoRestante;
                        }
                        else
                            cli.CupoRestante = Convert.ToDouble(txtMonto.Text);


                        currentCliente.Nombre = cli.Nombre;
                        currentCliente.Apellido = cli.Apellido;
                        currentCliente.Telefono = cli.Telefono;
                        currentCliente.TelefonoAux = cli.TelefonoAux;
                        currentCliente.Direccion = cli.Direccion;
                        currentCliente.Email = cli.Email;
                        currentCliente.CupoMax = cli.CupoMax;
                        currentCliente.CupoRestante = cli.CupoRestante;

                        mc.ClienteBL.Update(cli);

                    }
                    catch (Exception ex)
                    {
                        UiHelper.WarningMessage(ex.Message);
                    }


                }

                if (!(this.Owner != null && this.Owner.Name.Equals("AddEditCheques")))
                    this.mainForm.FillGridClientes(true);
   
                this.Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void AddEditCliente_Load(object sender, EventArgs e)
        {
            bool isEditClient = currentClienteId > 0;
            EditFields(!isEditClient);
            btnGuardar.Visible = !isEditClient;
            btnModificar.Visible = isEditClient;
            if (isEditClient)
            {
                var currentCliente = mc.ClienteBL.GetById(currentClienteId);
                txtNombre.Text = currentCliente.Nombre;
                txtApellido.Text = currentCliente.Apellido;
                txtTelefono.Text = currentCliente.Telefono;
                txtTelefonoAux.Text = currentCliente.TelefonoAux;
                txtDireccion.Text = currentCliente.Direccion;
                txtMail.Text = currentCliente.Email;
                txtMonto.Text = currentCliente.CupoMax.ToString();
                var chequeList = mc.ChequeBL.GetChequesByIdClient(currentClienteId);
                chequeList.ForEach(sc => sc.IsTenedor = (sc.IdTenedor == currentClienteId));
                FillGridCheques(chequeList);
                if (chequeList.Any())
                {
                    rbParaCobro.Checked = true;
                    gbFiltros.Enabled = false;
                }
            }
        }

        private void FillGridCheques(List<SmallChequeDTO> cheques)
        {
            dgvCheques.AutoGenerateColumns = false;
            //Set Columns Count
            dgvCheques.ColumnCount = 5;

            //Add Columns FechaEmision
            dgvCheques.Columns[0].Name = "FechaDePago";
            dgvCheques.Columns[0].HeaderText = "Fecha de Pago";
            dgvCheques.Columns[0].DataPropertyName = "FechaDePago";

            dgvCheques.Columns[1].Name = "Monto";
            dgvCheques.Columns[1].HeaderText = "Monto";
            dgvCheques.Columns[1].DataPropertyName = "Monto";

            dgvCheques.Columns[2].Name = "Rechazado";
            dgvCheques.Columns[2].HeaderText = "Estado";
            dgvCheques.Columns[2].DataPropertyName = "Estado";

            dgvCheques.Columns[3].Name = "Banco";
            dgvCheques.Columns[3].HeaderText = "Banco";
            dgvCheques.Columns[3].DataPropertyName = "Banco";

            dgvCheques.Columns[4].Name = "IsTenedorText";
            dgvCheques.Columns[4].HeaderText = "Es Tenedor";
            dgvCheques.Columns[4].DataPropertyName = "IsTenedorText";

            dgvCheques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheques.AllowUserToResizeColumns = false;
            dgvCheques.AllowUserToResizeRows = false;

            dgvCheques.DataSource = cheques;
        }

        private void EditFields(bool enableFields)
        {
            txtNombre.Enabled = enableFields;
            txtApellido.Enabled = enableFields;
            txtTelefono.Enabled = enableFields;
            txtTelefonoAux.Enabled = enableFields;
            txtDireccion.Enabled = enableFields;
            txtMail.Enabled = enableFields;
            txtMonto.Enabled = enableFields;
            gbFiltros.Enabled = !enableFields;
        }

        private double CalcularCupoRestante(ClienteDTO c, double max)
        {
            double cupoRestante = 0;

            foreach (var ch in c.Cheques)
            {
                cupoRestante += ch.Monto;
            }

            return cupoRestante = max - cupoRestante;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EditFields(true);
            btnGuardar.Visible = true;
            btnModificar.Visible = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvCheques.DataSource = null;
            dgvCheques.DataSource = FilterCheques(false);
        }

        private List<ChequeDTO> FilterCheques(bool limpiar)
        {
            var cliente = mc.ClienteBL.GetById(currentClienteId);
            List<ChequeDTO> cheques;
            if (!limpiar)
            {
                int status = 0;

                if (rbCobrado.Checked)
                    status = 2;
                else if (rbRechazado.Checked)
                    status = 1;
                else
                    status = 0;

                cheques = cliente.Cheques.Where(ch => ch.FechaPago >= dtpDesde.Value
                    && ch.FechaPago <= dtpHasta.Value
                    && ch.Rechazado == status
                    && ch.Banco == cboBancos.Text).ToList();
            }
            else
                cheques = cliente.Cheques;

            return cheques;
        }

        private void btnLimpiarFiltrar_Click(object sender, EventArgs e)
        {
            dgvCheques.DataSource = null;
            dgvCheques.DataSource = FilterCheques(true);
        }
    }
}
