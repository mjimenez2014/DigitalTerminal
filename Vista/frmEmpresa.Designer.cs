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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rutempresaLabel;
            System.Windows.Forms.Label razonsocialLabel;
            System.Windows.Forms.Label giroemisorLabel;
            System.Windows.Forms.Label codigosiisucursalLabel;
            System.Windows.Forms.Label codigosiisucursalLabel1;
            System.Windows.Forms.Label telefonoemisLabel;
            System.Windows.Forms.Label correoemisLabel;
            System.Windows.Forms.Label actecoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresa));
            System.Windows.Forms.Label direccionorigenLabel;
            System.Windows.Forms.Label comunaorigenLabel;
            System.Windows.Forms.Label ciudadorigenLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.actecoTextBox = new System.Windows.Forms.TextBox();
            this.correoemisTextBox = new System.Windows.Forms.TextBox();
            this.telefonoemisTextBox = new System.Windows.Forms.TextBox();
            this.codigosiisucursalTextBox1 = new System.Windows.Forms.TextBox();
            this.codigosiisucursalTextBox = new System.Windows.Forms.TextBox();
            this.giroemisorTextBox = new System.Windows.Forms.TextBox();
            this.razonsocialTextBox = new System.Windows.Forms.TextBox();
            this.rutempresaTextBox = new System.Windows.Forms.TextBox();
            this.empresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.empresaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.direccionorigenTextBox = new System.Windows.Forms.TextBox();
            this.comunaorigenTextBox = new System.Windows.Forms.TextBox();
            this.ciudadorigenTextBox = new System.Windows.Forms.TextBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digitalterminalDataSet = new Vista.digitalterminalDataSet();
            this.empresaTableAdapter = new Vista.digitalterminalDataSetTableAdapters.empresaTableAdapter();
            this.tableAdapterManager = new Vista.digitalterminalDataSetTableAdapters.TableAdapterManager();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            rutempresaLabel = new System.Windows.Forms.Label();
            razonsocialLabel = new System.Windows.Forms.Label();
            giroemisorLabel = new System.Windows.Forms.Label();
            codigosiisucursalLabel = new System.Windows.Forms.Label();
            codigosiisucursalLabel1 = new System.Windows.Forms.Label();
            telefonoemisLabel = new System.Windows.Forms.Label();
            correoemisLabel = new System.Windows.Forms.Label();
            actecoLabel = new System.Windows.Forms.Label();
            direccionorigenLabel = new System.Windows.Forms.Label();
            comunaorigenLabel = new System.Windows.Forms.Label();
            ciudadorigenLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingNavigator)).BeginInit();
            this.empresaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalterminalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rutempresaLabel
            // 
            rutempresaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            rutempresaLabel.AutoSize = true;
            rutempresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rutempresaLabel.Location = new System.Drawing.Point(3, 6);
            rutempresaLabel.Name = "rutempresaLabel";
            rutempresaLabel.Size = new System.Drawing.Size(83, 13);
            rutempresaLabel.TabIndex = 1;
            rutempresaLabel.Text = "Rut Empresa:";
            // 
            // razonsocialLabel
            // 
            razonsocialLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            razonsocialLabel.AutoSize = true;
            razonsocialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            razonsocialLabel.Location = new System.Drawing.Point(445, 6);
            razonsocialLabel.Name = "razonsocialLabel";
            razonsocialLabel.Size = new System.Drawing.Size(86, 13);
            razonsocialLabel.TabIndex = 2;
            razonsocialLabel.Text = "Razon Social:";
            // 
            // giroemisorLabel
            // 
            giroemisorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            giroemisorLabel.AutoSize = true;
            giroemisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giroemisorLabel.Location = new System.Drawing.Point(3, 32);
            giroemisorLabel.Name = "giroemisorLabel";
            giroemisorLabel.Size = new System.Drawing.Size(75, 13);
            giroemisorLabel.TabIndex = 4;
            giroemisorLabel.Text = "Giro Emisor:";
            // 
            // codigosiisucursalLabel
            // 
            codigosiisucursalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            codigosiisucursalLabel.AutoSize = true;
            codigosiisucursalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigosiisucursalLabel.Location = new System.Drawing.Point(445, 32);
            codigosiisucursalLabel.Name = "codigosiisucursalLabel";
            codigosiisucursalLabel.Size = new System.Drawing.Size(102, 13);
            codigosiisucursalLabel.TabIndex = 6;
            codigosiisucursalLabel.Text = "codigo Sucursal:";
            // 
            // codigosiisucursalLabel1
            // 
            codigosiisucursalLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            codigosiisucursalLabel1.AutoSize = true;
            codigosiisucursalLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigosiisucursalLabel1.Location = new System.Drawing.Point(3, 58);
            codigosiisucursalLabel1.Name = "codigosiisucursalLabel1";
            codigosiisucursalLabel1.Size = new System.Drawing.Size(121, 13);
            codigosiisucursalLabel1.TabIndex = 8;
            codigosiisucursalLabel1.Text = "Codigo de Sucursal:";
            // 
            // telefonoemisLabel
            // 
            telefonoemisLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            telefonoemisLabel.AutoSize = true;
            telefonoemisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoemisLabel.Location = new System.Drawing.Point(445, 58);
            telefonoemisLabel.Name = "telefonoemisLabel";
            telefonoemisLabel.Size = new System.Drawing.Size(102, 13);
            telefonoemisLabel.TabIndex = 10;
            telefonoemisLabel.Text = "Telefono Emisor:";
            // 
            // correoemisLabel
            // 
            correoemisLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            correoemisLabel.AutoSize = true;
            correoemisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoemisLabel.Location = new System.Drawing.Point(3, 84);
            correoemisLabel.Name = "correoemisLabel";
            correoemisLabel.Size = new System.Drawing.Size(89, 13);
            correoemisLabel.TabIndex = 12;
            correoemisLabel.Text = "Correo Emisor:";
            // 
            // actecoLabel
            // 
            actecoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            actecoLabel.AutoSize = true;
            actecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            actecoLabel.Location = new System.Drawing.Point(445, 84);
            actecoLabel.Name = "actecoLabel";
            actecoLabel.Size = new System.Drawing.Size(51, 13);
            actecoLabel.TabIndex = 14;
            actecoLabel.Text = "Acteco:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblNomCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 205);
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
            this.lblNomCliente.Size = new System.Drawing.Size(1045, 18);
            this.lblNomCliente.TabIndex = 1;
            this.lblNomCliente.Text = "EMPRESA";
            this.lblNomCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(ciudadorigenLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(comunaorigenLabel, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.comunaorigenTextBox, 3, 4);
            this.tableLayoutPanel2.Controls.Add(direccionorigenLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.direccionorigenTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(actecoLabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.actecoTextBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(correoemisLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.correoemisTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(telefonoemisLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.telefonoemisTextBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(codigosiisucursalLabel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.codigosiisucursalTextBox1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(codigosiisucursalLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.codigosiisucursalTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(giroemisorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.giroemisorTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(razonsocialLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.razonsocialTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(rutempresaLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rutempresaTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ciudadorigenTextBox, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1047, 172);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // actecoTextBox
            // 
            this.actecoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.actecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "acteco", true));
            this.actecoTextBox.Location = new System.Drawing.Point(566, 81);
            this.actecoTextBox.Name = "actecoTextBox";
            this.actecoTextBox.Size = new System.Drawing.Size(150, 20);
            this.actecoTextBox.TabIndex = 15;
            this.actecoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // correoemisTextBox
            // 
            this.correoemisTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.correoemisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "correoemis", true));
            this.correoemisTextBox.Location = new System.Drawing.Point(133, 81);
            this.correoemisTextBox.Name = "correoemisTextBox";
            this.correoemisTextBox.Size = new System.Drawing.Size(306, 20);
            this.correoemisTextBox.TabIndex = 13;
            // 
            // telefonoemisTextBox
            // 
            this.telefonoemisTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.telefonoemisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "telefonoemis", true));
            this.telefonoemisTextBox.Location = new System.Drawing.Point(566, 55);
            this.telefonoemisTextBox.Name = "telefonoemisTextBox";
            this.telefonoemisTextBox.Size = new System.Drawing.Size(230, 20);
            this.telefonoemisTextBox.TabIndex = 11;
            // 
            // codigosiisucursalTextBox1
            // 
            this.codigosiisucursalTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.codigosiisucursalTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "codigosiisucursal", true));
            this.codigosiisucursalTextBox1.Location = new System.Drawing.Point(133, 55);
            this.codigosiisucursalTextBox1.Name = "codigosiisucursalTextBox1";
            this.codigosiisucursalTextBox1.Size = new System.Drawing.Size(100, 20);
            this.codigosiisucursalTextBox1.TabIndex = 9;
            this.codigosiisucursalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // codigosiisucursalTextBox
            // 
            this.codigosiisucursalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.codigosiisucursalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "codigosiisucursal", true));
            this.codigosiisucursalTextBox.Location = new System.Drawing.Point(566, 29);
            this.codigosiisucursalTextBox.Name = "codigosiisucursalTextBox";
            this.codigosiisucursalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigosiisucursalTextBox.TabIndex = 7;
            // 
            // giroemisorTextBox
            // 
            this.giroemisorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.giroemisorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "giroemisor", true));
            this.giroemisorTextBox.Location = new System.Drawing.Point(133, 29);
            this.giroemisorTextBox.Name = "giroemisorTextBox";
            this.giroemisorTextBox.Size = new System.Drawing.Size(306, 20);
            this.giroemisorTextBox.TabIndex = 5;
            // 
            // razonsocialTextBox
            // 
            this.razonsocialTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.razonsocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "razonsocial", true));
            this.razonsocialTextBox.Location = new System.Drawing.Point(566, 3);
            this.razonsocialTextBox.Name = "razonsocialTextBox";
            this.razonsocialTextBox.Size = new System.Drawing.Size(478, 20);
            this.razonsocialTextBox.TabIndex = 3;
            // 
            // rutempresaTextBox
            // 
            this.rutempresaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rutempresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "rutempresa", true));
            this.rutempresaTextBox.Location = new System.Drawing.Point(133, 3);
            this.rutempresaTextBox.Name = "rutempresaTextBox";
            this.rutempresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.rutempresaTextBox.TabIndex = 2;
            this.rutempresaTextBox.Text = "00000000-0";
            this.rutempresaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // empresaBindingNavigator
            // 
            this.empresaBindingNavigator.AddNewItem = this.bindingNavigatorDeleteItem;
            this.empresaBindingNavigator.BindingSource = this.empresaBindingSource;
            this.empresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empresaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.empresaBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.empresaBindingNavigator.Location = new System.Drawing.Point(0, 205);
            this.empresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empresaBindingNavigator.Name = "empresaBindingNavigator";
            this.empresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empresaBindingNavigator.Size = new System.Drawing.Size(1055, 25);
            this.empresaBindingNavigator.TabIndex = 1;
            this.empresaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // empresaBindingNavigatorSaveItem
            // 
            this.empresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empresaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empresaBindingNavigatorSaveItem.Image")));
            this.empresaBindingNavigatorSaveItem.Name = "empresaBindingNavigatorSaveItem";
            this.empresaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empresaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.empresaBindingNavigatorSaveItem.Click += new System.EventHandler(this.empresaBindingNavigatorSaveItem_Click);
            // 
            // direccionorigenLabel
            // 
            direccionorigenLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            direccionorigenLabel.AutoSize = true;
            direccionorigenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionorigenLabel.Location = new System.Drawing.Point(3, 110);
            direccionorigenLabel.Name = "direccionorigenLabel";
            direccionorigenLabel.Size = new System.Drawing.Size(124, 13);
            direccionorigenLabel.TabIndex = 16;
            direccionorigenLabel.Text = "Dirección de Origen:";
            // 
            // direccionorigenTextBox
            // 
            this.direccionorigenTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.direccionorigenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "direccionorigen", true));
            this.direccionorigenTextBox.Location = new System.Drawing.Point(133, 107);
            this.direccionorigenTextBox.Name = "direccionorigenTextBox";
            this.direccionorigenTextBox.Size = new System.Drawing.Size(306, 20);
            this.direccionorigenTextBox.TabIndex = 17;
            // 
            // comunaorigenLabel
            // 
            comunaorigenLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            comunaorigenLabel.AutoSize = true;
            comunaorigenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comunaorigenLabel.Location = new System.Drawing.Point(445, 110);
            comunaorigenLabel.Name = "comunaorigenLabel";
            comunaorigenLabel.Size = new System.Drawing.Size(115, 13);
            comunaorigenLabel.TabIndex = 18;
            comunaorigenLabel.Text = "Comuna de Origen:";
            // 
            // comunaorigenTextBox
            // 
            this.comunaorigenTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comunaorigenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "comunaorigen", true));
            this.comunaorigenTextBox.Location = new System.Drawing.Point(566, 107);
            this.comunaorigenTextBox.Name = "comunaorigenTextBox";
            this.comunaorigenTextBox.Size = new System.Drawing.Size(230, 20);
            this.comunaorigenTextBox.TabIndex = 19;
            // 
            // ciudadorigenLabel
            // 
            ciudadorigenLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            ciudadorigenLabel.AutoSize = true;
            ciudadorigenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadorigenLabel.Location = new System.Drawing.Point(3, 144);
            ciudadorigenLabel.Name = "ciudadorigenLabel";
            ciudadorigenLabel.Size = new System.Drawing.Size(91, 13);
            ciudadorigenLabel.TabIndex = 20;
            ciudadorigenLabel.Text = "Ciudad Origen:";
            // 
            // ciudadorigenTextBox
            // 
            this.ciudadorigenTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ciudadorigenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "ciudadorigen", true));
            this.ciudadorigenTextBox.Location = new System.Drawing.Point(133, 141);
            this.ciudadorigenTextBox.Name = "ciudadorigenTextBox";
            this.ciudadorigenTextBox.Size = new System.Drawing.Size(212, 20);
            this.ciudadorigenTextBox.TabIndex = 21;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "empresa";
            this.empresaBindingSource.DataSource = this.digitalterminalDataSet;
            // 
            // digitalterminalDataSet
            // 
            this.digitalterminalDataSet.DataSetName = "digitalterminalDataSet";
            this.digitalterminalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cafTableAdapter = null;
            this.tableAdapterManager.ciudadesTableAdapter = null;
            this.tableAdapterManager.clienteproductoTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.codbarraTableAdapter = null;
            this.tableAdapterManager.comunasTableAdapter = null;
            this.tableAdapterManager.detalleTableAdapter = null;
            this.tableAdapterManager.documentoTableAdapter = null;
            this.tableAdapterManager.empresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.folioTableAdapter = null;
            this.tableAdapterManager.impuestoproductoTableAdapter = null;
            this.tableAdapterManager.impuestoTableAdapter = null;
            this.tableAdapterManager.paisesTableAdapter = null;
            this.tableAdapterManager.productoTableAdapter = null;
            this.tableAdapterManager.referenciaTableAdapter = null;
            this.tableAdapterManager.tipodteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vista.digitalterminalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Vista.Properties.Resources.exit_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Salir del formulario";
            this.toolStripButton1.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 228);
            this.Controls.Add(this.empresaBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingNavigator)).EndInit();
            this.empresaBindingNavigator.ResumeLayout(false);
            this.empresaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalterminalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblNomCliente;
        private digitalterminalDataSet digitalterminalDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private digitalterminalDataSetTableAdapters.empresaTableAdapter empresaTableAdapter;
        private digitalterminalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empresaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton empresaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rutempresaTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox codigosiisucursalTextBox;
        private System.Windows.Forms.TextBox giroemisorTextBox;
        private System.Windows.Forms.TextBox razonsocialTextBox;
        private System.Windows.Forms.TextBox actecoTextBox;
        private System.Windows.Forms.TextBox correoemisTextBox;
        private System.Windows.Forms.TextBox telefonoemisTextBox;
        private System.Windows.Forms.TextBox codigosiisucursalTextBox1;
        private System.Windows.Forms.TextBox ciudadorigenTextBox;
        private System.Windows.Forms.TextBox comunaorigenTextBox;
        private System.Windows.Forms.TextBox direccionorigenTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}