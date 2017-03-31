namespace Vista
{
    partial class frmConfigPos
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelRutaPrint = new System.Windows.Forms.Label();
            this.btnConfigPosSalir = new System.Windows.Forms.Button();
            this.buttonAcepta = new System.Windows.Forms.Button();
            this.buttonBuscaRuta = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblProductos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.buttonAcepta, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnConfigPosSalir, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 134);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(316, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.labelRutaPrint, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonBuscaRuta, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(706, 100);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(5, 3);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(729, 18);
            this.lblProductos.TabIndex = 20;
            this.lblProductos.Text = "CONFIGURACIÓN PUNTO DE VENTA";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta de la Impresora:";
            // 
            // labelRutaPrint
            // 
            this.labelRutaPrint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRutaPrint.AutoSize = true;
            this.labelRutaPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutaPrint.Location = new System.Drawing.Point(241, 17);
            this.labelRutaPrint.Name = "labelRutaPrint";
            this.labelRutaPrint.Size = new System.Drawing.Size(0, 15);
            this.labelRutaPrint.TabIndex = 6;
            // 
            // btnConfigPosSalir
            // 
            this.btnConfigPosSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfigPosSalir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnConfigPosSalir.FlatAppearance.BorderSize = 2;
            this.btnConfigPosSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigPosSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigPosSalir.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnConfigPosSalir.Image = global::Vista.Properties.Resources.exit_32;
            this.btnConfigPosSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfigPosSalir.Location = new System.Drawing.Point(6, 6);
            this.btnConfigPosSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfigPosSalir.Name = "btnConfigPosSalir";
            this.btnConfigPosSalir.Size = new System.Drawing.Size(73, 63);
            this.btnConfigPosSalir.TabIndex = 19;
            this.btnConfigPosSalir.Text = "SALIR";
            this.btnConfigPosSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfigPosSalir.UseVisualStyleBackColor = false;
            this.btnConfigPosSalir.Click += new System.EventHandler(this.btnConfigPosSalir_Click);
            // 
            // buttonAcepta
            // 
            this.buttonAcepta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAcepta.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonAcepta.FlatAppearance.BorderSize = 2;
            this.buttonAcepta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcepta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcepta.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonAcepta.Image = global::Vista.Properties.Resources.check_mark_11_32;
            this.buttonAcepta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAcepta.Location = new System.Drawing.Point(91, 6);
            this.buttonAcepta.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAcepta.Name = "buttonAcepta";
            this.buttonAcepta.Size = new System.Drawing.Size(80, 63);
            this.buttonAcepta.TabIndex = 20;
            this.buttonAcepta.Text = "ACEPTAR";
            this.buttonAcepta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAcepta.UseVisualStyleBackColor = false;
            this.buttonAcepta.Click += new System.EventHandler(this.buttonAcepta_Click);
            // 
            // buttonBuscaRuta
            // 
            this.buttonBuscaRuta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBuscaRuta.FlatAppearance.BorderSize = 2;
            this.buttonBuscaRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscaRuta.ForeColor = System.Drawing.Color.Green;
            this.buttonBuscaRuta.Location = new System.Drawing.Point(155, 13);
            this.buttonBuscaRuta.Name = "buttonBuscaRuta";
            this.buttonBuscaRuta.Size = new System.Drawing.Size(80, 24);
            this.buttonBuscaRuta.TabIndex = 12;
            this.buttonBuscaRuta.Text = "Buscar";
            this.buttonBuscaRuta.UseVisualStyleBackColor = true;
            this.buttonBuscaRuta.Click += new System.EventHandler(this.buttonBuscaRuta_Click);
            // 
            // frmConfigPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 244);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmConfigPos";
            this.Text = "frmConfigPos";
            this.Load += new System.EventHandler(this.frmConfigPos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelRutaPrint;
        private System.Windows.Forms.Button btnConfigPosSalir;
        private System.Windows.Forms.Button buttonAcepta;
        private System.Windows.Forms.Button buttonBuscaRuta;
    }
}