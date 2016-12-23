namespace chApp.UI
{
    partial class AddEditCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCliente));
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBancos = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltrar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCobrado = new System.Windows.Forms.RadioButton();
            this.rbParaCobro = new System.Windows.Forms.RadioButton();
            this.rbRechazado = new System.Windows.Forms.RadioButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefonoAux = new System.Windows.Forms.TextBox();
            this.lblTelefonoAux = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDatosCliente.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.gbFiltros);
            this.gbDatosCliente.Controls.Add(this.btnModificar);
            this.gbDatosCliente.Controls.Add(this.dgvCheques);
            this.gbDatosCliente.Controls.Add(this.label1);
            this.gbDatosCliente.Controls.Add(this.btnCancel);
            this.gbDatosCliente.Controls.Add(this.btnGuardar);
            this.gbDatosCliente.Controls.Add(this.txtMonto);
            this.gbDatosCliente.Controls.Add(this.lblMonto);
            this.gbDatosCliente.Controls.Add(this.txtMail);
            this.gbDatosCliente.Controls.Add(this.lblMail);
            this.gbDatosCliente.Controls.Add(this.txtDireccion);
            this.gbDatosCliente.Controls.Add(this.lblDireccion);
            this.gbDatosCliente.Controls.Add(this.txtTelefonoAux);
            this.gbDatosCliente.Controls.Add(this.lblTelefonoAux);
            this.gbDatosCliente.Controls.Add(this.txtTelefono);
            this.gbDatosCliente.Controls.Add(this.lblTelefono);
            this.gbDatosCliente.Controls.Add(this.txtApellido);
            this.gbDatosCliente.Controls.Add(this.lblApellido);
            this.gbDatosCliente.Controls.Add(this.txtNombre);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Location = new System.Drawing.Point(13, 13);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(710, 484);
            this.gbDatosCliente.TabIndex = 0;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.cboBancos);
            this.gbFiltros.Controls.Add(this.btnLimpiarFiltrar);
            this.gbFiltros.Controls.Add(this.btnFiltrar);
            this.gbFiltros.Controls.Add(this.dtpHasta);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.dtpDesde);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.rbCobrado);
            this.gbFiltros.Controls.Add(this.rbParaCobro);
            this.gbFiltros.Controls.Add(this.rbRechazado);
            this.gbFiltros.Location = new System.Drawing.Point(242, 367);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(462, 100);
            this.gbFiltros.TabIndex = 20;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Banco";
            // 
            // cboBancos
            // 
            this.cboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBancos.FormattingEnabled = true;
            this.cboBancos.Items.AddRange(new object[] {
            "Santander Río",
            "Banco Ciudad",
            "Banco Galicia",
            "Banco Provincia de Buenos Aires",
            "Citibank",
            "Banco Macro",
            "BBVA Frances",
            "ICBC",
            "HSBC",
            "Banco Credicoop",
            "Banco Comafi",
            "Banco Hipotecario",
            "Banco Itaú",
            "Banco Nación",
            "Banco Supervielle",
            "Banco Patagonia",
            "Banco Columbia",
            "Otros Bancos"});
            this.cboBancos.Location = new System.Drawing.Point(233, 28);
            this.cboBancos.Name = "cboBancos";
            this.cboBancos.Size = new System.Drawing.Size(121, 21);
            this.cboBancos.TabIndex = 9;
            // 
            // btnLimpiarFiltrar
            // 
            this.btnLimpiarFiltrar.Location = new System.Drawing.Point(368, 66);
            this.btnLimpiarFiltrar.Name = "btnLimpiarFiltrar";
            this.btnLimpiarFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltrar.TabIndex = 8;
            this.btnLimpiarFiltrar.Text = "Limpiar";
            this.btnLimpiarFiltrar.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltrar.Click += new System.EventHandler(this.btnLimpiarFiltrar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(368, 26);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(138, 69);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(80, 20);
            this.dtpHasta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(138, 29);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(80, 20);
            this.dtpDesde.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // rbCobrado
            // 
            this.rbCobrado.AutoSize = true;
            this.rbCobrado.Location = new System.Drawing.Point(6, 69);
            this.rbCobrado.Name = "rbCobrado";
            this.rbCobrado.Size = new System.Drawing.Size(65, 17);
            this.rbCobrado.TabIndex = 2;
            this.rbCobrado.TabStop = true;
            this.rbCobrado.Text = "Cobrado";
            this.rbCobrado.UseVisualStyleBackColor = true;
            // 
            // rbParaCobro
            // 
            this.rbParaCobro.AutoSize = true;
            this.rbParaCobro.Location = new System.Drawing.Point(6, 44);
            this.rbParaCobro.Name = "rbParaCobro";
            this.rbParaCobro.Size = new System.Drawing.Size(81, 17);
            this.rbParaCobro.TabIndex = 1;
            this.rbParaCobro.TabStop = true;
            this.rbParaCobro.Text = "Para Cobrar";
            this.rbParaCobro.UseVisualStyleBackColor = true;
            // 
            // rbRechazado
            // 
            this.rbRechazado.AutoSize = true;
            this.rbRechazado.Location = new System.Drawing.Point(6, 19);
            this.rbRechazado.Name = "rbRechazado";
            this.rbRechazado.Size = new System.Drawing.Size(80, 17);
            this.rbRechazado.TabIndex = 0;
            this.rbRechazado.TabStop = true;
            this.rbRechazado.Text = "Rechazado";
            this.rbRechazado.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(22, 376);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvCheques
            // 
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheques.Location = new System.Drawing.Point(242, 45);
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheques.Size = new System.Drawing.Size(462, 316);
            this.dgvCheques.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cheques";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(103, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(22, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(4, 341);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(202, 20);
            this.txtMonto.TabIndex = 14;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(5, 325);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(76, 13);
            this.lblMonto.TabIndex = 13;
            this.lblMonto.Text = "Monto Maximo";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(4, 289);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(202, 20);
            this.txtMail.TabIndex = 12;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(5, 273);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "E-Mail";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(4, 238);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(202, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(5, 222);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtTelefonoAux
            // 
            this.txtTelefonoAux.Location = new System.Drawing.Point(5, 190);
            this.txtTelefonoAux.Name = "txtTelefonoAux";
            this.txtTelefonoAux.Size = new System.Drawing.Size(202, 20);
            this.txtTelefonoAux.TabIndex = 8;
            // 
            // lblTelefonoAux
            // 
            this.lblTelefonoAux.AutoSize = true;
            this.lblTelefonoAux.Location = new System.Drawing.Point(6, 174);
            this.lblTelefonoAux.Name = "lblTelefonoAux";
            this.lblTelefonoAux.Size = new System.Drawing.Size(73, 13);
            this.lblTelefonoAux.TabIndex = 7;
            this.lblTelefonoAux.Text = "Telefono Aux.";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(5, 144);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(202, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 128);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(5, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(202, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 77);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // AddEditCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(737, 511);
            this.Controls.Add(this.gbDatosCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(753, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(753, 550);
            this.Name = "AddEditCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditCliente";
            this.Load += new System.EventHandler(this.AddEditCliente_Load);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefonoAux;
        private System.Windows.Forms.Label lblTelefonoAux;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvCheques;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.RadioButton rbCobrado;
        private System.Windows.Forms.RadioButton rbParaCobro;
        private System.Windows.Forms.RadioButton rbRechazado;
        private System.Windows.Forms.Button btnLimpiarFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBancos;
        private System.Windows.Forms.Label label4;
    }
}