using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InvenTacos.Entity.MySQL;
using InvenTacos.Modelos;
using System.Collections.Specialized;
using MSSQL = InvenTacos.Entity.MSSQL;

namespace InvenTacos.GUIs
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }
        private void MostrarExcepcion(Exception ex)
        {
            StringBuilder sb;            

            Exception innerEx = ex.InnerException;
            if (innerEx != null)
            {
                if (innerEx.Message.ToUpper().Contains("DUPLICATE ENTRY"))
                {
                    sb = new StringBuilder();
                    sb.AppendLine("Ocurrio un error.");
                    sb.Append("El inventario para el dia ");
                    sb.Append(dtpFecha.Value.ToString("dddd dd/MMMM/yyyy").ToUpper());
                    sb.Append(" ya fue capturado...");
                    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            sb = new StringBuilder();
            sb.AppendLine("Ocurrio un error.");
            while (ex != null)
            {
                sb.AppendLine(ex.Message);
                ex = ex.InnerException;
            }

            MessageBox.Show(sb.ToString());
        }
        private bool RevisarPermisos()
        {
            bool Autorizado = false;
            Frm_Permitir frmPermitir = new Frm_Permitir();
            frmPermitir.ShowDialog();
            Autorizado = frmPermitir.Autorizado;

            return Autorizado;
        }
       
        private void btnIniciarCaptura_Click(object sender, EventArgs e)
        {
            IniciarCaptura();
        }
        private void ValidarListaDeInsumosConfigurados()
        {
            if (Properties.Settings.Default.LstInsumosConfigurados == null)
            {
                Properties.Settings.Default.LstInsumosConfigurados = new StringCollection();
            }
        }

        private List<insumos> ObtenerInsumosConfigurados()
        {
            TacosInventarioEntities MyContext = new TacosInventarioEntities(ConnectionStrings.MySQL);
            
            List<insumos> lstInsumosSeleccionados = new List<insumos>();            
            List<string> lstIDsConfigurados = ObtenerIDsConfigurados();

            var InsumosConfigurados = from buscaInsumos in MyContext.insumos
                                      where (lstIDsConfigurados.Contains(buscaInsumos.id_insumo))
                                      select buscaInsumos;
            
            lstInsumosSeleccionados = InsumosConfigurados.OrderBy(o => o.id_insumo).ToList();
      
            MyContext.Dispose();

            return lstInsumosSeleccionados;
        }
        private List<string> ObtenerIDsConfigurados()
        {
            List<string> lstIdsInsumos = new List<string>();
            
            foreach (string Id in Properties.Settings.Default.LstInsumosConfigurados)
            {
                lstIdsInsumos.Add(Id);
            }

            return lstIdsInsumos;
        }

        private void IniciarCaptura()
        {
            try
            {
                DateTime FechaServer = DateTime.Today.Date;
                if (FechaServer < dtpFecha.Value.Date)
                {
                    MessageBox.Show("La fecha seleccionada es incorrecta...", "Error", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dtpFecha.Enabled = false;
                pbCargando.Visible = true;
                Application.DoEvents();

                TacosInventarioEntities MyContext = new TacosInventarioEntities(ConnectionStrings.MySQL);

                List<insumos> lstInsumos = ObtenerInsumosConfigurados();
                
                if (lstInsumos.Count == 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("No hay insumos configurados...");
                    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<CapturaDeinventario> lstGridPRD = new List<CapturaDeinventario>();

                CapturaDeinventario filaCaptura;
                foreach (insumos myInsumo in lstInsumos)
                {
                    filaCaptura = new CapturaDeinventario();
                    filaCaptura.ClaveInsumo = myInsumo.id_insumo;
                    filaCaptura.NombreInsumo = myInsumo.descripcion;
                    filaCaptura.Rendimiento = Convert.ToDecimal(myInsumo.rendimiento);
                    filaCaptura.Unidad = myInsumo.unidad;
                    lstGridPRD.Add(filaCaptura);
                }

                gridCapturaInventario.DataSource = lstGridPRD;
                gvCapturaInventario.BestFitColumns();

                MyContext.Dispose();
                pbCargando.Visible = false;
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void OpcConfigurar_Click(object sender, EventArgs e)
        {
            if (RevisarPermisos() == true)
            {
                new Frm_ConfigDB().ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso denegado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void importarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RevisarPermisos() == true)
            {
                new Frm_ImportarInsumos().ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso denegado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void configurarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RevisarPermisos() == true)
            {
                try
                {
                    pbCargando.Visible = true;
                    Application.DoEvents();
                    List<insumos> lstInsumostodos = ObtenerTodosLosInsumos();
                    new Frm_ConfigrarInsumos(lstInsumostodos).ShowDialog();
                    pbCargando.Visible = false;
                }
                catch (Exception ex)
                {
                    MostrarExcepcion(ex);
                }
            }
            else
            {
                MessageBox.Show("Acceso denegado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }
        
        private List<insumos> ObtenerTodosLosInsumos()
        {
            TacosInventarioEntities MyContext = new TacosInventarioEntities(ConnectionStrings.MySQL);
            List<insumos> lstInsumos = MyContext.insumos.ToList();
            MyContext.Dispose();
            return lstInsumos;
        }

        private bool Validar()
        {
            if (gvCapturaInventario.DataRowCount == 0)
            {
                MessageBox.Show("No se ha capturado el inventario...", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nota: Las Compras del día también serán exportadas. Asegurese de haberlas capturado.");
            sb.AppendLine();
            sb.AppendLine("¿Los datos son correctos?");

            sb.AppendLine(string.Format("FECHA: {0}",dtpFecha.Value.ToString("dddd dd/MMMM/yyyy").ToUpper()));
            DialogResult dr =
                MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                return true;

            return false; ;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar() == true)
                {
                    GuardarCompras();
                    GuardarInventario();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("¡¡¡El inventario para el dia ");
                    sb.Append(dtpFecha.Value.ToString("dddd dd/MMMM/yyyy"));
                    sb.Append(" ha sido guardado con exito!!!");
                    MessageBox.Show(sb.ToString(), "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }

            dtpFecha.Enabled = true;
        }
        private void GuardarInventario()
        {
            TacosInventarioEntities MyContext = new TacosInventarioEntities(ConnectionStrings.MySQL);
            MyContext.Connection.Open();
            IDbTransaction Transaccion = MyContext.Connection.BeginTransaction();

            try
            {
                List<CapturaDeinventario> lstInventarioCapturado = (List<CapturaDeinventario>)gridCapturaInventario.DataSource;

                inventarios_diarios RegistroBD;
                foreach (CapturaDeinventario Registro in lstInventarioCapturado)
                {
                    RegistroBD = new inventarios_diarios();
                    RegistroBD.id_insumo = Registro.ClaveInsumo;
                    RegistroBD.cantidad_cocido = Registro.CantidadCocido;
                    RegistroBD.cantidad_crudo = Registro.CantidadCrudo;
                    RegistroBD.cantidad_total = Registro.CantidadTotal;
                    RegistroBD.fecha = dtpFecha.Value.Date;

                    MyContext.inventarios_diarios.AddObject(RegistroBD);
                    MyContext.SaveChanges();
                }

                Transaccion.Commit();

                if (MyContext.Connection.State != ConnectionState.Closed)
                {
                    MyContext.Connection.Close();
                }

                MyContext.Dispose();
            }
            catch(Exception ex)
            {
                Transaccion.Rollback();

                if (MyContext.Connection.State != ConnectionState.Closed)
                {
                    MyContext.Connection.Close();
                }

                MyContext.Dispose();

                throw ex;
            }
        }
        private void GuardarCompras()
        {
            DateTime dtFecha = dtpFecha.Value;
            List<Compras> lstCompras = ObtenerCompras(dtFecha);

            TacosInventarioEntities MySQLContexto = new TacosInventarioEntities(ConnectionStrings.MySQL);

            MySQLContexto.ExecuteStoreCommand("SET FOREIGN_KEY_CHECKS = 0;");
            MySQLContexto.ExecuteStoreCommand("DELETE FROM compras WHERE fecha = '{0}'", dtFecha.ToString("yyyy-MM-dd"));
            MySQLContexto.ExecuteStoreCommand("SET FOREIGN_KEY_CHECKS = 1;");
            MySQLContexto.SaveChanges();

            compras compra;
            foreach (Compras c in lstCompras)
            {
                compra = new compras();
                compra.id_compra = Convert.ToInt64(c.ID_Compra);
                compra.id_insumo = c.ID_Insumo;
                compra.cantidad = c.Cantidad;
                compra.fecha = c.dtFecha;

                MySQLContexto.compras.AddObject(compra);
                MySQLContexto.SaveChanges();
            }
        }
        private List<Compras> ObtenerCompras(DateTime fecha)
        {
            MSSQL.SoftRestaurantEntities MSContexto = new MSSQL.SoftRestaurantEntities();
            string sFecha = fecha.ToString("yyyy-MM-dd");
            string sFechaMasUno = fecha.AddDays(1).ToString("yyyy-MM-dd");

            string sConsulta =
                string.Format(
                    @"SELECT 
                      idcompra ID_Compra, idinsumo ID_Insumo, cantidad Cantidad, '{0}' Fecha
                    FROM
                      movsinv
                    WHERE
                      movsinv.idcompra IN 
                          (SELECT c.idcompra 
                             FROM compras c 
                            WHERE 
                                  (c.cancelado = 0 OR c.cancelado IS NULL) AND (c.fechaaplicacion BETWEEN '{0}' AND '{1}')) 
                                  AND movsinv.idconcepto = 'EPC'", sFecha, sFechaMasUno);

            List<Compras> lstCompras = MSContexto.ExecuteStoreQuery<Compras>(sConsulta).ToList();
            MSContexto.Dispose();

            return lstCompras;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            ValidarListaDeInsumosConfigurados();
        }

    }
}
