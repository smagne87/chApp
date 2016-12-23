using chApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chApp.UI
{
    public partial class Principal : Form
    {

        string error = string.Empty;

        public Principal()
        {
            InitializeComponent();
            dgvClientes.DataSource = null;
            FillGridClientes(false);
            FillGridFirmantes(false);
            FillGridCheques(false);
            FillSummaryTab();
            btnAddCliente.Hide();
        }

        private void FillSummaryTab()
        {
            ChequesByDay(false);
            ChequesRechazados(false);
            ChequesACobrar(false);
        }

        private void ChequesACobrar(bool filter)
        {
            ModelController mc = new ModelController();
            var source = mc.ChequeBL.GetByDate(dtpDateFilterSummary.Value);
            loadGridViewCheques(filter, source, dgvChequesACobrar);
        }

        private void ChequesRechazados(bool filter)
        {
            ModelController mc = new ModelController();
            var source = mc.ChequeBL.GetRechazados();
            loadGridViewCheques(filter, source, dgvChequesRechazados);
        }

        private void ChequesByDay(bool filter)
        {
            ModelController mc = new ModelController();
            var source = mc.ChequeBL.GetByDate(dtpDateFilterSummary.Value);
            loadGridViewCheques(filter, source, dgvChequesPorDia);

        }

        private void loadGridViewCheques(bool filter, List<ChequeDTO> source, DataGridView dgv)
        {
            if (filter)
            {
                dgv.DataSource = null;
                dgv.Update();
                dgv.Refresh();
            }
            else
            {
                dgv.AutoGenerateColumns = false;
                //Set Columns Count
                dgv.ColumnCount = 7;

                //Add Columns FechaEmision
                dgv.Columns[0].Name = "FechaLibrado";
                dgv.Columns[0].HeaderText = "Fecha de Emisión";
                dgv.Columns[0].DataPropertyName = "FechaLibrado";

                dgv.Columns[1].Name = "FechaDePago";
                dgv.Columns[1].HeaderText = "Fecha de Pago";
                dgv.Columns[1].DataPropertyName = "FechaDePago";

                dgv.Columns[2].Name = "Cliente";
                dgv.Columns[2].HeaderText = "Cliente";
                dgv.Columns[2].DataPropertyName = "NombreCliente";

                dgv.Columns[3].Name = "Monto";
                dgv.Columns[3].HeaderText = "Monto";
                dgv.Columns[3].DataPropertyName = "Monto";

                dgv.Columns[4].Name = "Firmante";
                dgv.Columns[4].HeaderText = "Firmante";
                dgv.Columns[4].DataPropertyName = "NombreFirmante";

                dgv.Columns[5].Name = "Rechazado";
                dgv.Columns[5].HeaderText = "Estado";
                dgv.Columns[5].DataPropertyName = "Estado";

                dgv.Columns[6].Name = "Banco";
                dgv.Columns[6].HeaderText = "Banco";
                dgv.Columns[6].DataPropertyName = "Banco";

            }
            dgv.DataSource = source;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }

        #region Cliente

        public void FillGridClientes(bool isModified)
        {
            BindingSource bs = new BindingSource();
            bs.ResetBindings(false);
            if (isModified)
            {
                ModelController mc = new ModelController();
                this.Refresh();
                bs.DataSource = mc.ClienteBL.GetAll();
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bs;
            }
            else
            {
                ModelController mc = new ModelController();
                dgvClientes.AutoGenerateColumns = false;
                //Set Columns Count
                dgvClientes.ColumnCount = 7;

                //Add Columns
                dgvClientes.Columns[0].Name = "Nombre";
                dgvClientes.Columns[0].HeaderText = "Nombre";
                dgvClientes.Columns[0].DataPropertyName = "Nombre";

                dgvClientes.Columns[1].HeaderText = "Apellido";
                dgvClientes.Columns[1].Name = "Apellido";
                dgvClientes.Columns[1].DataPropertyName = "Apellido";

                dgvClientes.Columns[2].Name = "Direccion";
                dgvClientes.Columns[2].HeaderText = "Dirección";
                dgvClientes.Columns[2].DataPropertyName = "Direccion";

                dgvClientes.Columns[3].Name = "Telefono";
                dgvClientes.Columns[3].HeaderText = "Telefono";
                dgvClientes.Columns[3].DataPropertyName = "Telefono";

                dgvClientes.Columns[4].Name = "TelefonoAux";
                dgvClientes.Columns[4].HeaderText = "Telefono Aux.";
                dgvClientes.Columns[4].DataPropertyName = "TelefonoAux";

                dgvClientes.Columns[5].Name = "Email";
                dgvClientes.Columns[5].HeaderText = "Email";
                dgvClientes.Columns[5].DataPropertyName = "Email";

                dgvClientes.Columns[6].Name = "CupoMax";
                dgvClientes.Columns[6].HeaderText = "Cupo Maximo";
                dgvClientes.Columns[6].DataPropertyName = "CupoMax";

                bs.DataSource = mc.ClienteBL.GetAll();
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bs;//GetClientes(mc.ClienteBL.GetAll());

            }
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
        }

        private void btnAddCliente_Click_1(object sender, EventArgs e)
        {
            Form clienteForm;

            if (!Common.UiHelper.IsFormOpen(typeof(AddEditCliente)))
            {
                clienteForm = new AddEditCliente(this);
                clienteForm.Text = "Nuevo Cliente";
                clienteForm.ShowDialog(this);
            }

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            btnAddCliente.Show();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddEditCliente clienteForm;
            ClienteDTO c = (ClienteDTO)dgvClientes.CurrentRow.DataBoundItem;

            if (!Common.UiHelper.IsFormOpen(typeof(AddEditCliente)))
            {
                clienteForm = new AddEditCliente(this);
                clienteForm.Text = "Editar Cliente";
                clienteForm.currentClienteId = c.Id;
                clienteForm.ShowDialog(this);

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ModelController mc = new ModelController();
            if (dgvClientes.CurrentRow.Selected)
            {
                ClienteDTO c = (ClienteDTO)dgvClientes.CurrentRow.DataBoundItem;
                string preg = string.Format("Eliminar cliente {0} {1}?", c.Nombre, c.Apellido);
                DialogResult res = MessageBox.Show(preg, "Pregunta Importante", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    var cliCheques = mc.ChequeBL.GetChequesByIdClient(c.Id);
                    if (!cliCheques.Any())
                    {
                        mc.ClienteBL.Delete(c.Id);
                        this.FillGridClientes(true);
                    }
                    else
                        Common.UiHelper.WarningMessage("El siguiente Cliente tiene cheques asignados y no se puede borrar");

                }
            }
            else
            {
                MessageBox.Show("No hay cliente seleccionado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarPor_Click(object sender, EventArgs e)
        {
            BuscarPor(txtBuscarPor.Text);
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            ModelController mc = new ModelController();
            if (!string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
            {
                var clientes = mc.ClienteBL.GetByNameSurname(txtBuscarCliente.Text);

                if (clientes != null && clientes.Count() > 0)
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.Update();
                    dgvClientes.Refresh();
                    dgvClientes.DataSource = clientes;
                }
            }
            else
                FillGridClientes(true);
        }

        #endregion

        #region Firmante
        public void FillGridFirmantes(bool isModified)
        {
            ModelController mc = new ModelController();
            if (isModified)
            {
                dgvFirmantes.DataSource = null;
                dgvFirmantes.Update();
                dgvFirmantes.Refresh();
                dgvFirmantes.DataSource = mc.FirmanteBL.GetAll(); //mc.FirmanteBL.GetAll().ToList();
            }
            else
            {
                dgvFirmantes.AutoGenerateColumns = false;
                //Set Columns Count
                dgvFirmantes.ColumnCount = 5;

                //Add Columns
                dgvFirmantes.Columns[0].Name = "Nombre";
                dgvFirmantes.Columns[0].HeaderText = "Nombre";
                dgvFirmantes.Columns[0].DataPropertyName = "Nombre";

                dgvFirmantes.Columns[1].HeaderText = "Cuit";
                dgvFirmantes.Columns[1].Name = "Cuit";
                dgvFirmantes.Columns[1].DataPropertyName = "Cuit";

                dgvFirmantes.Columns[2].Name = "Direccion";
                dgvFirmantes.Columns[2].HeaderText = "Dirección";
                dgvFirmantes.Columns[2].DataPropertyName = "Direccion";

                dgvFirmantes.Columns[3].Name = "Telefono";
                dgvFirmantes.Columns[3].HeaderText = "Telefono";
                dgvFirmantes.Columns[3].DataPropertyName = "Telefono";

                dgvFirmantes.Columns[4].Name = "Email";
                dgvFirmantes.Columns[4].HeaderText = "E-Mail";
                dgvFirmantes.Columns[4].DataPropertyName = "Email";

                dgvFirmantes.DataSource = mc.FirmanteBL.GetAll();
            }
            dgvFirmantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFirmantes.AllowUserToResizeColumns = false;
            dgvFirmantes.AllowUserToResizeRows = false;
        }

        private void btnCreateFirmante_Click(object sender, EventArgs e)
        {
            AddEditFirmante firmanteForm;

            if (!Common.UiHelper.IsFormOpen(typeof(AddEditFirmante)))
            {
                firmanteForm = new AddEditFirmante(this);
                firmanteForm.Text = "Nuevo Firmante";
                firmanteForm.currentFirmanteId = 0;
                firmanteForm.ShowDialog(this);
            }

        }

        private void dgvFirmantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddEditFirmante firmanteForm;
            FirmanteDTO f = (FirmanteDTO)dgvFirmantes.CurrentRow.DataBoundItem;

            if (f != null)
            {
                if (!Common.UiHelper.IsFormOpen(typeof(AddEditFirmante)))
                {
                    firmanteForm = new AddEditFirmante(this);
                    firmanteForm.Text = "Editar Firmante";
                    firmanteForm.currentFirmanteId = (int)f.Id;
                    firmanteForm.ShowDialog(this);

                }
            }
        }

        private void btnBorrarFirmante_Click(object sender, EventArgs e)
        {
            if (dgvFirmantes.CurrentRow.Selected)
            {
                ModelController mc = new ModelController();
                FirmanteDTO f = (FirmanteDTO)dgvFirmantes.CurrentRow.DataBoundItem;
                string preg = string.Format("Eliminar firmante {0}?", f.Nombre);
                DialogResult res = MessageBox.Show(preg, "Pregunta Importante", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    var firCheques = mc.ChequeBL.GetChequesByIdFirmante(f.Id);
                    if (!firCheques.Any())
                    {
                        mc.FirmanteBL.Delete((int)f.Id);
                        this.FillGridFirmantes(true);
                    }
                    else
                        Common.UiHelper.WarningMessage("El siguiente Firmante tiene cheques asignados y no se puede borrar");
                }
            }
            else
            {
                MessageBox.Show("No hay firmante seleccionado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Cheques
        public void FillGridCheques(bool isModified)
        {

            if (isModified)
            {
                ModelController mc = new ModelController();
                dgvCheques.DataSource = null;
                dgvCheques.Update();
                dgvCheques.Refresh();
                dgvCheques.DataSource = mc.ChequeBL.GetAll();
            }
            else
            {
                ModelController mc = new ModelController();
                dgvCheques.AutoGenerateColumns = false;
                //Set Columns Count
                dgvCheques.ColumnCount = 7;

                //Add Columns FechaEmision
                dgvCheques.Columns[0].Name = "FechaLibrado";
                dgvCheques.Columns[0].HeaderText = "Fecha de Emisión";
                dgvCheques.Columns[0].DataPropertyName = "FechaLibrado";

                dgvCheques.Columns[1].Name = "FechaDePago";
                dgvCheques.Columns[1].HeaderText = "Fecha de Pago";
                dgvCheques.Columns[1].DataPropertyName = "FechaDePago";

                dgvCheques.Columns[2].Name = "Cliente";
                dgvCheques.Columns[2].HeaderText = "Cliente";
                dgvCheques.Columns[2].DataPropertyName = "NombreCliente";

                dgvCheques.Columns[3].Name = "Monto";
                dgvCheques.Columns[3].HeaderText = "Monto";
                dgvCheques.Columns[3].DataPropertyName = "Monto";

                dgvCheques.Columns[4].Name = "Firmante";
                dgvCheques.Columns[4].HeaderText = "Firmante";
                dgvCheques.Columns[4].DataPropertyName = "NombreFirmante";

                dgvCheques.Columns[5].Name = "Rechazado";
                dgvCheques.Columns[5].HeaderText = "Estado";
                dgvCheques.Columns[5].DataPropertyName = "Estado";

                dgvCheques.Columns[6].Name = "Banco";
                dgvCheques.Columns[6].HeaderText = "Banco";
                dgvCheques.Columns[6].DataPropertyName = "Banco";

                dgvCheques.DataSource = mc.ChequeBL.GetAll();
            }
            dgvCheques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheques.AllowUserToResizeColumns = false;
            dgvCheques.AllowUserToResizeRows = false;
        }

        private void dgvCheques_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddEditCheques ChequeForm;
            ChequeDTO c = (ChequeDTO)dgvCheques.CurrentRow.DataBoundItem;

            if (c != null)
            {
                ChequeForm = new AddEditCheques(this);
                ChequeForm.Text = "Editar Cheque";
                ChequeForm.checkValidate = false;
                ChequeForm.currentChequeId = (int)c.Id;
                ChequeForm.ShowDialog(this);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditCheques chequeForm = new AddEditCheques(this);
            chequeForm.Text = "Nuevo Cheque";
            chequeForm.ShowDialog(this);
        }

        private void BuscarPor(string value)
        {
            ModelController mc = new ModelController();
            if (!string.IsNullOrWhiteSpace(value))
            {
                var cheques = mc.ChequeBL.GetChequesByBuscarPor(txtBuscarPor.Text.ToLower());

                if (cheques != null && cheques.Any())
                {
                    dgvCheques.DataSource = null;
                    dgvCheques.Update();
                    dgvCheques.Refresh();
                    dgvCheques.DataSource = cheques;
                }
                else
                    MessageBox.Show("No se encontraron resultados para su busqueda", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Ingrese el nombre o apellido del cliente o firmante", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBorrarCheque_Click(object sender, EventArgs e)
        {
            if (dgvCheques.CurrentRow.Selected)
            {
                ModelController mc = new ModelController();
                ChequeDTO c = (ChequeDTO)dgvCheques.CurrentRow.DataBoundItem;
                string preg = string.Format("Eliminar Cheque nro. de orden {0}?", c.NroOrden);
                DialogResult res = MessageBox.Show(preg, "Pregunta Importante", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    mc.ChequeBL.Delete((int)c.Id);
                    this.FillGridCheques(true);
                }
            }
            else
            {
                MessageBox.Show("No hay cheque seleccionado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExportarClientes_Click(object sender, EventArgs e)
        {
            Common.UiHelper.ExportarDataGridViewExcel(dgvClientes);
        }

        private void btnExportarCheques_Click(object sender, EventArgs e)
        {
            //Common.UiHelper.ExportarDataGridViewExcel(dgvCheques);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = string.Format("Cheques-{0}.xls", DateTime.Now.ToString("dd-MM-yyyy")); //"exportarCheques.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                Common.UiHelper.ExportarDataGridViewExcelWithHeader(dgvCheques, sfd.FileName);
            }

        }

        private void dtpDateFilterSummary_ValueChanged(object sender, EventArgs e)
        {
            ChequesByDay(true);
        }

        private void dgvChequesPorDia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChequeDTO c = (ChequeDTO)dgvChequesPorDia.CurrentRow.DataBoundItem;
            OpenChequeDetail(c);
        }

        private void OpenChequeDetail(ChequeDTO c)
        {
            if (c != null)
            {
                AddEditCheques ChequeForm = new AddEditCheques(this);
                ChequeForm.Text = "Editar Cheque";
                ChequeForm.checkValidate = false;
                ChequeForm.currentChequeId = (int)c.Id;
                ChequeForm.ShowDialog(this);
            }
        }

        private void dgvChequesRechazados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChequeDTO c = (ChequeDTO)dgvChequesRechazados.CurrentRow.DataBoundItem;
            OpenChequeDetail(c);
        }

        private void dgvChequesACobrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChequeDTO c = (ChequeDTO)dgvChequesACobrar.CurrentRow.DataBoundItem;
            OpenChequeDetail(c);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscarPor.Text = string.Empty;
            FillGridCheques(true);
        }
    }
}
