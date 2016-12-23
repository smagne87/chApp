namespace chApp.UI
{
    partial class AddEditCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCheques));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTenedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chCobrado = new System.Windows.Forms.CheckBox();
            this.cboBancos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtLibrador = new System.Windows.Forms.TextBox();
            this.cboBeneficiario = new System.Windows.Forms.ComboBox();
            this.txtMontoDescontar = new System.Windows.Forms.TextBox();
            this.lblMontoDescontar = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.mTxtCuit = new System.Windows.Forms.MaskedTextBox();
            this.lblLibrado = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtNroOrden = new System.Windows.Forms.TextBox();
            this.lblNroOrden = new System.Windows.Forms.Label();
            this.lblBeneficiario = new System.Windows.Forms.Label();
            this.txtLugarEmision = new System.Windows.Forms.TextBox();
            this.lblLugaremision = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTenedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chCobrado);
            this.groupBox1.Controls.Add(this.cboBancos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chbEstado);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtLibrador);
            this.groupBox1.Controls.Add(this.cboBeneficiario);
            this.groupBox1.Controls.Add(this.txtMontoDescontar);
            this.groupBox1.Controls.Add(this.lblMontoDescontar);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.lblDescuento);
            this.groupBox1.Controls.Add(this.dtpFechaPago);
            this.groupBox1.Controls.Add(this.lblFechaPago);
            this.groupBox1.Controls.Add(this.dtpFechaEmision);
            this.groupBox1.Controls.Add(this.lblFechaEmision);
            this.groupBox1.Controls.Add(this.mTxtCuit);
            this.groupBox1.Controls.Add(this.lblLibrado);
            this.groupBox1.Controls.Add(this.lblCuit);
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.lblCuenta);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Controls.Add(this.txtNroOrden);
            this.groupBox1.Controls.Add(this.lblNroOrden);
            this.groupBox1.Controls.Add(this.lblBeneficiario);
            this.groupBox1.Controls.Add(this.txtLugarEmision);
            this.groupBox1.Controls.Add(this.lblLugaremision);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 454);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cheque";
            // 
            // cboTenedor
            // 
            this.cboTenedor.FormattingEnabled = true;
            this.cboTenedor.Location = new System.Drawing.Point(7, 417);
            this.cboTenedor.Name = "cboTenedor";
            this.cboTenedor.Size = new System.Drawing.Size(192, 21);
            this.cboTenedor.TabIndex = 36;
            this.cboTenedor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboTenedorFormat);
            this.cboTenedor.SelectedValueChanged += new System.EventHandler(this.cboTenedor_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tenedor";
            // 
            // chCobrado
            // 
            this.chCobrado.AutoSize = true;
            this.chCobrado.Location = new System.Drawing.Point(351, 223);
            this.chCobrado.Name = "chCobrado";
            this.chCobrado.Size = new System.Drawing.Size(66, 17);
            this.chCobrado.TabIndex = 34;
            this.chCobrado.Text = "Cobrado";
            this.chCobrado.UseVisualStyleBackColor = true;
            this.chCobrado.CheckedChanged += new System.EventHandler(this.chCobrado_CheckedChanged);
            // 
            // cboBancos
            // 
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
            this.cboBancos.Location = new System.Drawing.Point(7, 281);
            this.cboBancos.Name = "cboBancos";
            this.cboBancos.Size = new System.Drawing.Size(192, 21);
            this.cboBancos.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Banco";
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(254, 223);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(81, 17);
            this.chbEstado.TabIndex = 12;
            this.chbEstado.Text = "Rechazado";
            this.chbEstado.UseVisualStyleBackColor = true;
            this.chbEstado.CheckedChanged += new System.EventHandler(this.chbEstado_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(371, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLibrador
            // 
            this.txtLibrador.Location = new System.Drawing.Point(7, 374);
            this.txtLibrador.Name = "txtLibrador";
            this.txtLibrador.Size = new System.Drawing.Size(191, 20);
            this.txtLibrador.TabIndex = 6;
            this.txtLibrador.TextChanged += new System.EventHandler(this.txtLibrador_TextChanged);
            // 
            // cboBeneficiario
            // 
            this.cboBeneficiario.FormattingEnabled = true;
            this.cboBeneficiario.Location = new System.Drawing.Point(6, 94);
            this.cboBeneficiario.Name = "cboBeneficiario";
            this.cboBeneficiario.Size = new System.Drawing.Size(192, 21);
            this.cboBeneficiario.TabIndex = 1;
            this.cboBeneficiario.SelectedIndexChanged += new System.EventHandler(this.cboBeneficiario_SelectedIndexChanged);
            this.cboBeneficiario.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboBeneficiarioFormat);
            // 
            // txtMontoDescontar
            // 
            this.txtMontoDescontar.Location = new System.Drawing.Point(254, 189);
            this.txtMontoDescontar.Name = "txtMontoDescontar";
            this.txtMontoDescontar.Size = new System.Drawing.Size(192, 20);
            this.txtMontoDescontar.TabIndex = 10;
            // 
            // lblMontoDescontar
            // 
            this.lblMontoDescontar.AutoSize = true;
            this.lblMontoDescontar.Location = new System.Drawing.Point(254, 173);
            this.lblMontoDescontar.Name = "lblMontoDescontar";
            this.lblMontoDescontar.Size = new System.Drawing.Size(98, 13);
            this.lblMontoDescontar.TabIndex = 31;
            this.lblMontoDescontar.Text = "Monto a Descontar";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(254, 139);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(192, 20);
            this.txtDescuento.TabIndex = 9;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(254, 123);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 30;
            this.lblDescuento.Text = "Descuento";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(254, 95);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 8;
            this.dtpFechaPago.ValueChanged += new System.EventHandler(this.dtpFechaPago_ValueChanged);
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(251, 78);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 29;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(254, 44);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEmision.TabIndex = 7;
            this.dtpFechaEmision.ValueChanged += new System.EventHandler(this.dtpFechaPago_ValueChanged);
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(251, 27);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(92, 13);
            this.lblFechaEmision.TabIndex = 28;
            this.lblFechaEmision.Text = "Fecha de Entrega";
            // 
            // mTxtCuit
            // 
            this.mTxtCuit.Location = new System.Drawing.Point(7, 325);
            this.mTxtCuit.Mask = "00-00000000-0";
            this.mTxtCuit.Name = "mTxtCuit";
            this.mTxtCuit.Size = new System.Drawing.Size(191, 20);
            this.mTxtCuit.TabIndex = 5;
            this.mTxtCuit.TextChanged += new System.EventHandler(this.mTxtCuit_TextChanged);
            // 
            // lblLibrado
            // 
            this.lblLibrado.AutoSize = true;
            this.lblLibrado.Location = new System.Drawing.Point(6, 358);
            this.lblLibrado.Name = "lblLibrado";
            this.lblLibrado.Size = new System.Drawing.Size(45, 13);
            this.lblLibrado.TabIndex = 27;
            this.lblLibrado.Text = "Librador";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(6, 308);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(25, 13);
            this.lblCuit.TabIndex = 26;
            this.lblCuit.Text = "Cuit";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(6, 239);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(192, 20);
            this.txtCuenta.TabIndex = 4;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(6, 223);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 25;
            this.lblCuenta.Text = "Cuenta";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(6, 189);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(192, 20);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(6, 173);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 24;
            this.lblMonto.Text = "Monto";
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.Location = new System.Drawing.Point(6, 139);
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.Size = new System.Drawing.Size(192, 20);
            this.txtNroOrden.TabIndex = 2;
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Location = new System.Drawing.Point(6, 123);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Size = new System.Drawing.Size(79, 13);
            this.lblNroOrden.TabIndex = 23;
            this.lblNroOrden.Text = "Nro de Cheque";
            // 
            // lblBeneficiario
            // 
            this.lblBeneficiario.AutoSize = true;
            this.lblBeneficiario.Location = new System.Drawing.Point(6, 78);
            this.lblBeneficiario.Name = "lblBeneficiario";
            this.lblBeneficiario.Size = new System.Drawing.Size(62, 13);
            this.lblBeneficiario.TabIndex = 21;
            this.lblBeneficiario.Text = "Beneficiario";
            // 
            // txtLugarEmision
            // 
            this.txtLugarEmision.Location = new System.Drawing.Point(6, 44);
            this.txtLugarEmision.Name = "txtLugarEmision";
            this.txtLugarEmision.Size = new System.Drawing.Size(192, 20);
            this.txtLugarEmision.TabIndex = 0;
            // 
            // lblLugaremision
            // 
            this.lblLugaremision.AutoSize = true;
            this.lblLugaremision.Location = new System.Drawing.Point(6, 28);
            this.lblLugaremision.Name = "lblLugaremision";
            this.lblLugaremision.Size = new System.Drawing.Size(88, 13);
            this.lblLugaremision.TabIndex = 20;
            this.lblLugaremision.Text = "Lugar de Emisión";
            // 
            // AddEditCheques
            // 
            this.ClientSize = new System.Drawing.Size(490, 479);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditCheques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddEditCheques_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.GroupBox gbDatosCheque;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.TextBox textBox5;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.TextBox textBox4;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.TextBox textBox3;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLibrado;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtNroOrden;
        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.Label lblBeneficiario;
        private System.Windows.Forms.TextBox txtLugarEmision;
        private System.Windows.Forms.Label lblLugaremision;
        private System.Windows.Forms.MaskedTextBox mTxtCuit;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.TextBox txtMontoDescontar;
        private System.Windows.Forms.Label lblMontoDescontar;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.ComboBox cboBeneficiario;
        private System.Windows.Forms.TextBox txtLibrador;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.ComboBox cboBancos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chCobrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTenedor;
    }
}