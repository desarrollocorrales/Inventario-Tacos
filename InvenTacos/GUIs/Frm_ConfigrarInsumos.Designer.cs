namespace InvenTacos.GUIs
{
    partial class Frm_ConfigrarInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConfigrarInsumos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_insumosTodos = new DevExpress.XtraGrid.GridControl();
            this.InsumosTodos = new System.Windows.Forms.BindingSource(this.components);
            this.gvInsumosTodos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_insumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_insumosSeleccionados = new DevExpress.XtraGrid.GridControl();
            this.InsumosConfigurados = new System.Windows.Forms.BindingSource(this.components);
            this.gvInsumosSeleccionados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_insumo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_insumosTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsumosTodos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_insumosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosConfigurados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsumosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(827, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configurar insumos del reporte de inventario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "En esta ventana podra seleccionar los insumos que se utilizarán para realizar el " +
    "inventario";
            // 
            // grid_insumosTodos
            // 
            this.grid_insumosTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_insumosTodos.DataSource = this.InsumosTodos;
            this.grid_insumosTodos.Location = new System.Drawing.Point(3, 29);
            this.grid_insumosTodos.MainView = this.gvInsumosTodos;
            this.grid_insumosTodos.Name = "grid_insumosTodos";
            this.grid_insumosTodos.Size = new System.Drawing.Size(366, 383);
            this.grid_insumosTodos.TabIndex = 2;
            this.grid_insumosTodos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInsumosTodos});
            // 
            // InsumosTodos
            // 
            this.InsumosTodos.DataSource = typeof(InvenTacos.Entity.MySQL.insumos);
            // 
            // gvInsumosTodos
            // 
            this.gvInsumosTodos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvInsumosTodos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvInsumosTodos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvInsumosTodos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvInsumosTodos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvInsumosTodos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvInsumosTodos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvInsumosTodos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvInsumosTodos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvInsumosTodos.Appearance.Empty.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvInsumosTodos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvInsumosTodos.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvInsumosTodos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.EvenRow.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosTodos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvInsumosTodos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosTodos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvInsumosTodos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvInsumosTodos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvInsumosTodos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosTodos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvInsumosTodos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvInsumosTodos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvInsumosTodos.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.FocusedCell.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gvInsumosTodos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvInsumosTodos.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.FocusedRow.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvInsumosTodos.Appearance.FooterPanel.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvInsumosTodos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvInsumosTodos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvInsumosTodos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvInsumosTodos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvInsumosTodos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvInsumosTodos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.GroupPanel.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvInsumosTodos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.GroupRow.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvInsumosTodos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvInsumosTodos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvInsumosTodos.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosTodos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvInsumosTodos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.OddRow.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvInsumosTodos.Appearance.Preview.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.Preview.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.Preview.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosTodos.Appearance.Row.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.Row.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.Row.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvInsumosTodos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvInsumosTodos.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvInsumosTodos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInsumosTodos.Appearance.SelectedRow.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvInsumosTodos.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosTodos.Appearance.TopNewRow.Options.UseFont = true;
            this.gvInsumosTodos.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvInsumosTodos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvInsumosTodos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_insumo,
            this.coldescripcion});
            this.gvInsumosTodos.GridControl = this.grid_insumosTodos;
            this.gvInsumosTodos.Name = "gvInsumosTodos";
            this.gvInsumosTodos.OptionsBehavior.Editable = false;
            this.gvInsumosTodos.OptionsCustomization.AllowGroup = false;
            this.gvInsumosTodos.OptionsCustomization.AllowSort = false;
            this.gvInsumosTodos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInsumosTodos.OptionsView.EnableAppearanceOddRow = true;
            this.gvInsumosTodos.OptionsView.ShowGroupPanel = false;
            this.gvInsumosTodos.DoubleClick += new System.EventHandler(this.gvInsumosTodos_DoubleClick);
            // 
            // colid_insumo
            // 
            this.colid_insumo.Caption = "ID";
            this.colid_insumo.FieldName = "id_insumo";
            this.colid_insumo.Name = "colid_insumo";
            this.colid_insumo.Visible = true;
            this.colid_insumo.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Insumo";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grid_insumosTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 415);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(79, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Todos los Insumos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.grid_insumosSeleccionados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 415);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Location = new System.Drawing.Point(73, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Insumos Seleccionados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid_insumosSeleccionados
            // 
            this.grid_insumosSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_insumosSeleccionados.DataSource = this.InsumosConfigurados;
            this.grid_insumosSeleccionados.Location = new System.Drawing.Point(3, 29);
            this.grid_insumosSeleccionados.MainView = this.gvInsumosSeleccionados;
            this.grid_insumosSeleccionados.Name = "grid_insumosSeleccionados";
            this.grid_insumosSeleccionados.Size = new System.Drawing.Size(355, 383);
            this.grid_insumosSeleccionados.TabIndex = 2;
            this.grid_insumosSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInsumosSeleccionados});
            // 
            // InsumosConfigurados
            // 
            this.InsumosConfigurados.DataSource = typeof(InvenTacos.Entity.MySQL.insumos);
            // 
            // gvInsumosSeleccionados
            // 
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvInsumosSeleccionados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvInsumosSeleccionados.Appearance.Empty.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvInsumosSeleccionados.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvInsumosSeleccionados.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.EvenRow.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvInsumosSeleccionados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvInsumosSeleccionados.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvInsumosSeleccionados.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvInsumosSeleccionados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvInsumosSeleccionados.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvInsumosSeleccionados.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvInsumosSeleccionados.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.FocusedCell.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.gvInsumosSeleccionados.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(86)))), ((int)(((byte)(156)))));
            this.gvInsumosSeleccionados.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.FocusedRow.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvInsumosSeleccionados.Appearance.FooterPanel.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.gvInsumosSeleccionados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.gvInsumosSeleccionados.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvInsumosSeleccionados.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvInsumosSeleccionados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupPanel.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvInsumosSeleccionados.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.GroupRow.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvInsumosSeleccionados.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvInsumosSeleccionados.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvInsumosSeleccionados.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvInsumosSeleccionados.Appearance.OddRow.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.OddRow.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.OddRow.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.gvInsumosSeleccionados.Appearance.Preview.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.Preview.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.Preview.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvInsumosSeleccionados.Appearance.Row.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.Row.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.Row.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvInsumosSeleccionados.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(116)))));
            this.gvInsumosSeleccionados.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvInsumosSeleccionados.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Appearance.SelectedRow.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvInsumosSeleccionados.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvInsumosSeleccionados.Appearance.TopNewRow.Options.UseFont = true;
            this.gvInsumosSeleccionados.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvInsumosSeleccionados.Appearance.VertLine.Options.UseBackColor = true;
            this.gvInsumosSeleccionados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_insumo1,
            this.coldescripcion1});
            this.gvInsumosSeleccionados.GridControl = this.grid_insumosSeleccionados;
            this.gvInsumosSeleccionados.Name = "gvInsumosSeleccionados";
            this.gvInsumosSeleccionados.OptionsBehavior.Editable = false;
            this.gvInsumosSeleccionados.OptionsCustomization.AllowFilter = false;
            this.gvInsumosSeleccionados.OptionsCustomization.AllowGroup = false;
            this.gvInsumosSeleccionados.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInsumosSeleccionados.OptionsView.EnableAppearanceOddRow = true;
            this.gvInsumosSeleccionados.OptionsView.ShowGroupPanel = false;
            this.gvInsumosSeleccionados.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_insumo1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvInsumosSeleccionados.DoubleClick += new System.EventHandler(this.gvInsumosSeleccionados_DoubleClick);
            // 
            // colid_insumo1
            // 
            this.colid_insumo1.Caption = "ID";
            this.colid_insumo1.FieldName = "id_insumo";
            this.colid_insumo1.Name = "colid_insumo1";
            this.colid_insumo1.Visible = true;
            this.colid_insumo1.VisibleIndex = 0;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.Caption = "Insumo";
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(373, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(5, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(810, 415);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnQuitar);
            this.splitContainer2.Panel1.Controls.Add(this.btnAgregar);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(434, 415);
            this.splitContainer2.SplitterDistance = 69;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(9, 114);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(50, 40);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(9, 68);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Frm_ConfigrarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 523);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ConfigrarInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configrar Insumos";
            this.Load += new System.EventHandler(this.Frm_ConfigrarInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_insumosTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsumosTodos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_insumosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosConfigurados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsumosSeleccionados)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grid_insumosTodos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInsumosTodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl grid_insumosSeleccionados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInsumosSeleccionados;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource InsumosTodos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_insumo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.BindingSource InsumosConfigurados;
        private DevExpress.XtraGrid.Columns.GridColumn colid_insumo1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
    }
}