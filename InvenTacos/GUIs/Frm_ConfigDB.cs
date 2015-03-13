using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InvenTacos.Modelos;
using DatosInvenTacos;
using InvenTacos.Entity;

namespace InvenTacos.GUIs
{
    public partial class Frm_ConfigDB : Form
    {
        public Frm_ConfigDB()
        {
            InitializeComponent();
        }
        private void MostrarExcepcion(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ocurrio un error.");
            
            while (ex != null)
            {
                sb.AppendLine(ex.Message);
                ex = ex.InnerException;
            }

            MessageBox.Show(sb.ToString());
        }

        private void btnProbarMSSQL_Click(object sender, EventArgs e)
        {
            pbCargando.Visible = true;
            Application.DoEvents();

            ProbarMSSQL();
            pbCargando.Visible = false;
        }
        private void btnProbarMySQL_Click(object sender, EventArgs e)
        {
            pbCargando.Visible = true;
            Application.DoEvents();

            ProbarMySQL();
            pbCargando.Visible = false;
        }

        private void Frm_ConfigDB_Load(object sender, EventArgs e)
        {
            InicializarParametros();
            InicializarCampos();
        }
        private void InicializarParametros()
        {
            if (Properties.Settings.Default.MSSQL == null)
            {
                Properties.Settings.Default.MSSQL = new DBConfig();

                if (Properties.Settings.Default.MySQL == null)
                {
                    Properties.Settings.Default.MySQL = new DBConfig();
                }

                Properties.Settings.Default.Save();
            }
        }
        private void InicializarCampos()
        {
            /***** MS SQL SERVER *****/
            txbServerMSSQL.Text = Properties.Settings.Default.MSSQL.Servidor;
            txbUserMSSQL.Text = Properties.Settings.Default.MSSQL.Usuario;
            txbPassMSSQL.Text= Properties.Settings.Default.MSSQL.Contraseña;

            /***** MySQL *****/
            txbServerMySQL.Text = Properties.Settings.Default.MySQL.Servidor;
            txbUserMySQL.Text = Properties.Settings.Default.MySQL.Usuario;
            txbPassMySQL.Text = Properties.Settings.Default.MySQL.Contraseña;
            nudPuertoMySQL.Value = Properties.Settings.Default.MySQL.Puerto;
        }

        #region ***** Probar Conexiones *****
        
        private void ProbarMSSQL()
        {
            StringBuilder ConnectionString = new StringBuilder();

            ConnectionString.Append("metadata=res://*/Entity.MSSQL.SoftRestaurantModelo.csdl|");
            ConnectionString.Append("res://*/Entity.MSSQL.SoftRestaurantModelo.ssdl|");
            ConnectionString.Append("res://*/Entity.MSSQL.SoftRestaurantModelo.msl;");
            ConnectionString.Append("provider=System.Data.SqlClient;");
            ConnectionString.Append("provider connection string=");
            ConnectionString.Append(string.Format("'data source={0};", txbServerMSSQL.Text));
            ConnectionString.Append(string.Format(" user id={0};", txbUserMSSQL.Text));
            ConnectionString.Append(string.Format(" password={0};'", txbPassMSSQL.Text));

            try
            {
                Entity.MSSQL.SoftRestaurantEntities MSContext = new Entity.MSSQL.SoftRestaurantEntities(ConnectionString.ToString());
                MSContext.Connection.Open();
                MSContext.Connection.Close();

                ObtenerBasesDeDatos(TipoBaseDeDatos.MSSQL);

                pnlDBMSSQL.Visible = true;
            }
            catch (Exception ex)
            {
                pnlDBMSSQL.Visible = false;
                MostrarExcepcion(ex);
            }
        }

        private void ProbarMySQL()
        {
            StringBuilder ConnectionString = new StringBuilder();
            ConnectionString.Append("metadata=res://*/Entity.MySQL.TacosInventarioModel.csdl|");
            ConnectionString.Append("res://*/Entity.MySQL.TacosInventarioModel.ssdl|");
            ConnectionString.Append("res://*/Entity.MySQL.TacosInventarioModel.msl;");
            ConnectionString.Append("provider=MySql.Data.MySqlClient;");
            ConnectionString.Append("provider connection string=");
            ConnectionString.Append(string.Format("'server={0};", txbServerMySQL.Text));
            ConnectionString.Append(string.Format(" user id={0};", txbUserMySQL.Text));
            ConnectionString.Append(string.Format(" port={0};",  nudPuertoMySQL.Value));
            ConnectionString.Append(string.Format(" password={0};'", txbPassMySQL.Text));

            try
            {
                Entity.MySQL.TacosInventarioEntities MyContext = new Entity.MySQL.TacosInventarioEntities(ConnectionString.ToString());
                MyContext.Connection.Open();
                MyContext.Connection.Close();

                ObtenerBasesDeDatos(TipoBaseDeDatos.MySQL);

                pnlDBMysql.Visible = true;
            }
            catch (Exception ex)
            {
                pnlDBMysql.Visible = false;
                MostrarExcepcion(ex);
            }
        }

        #endregion

        #region ***** Guardar datos de conexion *****
        
        private void brnGuardarMSSQL_Click(object sender, EventArgs e)
        {
            Guardar(TipoBaseDeDatos.MSSQL);
        }        

        private void btnGuardarMySQL_Click(object sender, EventArgs e)
        {
            Guardar(TipoBaseDeDatos.MySQL);
        }

        private void Guardar(TipoBaseDeDatos Tipo)
        {
            switch (Tipo)
            {
                case TipoBaseDeDatos.MSSQL:
                    Properties.Settings.Default.MSSQL.Servidor = txbServerMSSQL.Text;
                    Properties.Settings.Default.MSSQL.Usuario = txbUserMSSQL.Text;
                    Properties.Settings.Default.MSSQL.Contraseña = txbPassMSSQL.Text;
                    Properties.Settings.Default.MSSQL.BaseDeDatos = Convert.ToString(cbDBMSSQL.SelectedItem);

                    MessageBox.Show("La configuración para MSSQL SERVER se ha guardado con exito...", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case TipoBaseDeDatos.MySQL:
                    Properties.Settings.Default.MySQL.Servidor = txbServerMySQL.Text;
                    Properties.Settings.Default.MySQL.Usuario = txbUserMySQL.Text;
                    Properties.Settings.Default.MySQL.Contraseña = txbPassMySQL.Text;
                    Properties.Settings.Default.MySQL.Puerto = (int)nudPuertoMySQL.Value;
                    Properties.Settings.Default.MySQL.BaseDeDatos = Convert.ToString(cbDBMySQL.SelectedItem);

                    MessageBox.Show("La configuración para MySQL se ha guardado con exito...", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            Properties.Settings.Default.Save();            
        }

        #endregion      
 
        #region ***** Obtener Bases de datos *****

        private void ObtenerBasesDeDatos(TipoBaseDeDatos Tipo)
        {
            switch (Tipo)
            {
                case TipoBaseDeDatos.MSSQL:
                    ObtenerBasesDeDatosMSSQL();
                    break;

                case TipoBaseDeDatos.MySQL:
                    ObtenerBasesDeDatosMySQL();
                    break;
            }
        }

        private void ObtenerBasesDeDatosMSSQL()
        {
            List<string> lstBasesDeDatos = new List<string>();
            Entity.MSSQL.SoftRestaurantEntities MSContext = new Entity.MSSQL.SoftRestaurantEntities();

            lstBasesDeDatos = MSContext.ExecuteStoreQuery<string>("SELECT name FROM master..sysdatabases").ToList();

            cbDBMSSQL.DataSource = lstBasesDeDatos;

            string sDataBase = Properties.Settings.Default.MSSQL.BaseDeDatos;

            int index = cbDBMSSQL.FindStringExact(sDataBase);
            if (index != -1)
                cbDBMSSQL.SelectedIndex = index;
        }

        private void ObtenerBasesDeDatosMySQL()
        {
            List<string> lstBasesDeDatos = new List<string>();
            Entity.MySQL.TacosInventarioEntities MyContext = new Entity.MySQL.TacosInventarioEntities();

            lstBasesDeDatos = MyContext.ExecuteStoreQuery<string>("Show Databases").ToList();

            cbDBMySQL.DataSource = lstBasesDeDatos;

            string sDataBase = Properties.Settings.Default.MySQL.BaseDeDatos;

            int index = cbDBMySQL.FindStringExact(sDataBase);
            if (index != -1)
                cbDBMySQL.SelectedIndex = index;
        }

        #endregion

    }
}
