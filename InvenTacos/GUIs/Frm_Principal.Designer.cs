namespace InvenTacos.GUIs
{
    partial class Frm_Principal
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurarInsumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarInsumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcConfigurar = new System.Windows.Forms.ToolStripMenuItem();
            this.gridCapturaInventario = new DevExpress.XtraGrid.GridControl();
            this.capturaDeinventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvCapturaInventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClaveInsumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreInsumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadCrudo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRendimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadCocido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.btnIniciarCaptura = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCapturaInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturaDeinventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCapturaInventario)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 24);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(892, 40);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(233, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(427, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inventario para Tacos Los Corrales";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarInsumosToolStripMenuItem,
            this.importarInsumosToolStripMenuItem,
            this.OpcConfigurar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurarInsumosToolStripMenuItem
            // 
            this.configurarInsumosToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.configurarInsumosToolStripMenuItem.Name = "configurarInsumosToolStripMenuItem";
            this.configurarInsumosToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.configurarInsumosToolStripMenuItem.Text = "Configurar Insumos";
            this.configurarInsumosToolStripMenuItem.Click += new System.EventHandler(this.configurarInsumosToolStripMenuItem_Click);
            // 
            // importarInsumosToolStripMenuItem
            // 
            this.importarInsumosToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.importarInsumosToolStripMenuItem.Name = "importarInsumosToolStripMenuItem";
            this.importarInsumosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.importarInsumosToolStripMenuItem.Text = "Importar Insumos";
            this.importarInsumosToolStripMenuItem.Click += new System.EventHandler(this.importarInsumosToolStripMenuItem_Click);
            // 
            // OpcConfigurar
            // 
            this.OpcConfigurar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OpcConfigurar.Name = "OpcConfigurar";
            this.OpcConfigurar.Size = new System.Drawing.Size(142, 20);
            this.OpcConfigurar.Text = "Configurar Base de Datos";
            this.OpcConfigurar.Click += new System.EventHandler(this.OpcConfigurar_Click);
            // 
            // gridCapturaInventario
            // 
            this.gridCapturaInventario.DataSource = this.capturaDeinventarioBindingSource;
            this.gridCapturaInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCapturaInventario.Location = new System.Drawing.Point(0, 98);
            this.gridCapturaInventario.MainView = this.gvCapturaInventario;
            this.gridCapturaInventario.Name = "gridCapturaInventario";
            this.gridCapturaInventario.Size = new System.Drawing.Size(892, 460);
            this.gridCapturaInventario.TabIndex = 3;
            this.gridCapturaInventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCapturaInventario});
            // 
            // capturaDeinventarioBindingSource
            // 
            this.capturaDeinventarioBindingSource.DataSource = typeof(InvenTacos.Modelos.CapturaDeinventario);
            // 
            // gvCapturaInventario
            // 
            this.gvCapturaInventario.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvCapturaInventario.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvCapturaInventario.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCapturaInventario.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvCapturaInventario.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvCapturaInventario.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvCapturaInventario.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvCapturaInventario.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCapturaInventario.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvCapturaInventario.Appearance.Empty.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvCapturaInventario.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvCapturaInventario.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvCapturaInventario.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.EvenRow.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvCapturaInventario.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvCapturaInventario.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvCapturaInventario.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvCapturaInventario.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCapturaInventario.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvCapturaInventario.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvCapturaInventario.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvCapturaInventario.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvCapturaInventario.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvCapturaInventario.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.FocusedCell.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gvCapturaInventario.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvCapturaInventario.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.FocusedRow.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCapturaInventario.Appearance.FooterPanel.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCapturaInventario.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvCapturaInventario.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvCapturaInventario.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCapturaInventario.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvCapturaInventario.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvCapturaInventario.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.GroupPanel.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvCapturaInventario.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.GroupRow.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvCapturaInventario.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCapturaInventario.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvCapturaInventario.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvCapturaInventario.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvCapturaInventario.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.OddRow.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvCapturaInventario.Appearance.Preview.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.Preview.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.Preview.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvCapturaInventario.Appearance.Row.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.Row.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.Row.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvCapturaInventario.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvCapturaInventario.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCapturaInventario.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCapturaInventario.Appearance.SelectedRow.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCapturaInventario.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvCapturaInventario.Appearance.TopNewRow.Options.UseFont = true;
            this.gvCapturaInventario.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvCapturaInventario.Appearance.VertLine.Options.UseBackColor = true;
            this.gvCapturaInventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClaveInsumo,
            this.colNombreInsumo,
            this.colCantidadCrudo,
            this.colRendimiento,
            this.colCantidadCocido,
            this.colCantidadTotal,
            this.colUnidad});
            this.gvCapturaInventario.GridControl = this.gridCapturaInventario;
            this.gvCapturaInventario.Name = "gvCapturaInventario";
            this.gvCapturaInventario.OptionsCustomization.AllowFilter = false;
            this.gvCapturaInventario.OptionsCustomization.AllowGroup = false;
            this.gvCapturaInventario.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCapturaInventario.OptionsView.EnableAppearanceOddRow = true;
            this.gvCapturaInventario.OptionsView.ShowGroupPanel = false;
            this.gvCapturaInventario.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colClaveInsumo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colClaveInsumo
            // 
            this.colClaveInsumo.FieldName = "ClaveInsumo";
            this.colClaveInsumo.Name = "colClaveInsumo";
            this.colClaveInsumo.OptionsColumn.AllowEdit = false;
            this.colClaveInsumo.Visible = true;
            this.colClaveInsumo.VisibleIndex = 0;
            // 
            // colNombreInsumo
            // 
            this.colNombreInsumo.FieldName = "NombreInsumo";
            this.colNombreInsumo.Name = "colNombreInsumo";
            this.colNombreInsumo.OptionsColumn.AllowEdit = false;
            this.colNombreInsumo.Visible = true;
            this.colNombreInsumo.VisibleIndex = 1;
            // 
            // colCantidadCrudo
            // 
            this.colCantidadCrudo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidadCrudo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidadCrudo.FieldName = "CantidadCrudo";
            this.colCantidadCrudo.Name = "colCantidadCrudo";
            this.colCantidadCrudo.Visible = true;
            this.colCantidadCrudo.VisibleIndex = 3;
            // 
            // colRendimiento
            // 
            this.colRendimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.colRendimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colRendimiento.FieldName = "Rendimiento";
            this.colRendimiento.Name = "colRendimiento";
            this.colRendimiento.OptionsColumn.AllowEdit = false;
            this.colRendimiento.Visible = true;
            this.colRendimiento.VisibleIndex = 4;
            // 
            // colCantidadCocido
            // 
            this.colCantidadCocido.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidadCocido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidadCocido.FieldName = "CantidadCocido";
            this.colCantidadCocido.Name = "colCantidadCocido";
            this.colCantidadCocido.Visible = true;
            this.colCantidadCocido.VisibleIndex = 2;
            // 
            // colCantidadTotal
            // 
            this.colCantidadTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidadTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidadTotal.FieldName = "CantidadTotal";
            this.colCantidadTotal.Name = "colCantidadTotal";
            this.colCantidadTotal.OptionsColumn.AllowEdit = false;
            this.colCantidadTotal.Visible = true;
            this.colCantidadTotal.VisibleIndex = 5;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.OptionsColumn.AllowEdit = false;
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 6;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.label3);
            this.pnlFooter.Controls.Add(this.label2);
            this.pnlFooter.Controls.Add(this.btnConfirmar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 558);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(892, 65);
            this.pnlFooter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad Cocido + (Cantidad Crudo x Rendimiento)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad Total =";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmar.Location = new System.Drawing.Point(361, 27);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(170, 26);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar Inventario";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.btnIniciarCaptura);
            this.pnlFecha.Controls.Add(this.dtpFecha);
            this.pnlFecha.Controls.Add(this.label1);
            this.pnlFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFecha.Location = new System.Drawing.Point(0, 64);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(892, 34);
            this.pnlFecha.TabIndex = 5;
            // 
            // btnIniciarCaptura
            // 
            this.btnIniciarCaptura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciarCaptura.Location = new System.Drawing.Point(594, 4);
            this.btnIniciarCaptura.Name = "btnIniciarCaptura";
            this.btnIniciarCaptura.Size = new System.Drawing.Size(145, 26);
            this.btnIniciarCaptura.TabIndex = 2;
            this.btnIniciarCaptura.Text = "Comenzar Captura";
            this.btnIniciarCaptura.UseVisualStyleBackColor = true;
            this.btnIniciarCaptura.Click += new System.EventHandler(this.btnIniciarCaptura_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFecha.Location = new System.Drawing.Point(212, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(376, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // pbCargando
            // 
            this.pbCargando.Image = global::InvenTacos.Properties.Resources.cargando;
            this.pbCargando.Location = new System.Drawing.Point(362, 264);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(169, 94);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCargando.TabIndex = 6;
            this.pbCargando.TabStop = false;
            this.pbCargando.Visible = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 623);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.gridCapturaInventario);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inventario Tacos Los Corrales";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCapturaInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturaDeinventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCapturaInventario)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpcConfigurar;
        private System.Windows.Forms.ToolStripMenuItem configurarInsumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarInsumosToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridCapturaInventario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCapturaInventario;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveInsumo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreInsumo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadCrudo;
        private DevExpress.XtraGrid.Columns.GridColumn colRendimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadCocido;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadTotal;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarCaptura;
        private System.Windows.Forms.PictureBox pbCargando;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource capturaDeinventarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
    }
}