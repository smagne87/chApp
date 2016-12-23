namespace chApp.UI
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.TabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateFilterSummary = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChequesACobrar = new System.Windows.Forms.DataGridView();
            this.dgvChequesRechazados = new System.Windows.Forms.DataGridView();
            this.dgvChequesPorDia = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExportarClientes = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBorrarFirmante = new System.Windows.Forms.Button();
            this.btnCreateFirmante = new System.Windows.Forms.Button();
            this.dgvFirmantes = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExportarCheques = new System.Windows.Forms.Button();
            this.btnBorrarCheque = new System.Windows.Forms.Button();
            this.btnBuscarPor = new System.Windows.Forms.Button();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.TabControlPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequesACobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequesRechazados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequesPorDia)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmantes)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlPrincipal
            // 
            this.TabControlPrincipal.Controls.Add(this.tabPage1);
            this.TabControlPrincipal.Controls.Add(this.tabPage3);
            this.TabControlPrincipal.Controls.Add(this.tabPage2);
            this.TabControlPrincipal.Controls.Add(this.tabPage4);
            this.TabControlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.TabControlPrincipal.Name = "TabControlPrincipal";
            this.TabControlPrincipal.SelectedIndex = 0;
            this.TabControlPrincipal.Size = new System.Drawing.Size(916, 458);
            this.TabControlPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpDateFilterSummary);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvChequesACobrar);
            this.tabPage1.Controls.Add(this.dgvChequesRechazados);
            this.tabPage1.Controls.Add(this.dgvChequesPorDia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resumen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cheques a Cobrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cheques Rechazados";
            // 
            // dtpDateFilterSummary
            // 
            this.dtpDateFilterSummary.Location = new System.Drawing.Point(94, 6);
            this.dtpDateFilterSummary.Name = "dtpDateFilterSummary";
            this.dtpDateFilterSummary.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFilterSummary.TabIndex = 5;
            this.dtpDateFilterSummary.ValueChanged += new System.EventHandler(this.dtpDateFilterSummary_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cheques del Dia: ";
            // 
            // dgvChequesACobrar
            // 
            this.dgvChequesACobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChequesACobrar.Location = new System.Drawing.Point(452, 241);
            this.dgvChequesACobrar.Name = "dgvChequesACobrar";
            this.dgvChequesACobrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChequesACobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChequesACobrar.ShowCellErrors = false;
            this.dgvChequesACobrar.ShowCellToolTips = false;
            this.dgvChequesACobrar.ShowEditingIcon = false;
            this.dgvChequesACobrar.Size = new System.Drawing.Size(450, 185);
            this.dgvChequesACobrar.TabIndex = 3;
            this.dgvChequesACobrar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChequesACobrar_CellDoubleClick);
            // 
            // dgvChequesRechazados
            // 
            this.dgvChequesRechazados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChequesRechazados.Location = new System.Drawing.Point(452, 31);
            this.dgvChequesRechazados.Name = "dgvChequesRechazados";
            this.dgvChequesRechazados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChequesRechazados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChequesRechazados.ShowCellErrors = false;
            this.dgvChequesRechazados.ShowCellToolTips = false;
            this.dgvChequesRechazados.ShowEditingIcon = false;
            this.dgvChequesRechazados.Size = new System.Drawing.Size(450, 185);
            this.dgvChequesRechazados.TabIndex = 2;
            this.dgvChequesRechazados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChequesRechazados_CellDoubleClick);
            // 
            // dgvChequesPorDia
            // 
            this.dgvChequesPorDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChequesPorDia.Location = new System.Drawing.Point(6, 31);
            this.dgvChequesPorDia.Name = "dgvChequesPorDia";
            this.dgvChequesPorDia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChequesPorDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChequesPorDia.ShowCellErrors = false;
            this.dgvChequesPorDia.ShowCellToolTips = false;
            this.dgvChequesPorDia.ShowEditingIcon = false;
            this.dgvChequesPorDia.Size = new System.Drawing.Size(440, 395);
            this.dgvChequesPorDia.TabIndex = 1;
            this.dgvChequesPorDia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChequesPorDia_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnExportarClientes);
            this.tabPage3.Controls.Add(this.txtBuscarCliente);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnBorrar);
            this.tabPage3.Controls.Add(this.btnAddCliente);
            this.tabPage3.Controls.Add(this.dgvClientes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(908, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clientes";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // btnExportarClientes
            // 
            this.btnExportarClientes.Location = new System.Drawing.Point(730, 174);
            this.btnExportarClientes.Name = "btnExportarClientes";
            this.btnExportarClientes.Size = new System.Drawing.Size(99, 23);
            this.btnExportarClientes.TabIndex = 5;
            this.btnExportarClientes.Text = "Exportar Excel";
            this.btnExportarClientes.UseVisualStyleBackColor = true;
            this.btnExportarClientes.Click += new System.EventHandler(this.btnExportarClientes_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(730, 136);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(164, 20);
            this.txtBuscarCliente.TabIndex = 4;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Cliente";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(730, 78);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(99, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar Cliente";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(730, 34);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(99, 23);
            this.btnAddCliente.TabIndex = 1;
            this.btnAddCliente.Text = "Nuevo Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click_1);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Location = new System.Drawing.Point(4, 34);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(705, 395);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBorrarFirmante);
            this.tabPage2.Controls.Add(this.btnCreateFirmante);
            this.tabPage2.Controls.Add(this.dgvFirmantes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Firmantes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBorrarFirmante
            // 
            this.btnBorrarFirmante.Location = new System.Drawing.Point(732, 77);
            this.btnBorrarFirmante.Name = "btnBorrarFirmante";
            this.btnBorrarFirmante.Size = new System.Drawing.Size(137, 23);
            this.btnBorrarFirmante.TabIndex = 5;
            this.btnBorrarFirmante.Text = "Borrar Firmante";
            this.btnBorrarFirmante.UseVisualStyleBackColor = true;
            this.btnBorrarFirmante.Click += new System.EventHandler(this.btnBorrarFirmante_Click);
            // 
            // btnCreateFirmante
            // 
            this.btnCreateFirmante.Location = new System.Drawing.Point(732, 34);
            this.btnCreateFirmante.Name = "btnCreateFirmante";
            this.btnCreateFirmante.Size = new System.Drawing.Size(137, 23);
            this.btnCreateFirmante.TabIndex = 4;
            this.btnCreateFirmante.Text = "Nuevo Firmante";
            this.btnCreateFirmante.UseVisualStyleBackColor = true;
            this.btnCreateFirmante.Click += new System.EventHandler(this.btnCreateFirmante_Click);
            // 
            // dgvFirmantes
            // 
            this.dgvFirmantes.AllowUserToAddRows = false;
            this.dgvFirmantes.AllowUserToDeleteRows = false;
            this.dgvFirmantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirmantes.Location = new System.Drawing.Point(4, 34);
            this.dgvFirmantes.Name = "dgvFirmantes";
            this.dgvFirmantes.ReadOnly = true;
            this.dgvFirmantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFirmantes.ShowCellErrors = false;
            this.dgvFirmantes.ShowCellToolTips = false;
            this.dgvFirmantes.ShowEditingIcon = false;
            this.dgvFirmantes.ShowRowErrors = false;
            this.dgvFirmantes.Size = new System.Drawing.Size(705, 395);
            this.dgvFirmantes.TabIndex = 3;
            this.dgvFirmantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirmantes_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClear);
            this.tabPage4.Controls.Add(this.btnExportarCheques);
            this.tabPage4.Controls.Add(this.btnBorrarCheque);
            this.tabPage4.Controls.Add(this.btnBuscarPor);
            this.tabPage4.Controls.Add(this.txtBuscarPor);
            this.tabPage4.Controls.Add(this.lblBuscarPor);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.dgvCheques);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(908, 432);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cheques";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExportarCheques
            // 
            this.btnExportarCheques.Location = new System.Drawing.Point(729, 229);
            this.btnExportarCheques.Name = "btnExportarCheques";
            this.btnExportarCheques.Size = new System.Drawing.Size(99, 23);
            this.btnExportarCheques.TabIndex = 6;
            this.btnExportarCheques.Text = "Exportar Excel";
            this.btnExportarCheques.UseVisualStyleBackColor = true;
            this.btnExportarCheques.Click += new System.EventHandler(this.btnExportarCheques_Click);
            // 
            // btnBorrarCheque
            // 
            this.btnBorrarCheque.Location = new System.Drawing.Point(729, 69);
            this.btnBorrarCheque.Name = "btnBorrarCheque";
            this.btnBorrarCheque.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCheque.TabIndex = 5;
            this.btnBorrarCheque.Text = "Borrar";
            this.btnBorrarCheque.UseVisualStyleBackColor = true;
            this.btnBorrarCheque.Click += new System.EventHandler(this.btnBorrarCheque_Click);
            // 
            // btnBuscarPor
            // 
            this.btnBuscarPor.Location = new System.Drawing.Point(729, 140);
            this.btnBuscarPor.Name = "btnBuscarPor";
            this.btnBuscarPor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPor.TabIndex = 4;
            this.btnBuscarPor.Text = "Buscar";
            this.btnBuscarPor.UseVisualStyleBackColor = true;
            this.btnBuscarPor.Click += new System.EventHandler(this.btnBuscarPor_Click);
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(729, 114);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(154, 20);
            this.txtBuscarPor.TabIndex = 3;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(726, 98);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(62, 13);
            this.lblBuscarPor.TabIndex = 2;
            this.lblBuscarPor.Text = "Buscar Por:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCheques
            // 
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheques.Location = new System.Drawing.Point(4, 34);
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheques.ShowCellErrors = false;
            this.dgvCheques.ShowCellToolTips = false;
            this.dgvCheques.ShowEditingIcon = false;
            this.dgvCheques.Size = new System.Drawing.Size(705, 395);
            this.dgvCheques.TabIndex = 0;
            this.dgvCheques.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheques_CellDoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(808, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 482);
            this.Controls.Add(this.TabControlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor App";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.TabControlPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequesACobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequesRechazados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequesPorDia)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmantes)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBorrarFirmante;
        private System.Windows.Forms.Button btnCreateFirmante;
        private System.Windows.Forms.DataGridView dgvFirmantes;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvCheques;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Button btnBuscarPor;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarCheque;
        private System.Windows.Forms.Button btnExportarClientes;
        private System.Windows.Forms.Button btnExportarCheques;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateFilterSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChequesACobrar;
        private System.Windows.Forms.DataGridView dgvChequesRechazados;
        private System.Windows.Forms.DataGridView dgvChequesPorDia;
        private System.Windows.Forms.Button btnClear;
    }
}