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
        private string MSStringDeConexion, MySQLStringDeConexion;

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
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("metadata=res://*/Entity.MSSQL.SoftRestaurantModelo.csdl|");
                sb.Append("res://*/Entity.MSSQL.SoftRestaurantModelo.ssdl|");
                sb.Append("res://*/Entity.MSSQL.SoftRestaurantModelo.msl;");
                sb.Append("provider=System.Data.SqlClient;");
                sb.Append("provider connection string=\"");
                sb.Append(string.Format("data source={0};",txbServerMSSQL.Text));
                sb.Append(string.Format("user id={0};password={1};",txbUserMSSQL.Text, txbPassMSSQL.Text));
                sb.Append("multipleactiveresultsets=True;App=EntityFramework\"");

                MSStringDeConexion = sb.ToString();

                Entity.MSSQL.SoftRestaurantEntities MSContext = new Entity.MSSQL.SoftRestaurantEntities(MSStringDeConexion);
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
            try
            {
                StringBuilder sb = new StringBuilder();               
                sb.Append("metadata=res://*/Entity.MySQL.TacosInventarioModel.csdl|");
                sb.Append("res://*/Entity.MySQL.TacosInventarioModel.ssdl|");
                sb.Append("res://*/Entity.MySQL.TacosInventarioModel.msl;");
                sb.Append("provider=MySql.Data.MySqlClient;provider connection string=\"");
                sb.Append(string.Format("server={0};user id={1};",txbServerMySQL.Text, txbUserMySQL.Text));
                sb.Append(string.Format("password={0};\"",txbPassMySQL.Text));

                MySQLStringDeConexion = sb.ToString();

                Entity.MySQL.TacosInventarioEntities MyContext = new Entity.MySQL.TacosInventarioEntities(MySQLStringDeConexion);
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
            Entity.MSSQL.SoftRestaurantEntities MSContext = new Entity.MSSQL.SoftRestaurantEntities(MSStringDeConexion);

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
            Entity.MySQL.TacosInventarioEntities MyContext = new Entity.MySQL.TacosInventarioEntities(MySQLStringDeConexion);

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
