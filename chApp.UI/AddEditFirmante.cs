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
    public partial class AddEditFirmante : Form
    {
        ModelController mc = new ModelController();
        private string error = string.Empty;
        public int currentFirmanteId { get; set; }

        public AddEditFirmante()
        {
            InitializeComponent();
        }

        private Principal mainForm = null;
        public AddEditFirmante(Form callingForm)
        {
            mainForm = callingForm as Principal;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Common.UiHelper.IsNameValid(txtNombre.Text) && Common.UiHelper.IsEmailValid(txtMail.Text))
            {
                if (currentFirmanteId == 0)
                {
                    try
                    {
                        var newFirmante = new chApp.BLL.FirmanteDTO();
                        newFirmante.Nombre = txtNombre.Text;
                        newFirmante.Telefono = txtTelefono.Text;
                        newFirmante.Direccion = txtDireccion.Text;
                        newFirmante.Email = txtMail.Text;
                        newFirmante.Cuit = UiHelper.CuitConverter(mtxtCuit.Text);
                        mc.FirmanteBL.Create(newFirmante);
                        currentFirmanteId = (int)mc.FirmanteBL.GetFirmanteByCuit(newFirmante.Cuit).Id;
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
                        var currentFirmante = mc.FirmanteBL.GetById(currentFirmanteId);
                        currentFirmante.Nombre = txtNombre.Text;
                        currentFirmante.Telefono = txtTelefono.Text;
                        currentFirmante.Direccion = txtDireccion.Text;
                        currentFirmante.Email = txtMail.Text;
                        currentFirmante.Cuit = UiHelper.CuitConverter(mtxtCuit.Text);

                        mc.FirmanteBL.Update(currentFirmante);
                    }
                    catch (Exception ex)
                    {
                        UiHelper.WarningMessage(ex.Message);
                    }
                }

                if(this.mainForm != null)
                    this.mainForm.FillGridFirmantes(true);
                this.Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void AddEditFirmante_Load(object sender, EventArgs e)
        {
            if (currentFirmanteId > 0)
            {
                var currentFirmante = mc.FirmanteBL.GetById(currentFirmanteId);
                txtNombre.Text = currentFirmante.Nombre;
                mtxtCuit.Text = currentFirmante.Cuit;
                txtTelefono.Text = currentFirmante.Telefono;
                txtDireccion.Text = currentFirmante.Direccion;
                txtMail.Text = currentFirmante.Email;
            }

            if (!string.IsNullOrEmpty(error))
            {
                UiHelper.WarningMessage(error);
                error = string.Empty;
            }
        }

    }
}
