namespace InvenTacos.GUIs
{
    partial class Frm_ConfPrestamos
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
            this.gridConceptos = new DevExpress.XtraGrid.GridControl();
            this.gvConceptos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.conceptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSeleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConceptoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConceptos
            // 
            this.gridConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConceptos.DataSource = this.conceptoBindingSource;
            this.gridConceptos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridConceptos.Location = new System.Drawing.Point(13, 112);
            this.gridConceptos.MainView = this.gvConceptos;
            this.gridConceptos.Margin = new System.Windows.Forms.Padding(4);
            this.gridConceptos.Name = "gridConceptos";
            this.gridConceptos.Size = new System.Drawing.Size(616, 312);
            this.gridConceptos.TabIndex = 0;
            this.gridConceptos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConceptos});
            this.gridConceptos.Visible = false;
            // 
            // gvConceptos
            // 
            this.gvConceptos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeleccion,
            this.colConceptoID,
            this.colDescripcion});
            this.gvConceptos.GridControl = this.gridConceptos;
            this.gvConceptos.Name = "gvConceptos";
            this.gvConceptos.OptionsView.ShowGroupPanel = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(171, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 23);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Configurar Conceptos de Prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione los conceptos para prestamos:";
            this.label1.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(271, 431);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargar.Location = new System.Drawing.Point(246, 46);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 30);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar Conceptos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // conceptoBindingSource
            // 
            this.conceptoBindingSource.DataSource = typeof(InvenTacos.Modelos.Concepto);
            // 
            // colSeleccion
            // 
            this.colSeleccion.FieldName = "Seleccion";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.Visible = true;
            this.colSeleccion.VisibleIndex = 0;
            // 
            // colConceptoID
            // 
            this.colConceptoID.FieldName = "ConceptoID";
            this.colConceptoID.Name = "colConceptoID";
            this.colConceptoID.OptionsColumn.AllowEdit = false;
            this.colConceptoID.Visible = true;
            this.colConceptoID.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // Frm_ConfPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 473);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gridConceptos);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ConfPrestamos";
            this.Text = "Configurar conceptos de prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.gridConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConceptos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConceptos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.BindingSource conceptoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colConceptoID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
    }
}