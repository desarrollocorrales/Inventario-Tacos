namespace InvenTacos.GUIs
{
    partial class Frm_ConfigDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConfigDB));
            this.gbSoftRestaurant = new System.Windows.Forms.GroupBox();
            this.pnlDBMSSQL = new System.Windows.Forms.Panel();
            this.brnGuardarMSSQL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDBMSSQL = new System.Windows.Forms.ComboBox();
            this.btnProbarMSSQL = new System.Windows.Forms.Button();
            this.txbPassMSSQL = new System.Windows.Forms.TextBox();
            this.txbUserMSSQL = new System.Windows.Forms.TextBox();
            this.txbServerMSSQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMysql = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudPuertoMySQL = new System.Windows.Forms.NumericUpDown();
            this.pnlDBMysql = new System.Windows.Forms.Panel();
            this.btnGuardarMySQL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDBMySQL = new System.Windows.Forms.ComboBox();
            this.btnProbarMySQL = new System.Windows.Forms.Button();
            this.txbPassMySQL = new System.Windows.Forms.TextBox();
            this.txbUserMySQL = new System.Windows.Forms.TextBox();
            this.txbServerMySQL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.gbSoftRestaurant.SuspendLayout();
            this.pnlDBMSSQL.SuspendLayout();
            this.gbMysql.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuertoMySQL)).BeginInit();
            this.pnlDBMysql.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSoftRestaurant
            // 
            this.gbSoftRestaurant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSoftRestaurant.Controls.Add(this.pnlDBMSSQL);
            this.gbSoftRestaurant.Controls.Add(this.btnProbarMSSQL);
            this.gbSoftRestaurant.Controls.Add(this.txbPassMSSQL);
            this.gbSoftRestaurant.Controls.Add(this.txbUserMSSQL);
            this.gbSoftRestaurant.Controls.Add(this.txbServerMSSQL);
            this.gbSoftRestaurant.Controls.Add(this.label3);
            this.gbSoftRestaurant.Controls.Add(this.label2);
            this.gbSoftRestaurant.Controls.Add(this.label1);
            this.gbSoftRestaurant.Location = new System.Drawing.Point(12, 12);
            this.gbSoftRestaurant.Name = "gbSoftRestaurant";
            this.gbSoftRestaurant.Size = new System.Drawing.Size(608, 265);
            this.gbSoftRestaurant.TabIndex = 0;
            this.gbSoftRestaurant.TabStop = false;
            this.gbSoftRestaurant.Text = "Base de datos SoftRestaurant";
            // 
            // pnlDBMSSQL
            // 
            this.pnlDBMSSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDBMSSQL.Controls.Add(this.brnGuardarMSSQL);
            this.pnlDBMSSQL.Controls.Add(this.label4);
            this.pnlDBMSSQL.Controls.Add(this.cbDBMSSQL);
            this.pnlDBMSSQL.Location = new System.Drawing.Point(6, 133);
            this.pnlDBMSSQL.Name = "pnlDBMSSQL";
            this.pnlDBMSSQL.Size = new System.Drawing.Size(596, 95);
            this.pnlDBMSSQL.TabIndex = 7;
            this.pnlDBMSSQL.Visible = false;
            // 
            // brnGuardarMSSQL
            // 
            this.brnGuardarMSSQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brnGuardarMSSQL.Location = new System.Drawing.Point(256, 45);
            this.brnGuardarMSSQL.Name = "brnGuardarMSSQL";
            this.brnGuardarMSSQL.Size = new System.Drawing.Size(85, 26);
            this.brnGuardarMSSQL.TabIndex = 7;
            this.brnGuardarMSSQL.Text = "Guardar";
            this.brnGuardarMSSQL.UseVisualStyleBackColor = true;
            this.brnGuardarMSSQL.Click += new System.EventHandler(this.brnGuardarMSSQL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Base de Datos:";
            // 
            // cbDBMSSQL
            // 
            this.cbDBMSSQL.FormattingEnabled = true;
            this.cbDBMSSQL.Location = new System.Drawing.Point(164, 3);
            this.cbDBMSSQL.Name = "cbDBMSSQL";
            this.cbDBMSSQL.Size = new System.Drawing.Size(360, 26);
            this.cbDBMSSQL.TabIndex = 0;
            // 
            // btnProbarMSSQL
            // 
            this.btnProbarMSSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProbarMSSQL.Location = new System.Drawing.Point(372, 101);
            this.btnProbarMSSQL.Name = "btnProbarMSSQL";
            this.btnProbarMSSQL.Size = new System.Drawing.Size(158, 26);
            this.btnProbarMSSQL.TabIndex = 6;
            this.btnProbarMSSQL.Text = "Probar Conexion";
            this.btnProbarMSSQL.UseVisualStyleBackColor = true;
            this.btnProbarMSSQL.Click += new System.EventHandler(this.btnProbarMSSQL_Click);
            // 
            // txbPassMSSQL
            // 
            this.txbPassMSSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassMSSQL.Location = new System.Drawing.Point(170, 101);
            this.txbPassMSSQL.Name = "txbPassMSSQL";
            this.txbPassMSSQL.PasswordChar = '*';
            this.txbPassMSSQL.Size = new System.Drawing.Size(196, 26);
            this.txbPassMSSQL.TabIndex = 5;
            // 
            // txbUserMSSQL
            // 
            this.txbUserMSSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUserMSSQL.Location = new System.Drawing.Point(170, 69);
            this.txbUserMSSQL.Name = "txbUserMSSQL";
            this.txbUserMSSQL.Size = new System.Drawing.Size(196, 26);
            this.txbUserMSSQL.TabIndex = 4;
            // 
            // txbServerMSSQL
            // 
            this.txbServerMSSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbServerMSSQL.Location = new System.Drawing.Point(170, 37);
            this.txbServerMSSQL.Name = "txbServerMSSQL";
            this.txbServerMSSQL.Size = new System.Drawing.Size(360, 26);
            this.txbServerMSSQL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // gbMysql
            // 
            this.gbMysql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMysql.Controls.Add(this.label10);
            this.gbMysql.Controls.Add(this.nudPuertoMySQL);
            this.gbMysql.Controls.Add(this.pnlDBMysql);
            this.gbMysql.Controls.Add(this.btnProbarMySQL);
            this.gbMysql.Controls.Add(this.txbPassMySQL);
            this.gbMysql.Controls.Add(this.txbUserMySQL);
            this.gbMysql.Controls.Add(this.txbServerMySQL);
            this.gbMysql.Controls.Add(this.label6);
            this.gbMysql.Controls.Add(this.label7);
            this.gbMysql.Controls.Add(this.label8);
            this.gbMysql.Location = new System.Drawing.Point(12, 288);
            this.gbMysql.Name = "gbMysql";
            this.gbMysql.Size = new System.Drawing.Size(608, 265);
            this.gbMysql.TabIndex = 1;
            this.gbMysql.TabStop = false;
            this.gbMysql.Text = "Base de datos MySQL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Puerto:";
            // 
            // nudPuertoMySQL
            // 
            this.nudPuertoMySQL.Location = new System.Drawing.Point(171, 123);
            this.nudPuertoMySQL.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.nudPuertoMySQL.Name = "nudPuertoMySQL";
            this.nudPuertoMySQL.Size = new System.Drawing.Size(131, 26);
            this.nudPuertoMySQL.TabIndex = 16;
            // 
            // pnlDBMysql
            // 
            this.pnlDBMysql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDBMysql.Controls.Add(this.btnGuardarMySQL);
            this.pnlDBMysql.Controls.Add(this.label5);
            this.pnlDBMysql.Controls.Add(this.cbDBMySQL);
            this.pnlDBMysql.Location = new System.Drawing.Point(6, 155);
            this.pnlDBMysql.Name = "pnlDBMysql";
            this.pnlDBMysql.Size = new System.Drawing.Size(596, 95);
            this.pnlDBMysql.TabIndex = 15;
            this.pnlDBMysql.Visible = false;
            // 
            // btnGuardarMySQL
            // 
            this.btnGuardarMySQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarMySQL.Location = new System.Drawing.Point(256, 45);
            this.btnGuardarMySQL.Name = "btnGuardarMySQL";
            this.btnGuardarMySQL.Size = new System.Drawing.Size(85, 26);
            this.btnGuardarMySQL.TabIndex = 7;
            this.btnGuardarMySQL.Text = "Guardar";
            this.btnGuardarMySQL.UseVisualStyleBackColor = true;
            this.btnGuardarMySQL.Click += new System.EventHandler(this.btnGuardarMySQL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Base de Datos:";
            // 
            // cbDBMySQL
            // 
            this.cbDBMySQL.FormattingEnabled = true;
            this.cbDBMySQL.Location = new System.Drawing.Point(165, 3);
            this.cbDBMySQL.Name = "cbDBMySQL";
            this.cbDBMySQL.Size = new System.Drawing.Size(360, 26);
            this.cbDBMySQL.TabIndex = 0;
            // 
            // btnProbarMySQL
            // 
            this.btnProbarMySQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProbarMySQL.Location = new System.Drawing.Point(372, 91);
            this.btnProbarMySQL.Name = "btnProbarMySQL";
            this.btnProbarMySQL.Size = new System.Drawing.Size(158, 26);
            this.btnProbarMySQL.TabIndex = 14;
            this.btnProbarMySQL.Text = "Probar Conexion";
            this.btnProbarMySQL.UseVisualStyleBackColor = true;
            this.btnProbarMySQL.Click += new System.EventHandler(this.btnProbarMySQL_Click);
            // 
            // txbPassMySQL
            // 
            this.txbPassMySQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassMySQL.Location = new System.Drawing.Point(170, 91);
            this.txbPassMySQL.Name = "txbPassMySQL";
            this.txbPassMySQL.PasswordChar = '*';
            this.txbPassMySQL.Size = new System.Drawing.Size(196, 26);
            this.txbPassMySQL.TabIndex = 13;
            // 
            // txbUserMySQL
            // 
            this.txbUserMySQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUserMySQL.Location = new System.Drawing.Point(170, 59);
            this.txbUserMySQL.Name = "txbUserMySQL";
            this.txbUserMySQL.Size = new System.Drawing.Size(196, 26);
            this.txbUserMySQL.TabIndex = 12;
            // 
            // txbServerMySQL
            // 
            this.txbServerMySQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbServerMySQL.Location = new System.Drawing.Point(170, 27);
            this.txbServerMySQL.Name = "txbServerMySQL";
            this.txbServerMySQL.Size = new System.Drawing.Size(360, 26);
            this.txbServerMySQL.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Servidor:";
            // 
            // pbCargando
            // 
            this.pbCargando.Image = global::InvenTacos.Properties.Resources.cargando;
            this.pbCargando.Location = new System.Drawing.Point(232, 235);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(169, 94);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCargando.TabIndex = 18;
            this.pbCargando.TabStop = false;
            this.pbCargando.Visible = false;
            // 
            // Frm_ConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 565);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.gbMysql);
            this.Controls.Add(this.gbSoftRestaurant);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ConfigDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurar Bases de Datos";
            this.Load += new System.EventHandler(this.Frm_ConfigDB_Load);
            this.gbSoftRestaurant.ResumeLayout(false);
            this.gbSoftRestaurant.PerformLayout();
            this.pnlDBMSSQL.ResumeLayout(false);
            this.pnlDBMSSQL.PerformLayout();
            this.gbMysql.ResumeLayout(false);
            this.gbMysql.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuertoMySQL)).EndInit();
            this.pnlDBMysql.ResumeLayout(false);
            this.pnlDBMysql.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSoftRestaurant;
        private System.Windows.Forms.GroupBox gbMysql;
        private System.Windows.Forms.Panel pnlDBMSSQL;
        private System.Windows.Forms.Button brnGuardarMSSQL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDBMSSQL;
        private System.Windows.Forms.Button btnProbarMSSQL;
        private System.Windows.Forms.TextBox txbPassMSSQL;
        private System.Windows.Forms.TextBox txbUserMSSQL;
        private System.Windows.Forms.TextBox txbServerMSSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDBMysql;
        private System.Windows.Forms.Button btnGuardarMySQL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDBMySQL;
        private System.Windows.Forms.Button btnProbarMySQL;
        private System.Windows.Forms.TextBox txbPassMySQL;
        private System.Windows.Forms.TextBox txbUserMySQL;
        private System.Windows.Forms.TextBox txbServerMySQL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudPuertoMySQL;
        private System.Windows.Forms.PictureBox pbCargando;
    }
}