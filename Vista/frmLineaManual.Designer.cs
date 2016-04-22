namespace Vista
{
    partial class frmLineaManual
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxDscItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxConImpuestos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDctoPrc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrecioBruto = new System.Windows.Forms.Label();
            this.labelPrecioNeto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.buttonAgrega = new System.Windows.Forms.Button();
            this.labelTotalLinea = new System.Windows.Forms.Label();
            this.labelLineaNeto = new System.Windows.Forms.Label();
            this.labelDctMonto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.lblProductos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 353);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(5, 3);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(770, 18);
            this.lblProductos.TabIndex = 19;
            this.lblProductos.Text = "INGRESO DE PRODUCTO MANUAL";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtPrecioUnitario, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCantidad, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDscItem, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxConImpuestos, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDctoPrc, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 224);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(116, 3);
            this.txtNombre.MaxLength = 79;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(431, 21);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio Unitario:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(116, 30);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(114, 21);
            this.txtPrecioUnitario.TabIndex = 1;
            this.txtPrecioUnitario.Text = "0";
            this.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioUnitario.TextChanged += new System.EventHandler(this.txtPrecioUnitario_TextChanged);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(116, 57);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(88, 24);
            this.textBoxCantidad.TabIndex = 2;
            this.textBoxCantidad.Text = "0";
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // textBoxDscItem
            // 
            this.textBoxDscItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDscItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDscItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDscItem.Location = new System.Drawing.Point(116, 89);
            this.textBoxDscItem.MaxLength = 999;
            this.textBoxDscItem.Multiline = true;
            this.textBoxDscItem.Name = "textBoxDscItem";
            this.textBoxDscItem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDscItem.Size = new System.Drawing.Size(431, 130);
            this.textBoxDscItem.TabIndex = 3;
            this.textBoxDscItem.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Descripción:";
            // 
            // checkBoxConImpuestos
            // 
            this.checkBoxConImpuestos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxConImpuestos.AutoSize = true;
            this.checkBoxConImpuestos.Checked = true;
            this.checkBoxConImpuestos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConImpuestos.Location = new System.Drawing.Point(553, 32);
            this.checkBoxConImpuestos.Name = "checkBoxConImpuestos";
            this.checkBoxConImpuestos.Size = new System.Drawing.Size(148, 17);
            this.checkBoxConImpuestos.TabIndex = 6;
            this.checkBoxConImpuestos.Text = "Precio con Impuestos";
            this.checkBoxConImpuestos.UseVisualStyleBackColor = true;
            this.checkBoxConImpuestos.CheckedChanged += new System.EventHandler(this.checkBoxConImpuestos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descuento % :";
            // 
            // textBoxDctoPrc
            // 
            this.textBoxDctoPrc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDctoPrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDctoPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDctoPrc.Location = new System.Drawing.Point(707, 3);
            this.textBoxDctoPrc.Name = "textBoxDctoPrc";
            this.textBoxDctoPrc.Size = new System.Drawing.Size(53, 21);
            this.textBoxDctoPrc.TabIndex = 4;
            this.textBoxDctoPrc.Text = "0";
            this.textBoxDctoPrc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Imp. Adic.%:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(707, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPrecioNeto, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSalir, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonAgrega, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDctMonto, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelLineaNeto, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalLinea, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPrecioBruto, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 258);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(772, 80);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // labelPrecioBruto
            // 
            this.labelPrecioBruto.AutoSize = true;
            this.labelPrecioBruto.Location = new System.Drawing.Point(479, 0);
            this.labelPrecioBruto.Name = "labelPrecioBruto";
            this.labelPrecioBruto.Size = new System.Drawing.Size(62, 13);
            this.labelPrecioBruto.TabIndex = 16;
            this.labelPrecioBruto.Text = "PrecioBruto";
            this.labelPrecioBruto.Visible = false;
            // 
            // labelPrecioNeto
            // 
            this.labelPrecioNeto.AutoSize = true;
            this.labelPrecioNeto.Location = new System.Drawing.Point(273, 0);
            this.labelPrecioNeto.Name = "labelPrecioNeto";
            this.labelPrecioNeto.Size = new System.Drawing.Size(60, 13);
            this.labelPrecioNeto.TabIndex = 15;
            this.labelPrecioNeto.Text = "PrecioNeto";
            this.labelPrecioNeto.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Green;
            this.btnSalir.Image = global::Vista.Properties.Resources.exit_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(3, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 63);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // buttonAgrega
            // 
            this.buttonAgrega.FlatAppearance.BorderSize = 2;
            this.buttonAgrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgrega.ForeColor = System.Drawing.Color.Green;
            this.buttonAgrega.Image = global::Vista.Properties.Resources.check_mark_11_32;
            this.buttonAgrega.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgrega.Location = new System.Drawing.Point(89, 3);
            this.buttonAgrega.Name = "buttonAgrega";
            this.buttonAgrega.Size = new System.Drawing.Size(80, 63);
            this.buttonAgrega.TabIndex = 0;
            this.buttonAgrega.Text = "AGREGAR";
            this.buttonAgrega.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgrega.UseVisualStyleBackColor = true;
            this.buttonAgrega.Click += new System.EventHandler(this.buttonAgrega_Click);
            // 
            // labelTotalLinea
            // 
            this.labelTotalLinea.AutoSize = true;
            this.labelTotalLinea.Location = new System.Drawing.Point(595, 0);
            this.labelTotalLinea.Name = "labelTotalLinea";
            this.labelTotalLinea.Size = new System.Drawing.Size(53, 13);
            this.labelTotalLinea.TabIndex = 7;
            this.labelTotalLinea.Text = "totalLinea";
            this.labelTotalLinea.Visible = false;
            // 
            // labelLineaNeto
            // 
            this.labelLineaNeto.AutoSize = true;
            this.labelLineaNeto.Location = new System.Drawing.Point(656, 0);
            this.labelLineaNeto.Name = "labelLineaNeto";
            this.labelLineaNeto.Size = new System.Drawing.Size(14, 156);
            this.labelLineaNeto.TabIndex = 4;
            this.labelLineaNeto.Text = "totalLineaNeto";
            this.labelLineaNeto.Visible = false;
            // 
            // labelDctMonto
            // 
            this.labelDctMonto.AutoSize = true;
            this.labelDctMonto.Location = new System.Drawing.Point(676, 0);
            this.labelDctMonto.Name = "labelDctMonto";
            this.labelDctMonto.Size = new System.Drawing.Size(83, 26);
            this.labelDctMonto.TabIndex = 9;
            this.labelDctMonto.Text = "DescuentoMonto";
            this.labelDctMonto.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio Neto:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(369, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Precio con Imp:";
            this.label8.Visible = false;
            // 
            // frmLineaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmLineaManual";
            this.Text = "frmLineaManual";
            this.Load += new System.EventHandler(this.frmLineaManual_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelPrecioBruto;
        private System.Windows.Forms.Label labelPrecioNeto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button buttonAgrega;
        private System.Windows.Forms.Label labelTotalLinea;
        private System.Windows.Forms.Label labelLineaNeto;
        private System.Windows.Forms.Label labelDctMonto;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox textBoxDctoPrc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.CheckBox checkBoxConImpuestos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBoxDscItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}