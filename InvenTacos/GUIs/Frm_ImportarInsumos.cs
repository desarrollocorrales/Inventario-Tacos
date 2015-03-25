using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mysql = InvenTacos.Entity.MySQL;
using SqlServer = InvenTacos.Entity.MSSQL;
using InvenTacos.Modelos;

namespace InvenTacos.GUIs
{
    public partial class Frm_ImportarInsumos : Form
    {
        public Frm_ImportarInsumos()
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

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ImportarInsumos();
        }
        private void ImportarInsumos()
        {
            try
            {
                MostrarAccion("Iniciando importación de insumos y rendimientos....");
                
                MostrarAccion("Conectando a la base de datos de la aplicación....");
                Mysql.TacosInventarioEntities MyContexto = new Mysql.TacosInventarioEntities(ConnectionStrings.MySQL);

                MostrarAccion("Conectando a la base de datos de SoftRestaurant....");
                SqlServer.SoftRestaurantEntities MSContexto = new SqlServer.SoftRestaurantEntities(ConnectionStrings.MSSQL);

                List<SqlServer.insumos> lstMSInsumos = MSContexto.insumos.ToList(); ;
                List<SqlServer.insumospresentaciones> lstMSPresentaciones = MSContexto.insumospresentaciones.ToList();

                Mysql.inventario_insumos myInsumo;
                SqlServer.insumospresentaciones presentacion;
                MostrarAccion("Inicia la importación....");
                BorrarInsumos(MyContexto);
                foreach (SqlServer.insumos MsSqlInsumo in lstMSInsumos)
                {
                    myInsumo = new Mysql.inventario_insumos();
                    myInsumo.idinsumo = MsSqlInsumo.idinsumo;
                    myInsumo.descripcion = MsSqlInsumo.descripcion;
                    myInsumo.unidad = MsSqlInsumo.unidad;

                    presentacion = lstMSPresentaciones.FirstOrDefault(o => o.idinsumo == MsSqlInsumo.idinsumo);
                    myInsumo.rendimiento = presentacion == null ? null : presentacion.rendimiento; 

                    MyContexto.inventario_insumos.AddObject(myInsumo);
                    MostrarAccion(string.Format("   ID: {0} | Insumo: {1} | unidad: {2} | rendimiento: {3}", 
                                                    myInsumo.idinsumo, myInsumo.descripcion,
                                                    myInsumo.unidad, myInsumo.rendimiento));
                    MyContexto.SaveChanges();
                }

                MostrarAccion("Termina la importación....");
                MyContexto.SaveChanges();

                MSContexto.Dispose();
                MyContexto.Dispose();

                MostrarAccion("El proceso termino correctamente....");
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void BorrarInsumos(Mysql.TacosInventarioEntities Contexto)
        {
            Contexto.ExecuteStoreCommand("SET FOREIGN_KEY_CHECKS = 0;");
            Contexto.ExecuteStoreCommand("TRUNCATE TABLE inventario_insumos");
            Contexto.ExecuteStoreCommand("SET FOREIGN_KEY_CHECKS = 1;");
            Contexto.SaveChanges();
        }

        private void MostrarAccion(string mensaje)
        {
            txbAcciones.Paste(string.Format("{0}{1}", mensaje, Environment.NewLine));
            Application.DoEvents();
        }

    }
}
