namespace Vista
{
    partial class frmEmpresa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRutEmpresa = new System.Windows.Forms.Label();
            this.textBoxRutEmpresa = new System.Windows.Forms.TextBox();
            this.labelCorreoEmisor = new System.Windows.Forms.Label();
            this.textBoxCorreoEmisor = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelActeco = new System.Windows.Forms.Label();
            this.textBoxActeco = new System.Windows.Forms.TextBox();
            this.labelGiroEmisor = new System.Windows.Forms.Label();
            this.textBoxGiroEmisor = new System.Windows.Forms.TextBox();
            this.labelDireccionOrigen = new System.Windows.Forms.Label();
            this.textBoxDireccionOrigen = new System.Windows.Forms.TextBox();
            this.labelCodigoSucursal = new System.Windows.Forms.Label();
            this.textBoxCodigoSucursal = new System.Windows.Forms.TextBox();
            this.labelComunaOrigen = new System.Windows.Forms.Label();
            this.textBoxComunaOrigen = new System.Windows.Forms.TextBox();
            this.labelTelefonoEmisor = new System.Windows.Forms.Label();
            this.textBoxTelefonoEmisor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCiudadOrigen = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblNomCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 255);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCliente.Location = new System.Drawing.Point(5, 3);
            this.lblNomCliente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(915, 18);
            this.lblNomCliente.TabIndex = 19;
            this.lblNomCliente.Text = "EMPRESA";
            this.lblNomCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCiudadOrigen, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelTelefonoEmisor, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTelefonoEmisor, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelComunaOrigen, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxComunaOrigen, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelCodigoSucursal, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCodigoSucursal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelDireccionOrigen, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDireccionOrigen, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelGiroEmisor, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxGiroEmisor, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelActeco, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxActeco, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelRazonSocial, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxRazonSocial, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCorreoEmisor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCorreoEmisor, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelRutEmpresa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxRutEmpresa, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(917, 136);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // labelRutEmpresa
            // 
            this.labelRutEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRutEmpresa.AutoSize = true;
            this.labelRutEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutEmpresa.Location = new System.Drawing.Point(3, 6);
            this.labelRutEmpresa.Name = "labelRutEmpresa";
            this.labelRutEmpresa.Size = new System.Drawing.Size(83, 13);
            this.labelRutEmpresa.TabIndex = 0;
            this.labelRutEmpresa.Text = "Rut Empresa:";
            // 
            // textBoxRutEmpresa
            // 
            this.textBoxRutEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRutEmpresa.Location = new System.Drawing.Point(112, 3);
            this.textBoxRutEmpresa.Name = "textBoxRutEmpresa";
            this.textBoxRutEmpresa.Size = new System.Drawing.Size(184, 20);
            this.textBoxRutEmpresa.TabIndex = 1;
            // 
            // labelCorreoEmisor
            // 
            this.labelCorreoEmisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCorreoEmisor.AutoSize = true;
            this.labelCorreoEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoEmisor.Location = new System.Drawing.Point(454, 6);
            this.labelCorreoEmisor.Name = "labelCorreoEmisor";
            this.labelCorreoEmisor.Size = new System.Drawing.Size(89, 13);
            this.labelCorreoEmisor.TabIndex = 2;
            this.labelCorreoEmisor.Text = "Correo Emisor:";
            // 
            // textBoxCorreoEmisor
            // 
            this.textBoxCorreoEmisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCorreoEmisor.Location = new System.Drawing.Point(566, 3);
            this.textBoxCorreoEmisor.Name = "textBoxCorreoEmisor";
            this.textBoxCorreoEmisor.Size = new System.Drawing.Size(266, 20);
            this.textBoxCorreoEmisor.TabIndex = 3;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazonSocial.Location = new System.Drawing.Point(3, 32);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(86, 13);
            this.labelRazonSocial.TabIndex = 4;
            this.labelRazonSocial.Text = "Razon Social:";
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRazonSocial.Location = new System.Drawing.Point(112, 29);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(336, 20);
            this.textBoxRazonSocial.TabIndex = 5;
            // 
            // labelActeco
            // 
            this.labelActeco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelActeco.AutoSize = true;
            this.labelActeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActeco.Location = new System.Drawing.Point(454, 32);
            this.labelActeco.Name = "labelActeco";
            this.labelActeco.Size = new System.Drawing.Size(51, 13);
            this.labelActeco.TabIndex = 6;
            this.labelActeco.Text = "Acteco:";
            // 
            // textBoxActeco
            // 
            this.textBoxActeco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxActeco.Location = new System.Drawing.Point(566, 29);
            this.textBoxActeco.Name = "textBoxActeco";
            this.textBoxActeco.Size = new System.Drawing.Size(100, 20);
            this.textBoxActeco.TabIndex = 7;
            // 
            // labelGiroEmisor
            // 
            this.labelGiroEmisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGiroEmisor.AutoSize = true;
            this.labelGiroEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiroEmisor.Location = new System.Drawing.Point(3, 58);
            this.labelGiroEmisor.Name = "labelGiroEmisor";
            this.labelGiroEmisor.Size = new System.Drawing.Size(75, 13);
            this.labelGiroEmisor.TabIndex = 8;
            this.labelGiroEmisor.Text = "Giro Emisor:";
            // 
            // textBoxGiroEmisor
            // 
            this.textBoxGiroEmisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGiroEmisor.Location = new System.Drawing.Point(112, 55);
            this.textBoxGiroEmisor.Name = "textBoxGiroEmisor";
            this.textBoxGiroEmisor.Size = new System.Drawing.Size(336, 20);
            this.textBoxGiroEmisor.TabIndex = 9;
            // 
            // labelDireccionOrigen
            // 
            this.labelDireccionOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDireccionOrigen.AutoSize = true;
            this.labelDireccionOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccionOrigen.Location = new System.Drawing.Point(454, 58);
            this.labelDireccionOrigen.Name = "labelDireccionOrigen";
            this.labelDireccionOrigen.Size = new System.Drawing.Size(106, 13);
            this.labelDireccionOrigen.TabIndex = 10;
            this.labelDireccionOrigen.Text = "Dirección Origen:";
            // 
            // textBoxDireccionOrigen
            // 
            this.textBoxDireccionOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDireccionOrigen.Location = new System.Drawing.Point(566, 55);
            this.textBoxDireccionOrigen.Name = "textBoxDireccionOrigen";
            this.textBoxDireccionOrigen.Size = new System.Drawing.Size(343, 20);
            this.textBoxDireccionOrigen.TabIndex = 11;
            // 
            // labelCodigoSucursal
            // 
            this.labelCodigoSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCodigoSucursal.AutoSize = true;
            this.labelCodigoSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoSucursal.Location = new System.Drawing.Point(3, 84);
            this.labelCodigoSucursal.Name = "labelCodigoSucursal";
            this.labelCodigoSucursal.Size = new System.Drawing.Size(103, 13);
            this.labelCodigoSucursal.TabIndex = 12;
            this.labelCodigoSucursal.Text = "Codigo Sucursal:";
            // 
            // textBoxCodigoSucursal
            // 
            this.textBoxCodigoSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCodigoSucursal.Location = new System.Drawing.Point(112, 81);
            this.textBoxCodigoSucursal.Name = "textBoxCodigoSucursal";
            this.textBoxCodigoSucursal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoSucursal.TabIndex = 13;
            // 
            // labelComunaOrigen
            // 
            this.labelComunaOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelComunaOrigen.AutoSize = true;
            this.labelComunaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComunaOrigen.Location = new System.Drawing.Point(454, 84);
            this.labelComunaOrigen.Name = "labelComunaOrigen";
            this.labelComunaOrigen.Size = new System.Drawing.Size(97, 13);
            this.labelComunaOrigen.TabIndex = 14;
            this.labelComunaOrigen.Text = "Comuna Origen:";
            // 
            // textBoxComunaOrigen
            // 
            this.textBoxComunaOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxComunaOrigen.Location = new System.Drawing.Point(566, 81);
            this.textBoxComunaOrigen.Name = "textBoxComunaOrigen";
            this.textBoxComunaOrigen.Size = new System.Drawing.Size(242, 20);
            this.textBoxComunaOrigen.TabIndex = 15;
            // 
            // labelTelefonoEmisor
            // 
            this.labelTelefonoEmisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTelefonoEmisor.AutoSize = true;
            this.labelTelefonoEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoEmisor.Location = new System.Drawing.Point(3, 113);
            this.labelTelefonoEmisor.Name = "labelTelefonoEmisor";
            this.labelTelefonoEmisor.Size = new System.Drawing.Size(102, 13);
            this.labelTelefonoEmisor.TabIndex = 16;
            this.labelTelefonoEmisor.Text = "Telefono Emisor:";
            // 
            // textBoxTelefonoEmisor
            // 
            this.textBoxTelefonoEmisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTelefonoEmisor.Location = new System.Drawing.Point(112, 110);
            this.textBoxTelefonoEmisor.Name = "textBoxTelefonoEmisor";
            this.textBoxTelefonoEmisor.Size = new System.Drawing.Size(287, 20);
            this.textBoxTelefonoEmisor.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(454, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ciudad Origen:";
            // 
            // textBoxCiudadOrigen
            // 
            this.textBoxCiudadOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCiudadOrigen.Location = new System.Drawing.Point(566, 110);
            this.textBoxCiudadOrigen.Name = "textBoxCiudadOrigen";
            this.textBoxCiudadOrigen.Size = new System.Drawing.Size(242, 20);
            this.textBoxCiudadOrigen.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnSalir, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnModifica, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 170);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(346, 70);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Green;
            this.btnSalir.Image = global::Vista.Properties.Resources.exit_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(3, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 63);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.FlatAppearance.BorderSize = 2;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.Green;
            this.btnModifica.Image = global::Vista.Properties.Resources.edit_5_32;
            this.btnModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModifica.Location = new System.Drawing.Point(89, 3);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(80, 63);
            this.btnModifica.TabIndex = 21;
            this.btnModifica.Text = "MODIFICAR";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 244);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCiudadOrigen;
        private System.Windows.Forms.Label labelTelefonoEmisor;
        private System.Windows.Forms.TextBox textBoxTelefonoEmisor;
        private System.Windows.Forms.Label labelComunaOrigen;
        private System.Windows.Forms.TextBox textBoxComunaOrigen;
        private System.Windows.Forms.Label labelCodigoSucursal;
        private System.Windows.Forms.TextBox textBoxCodigoSucursal;
        private System.Windows.Forms.Label labelDireccionOrigen;
        private System.Windows.Forms.TextBox textBoxDireccionOrigen;
        private System.Windows.Forms.Label labelGiroEmisor;
        private System.Windows.Forms.TextBox textBoxGiroEmisor;
        private System.Windows.Forms.Label labelActeco;
        private System.Windows.Forms.TextBox textBoxActeco;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label labelCorreoEmisor;
        private System.Windows.Forms.TextBox textBoxCorreoEmisor;
        private System.Windows.Forms.Label labelRutEmpresa;
        private System.Windows.Forms.TextBox textBoxRutEmpresa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModifica;
    }
}