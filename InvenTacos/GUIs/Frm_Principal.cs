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
            TacosInventariosEntities MyContext = new TacosInventariosEntities();
            
            List<insumos> lstInsumosSeleccionados = new List<insumos>();            
            List<string> lstIDsConfigurados = ObtenerIDsConfigurados();

            var InsumosConfigurados = from buscaInsumos in MyContext.insumos
                                      where (lstIDsConfigurados.Contains(buscaInsumos.idinsumo))
                                      select buscaInsumos;
            
            lstInsumosSeleccionados = InsumosConfigurados.OrderBy(o => o.idinsumo).ToList();
      
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

                TacosInventariosEntities MyContext = new TacosInventariosEntities(ConnectionStrings.MySQL);

                List<insumos> lstInsumos = ObtenerInsumosConfigurados();
                
                if (lstInsumos.Count == 0)
                {
                    StringBuilder sb = new StringBuilder();

                    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<CapturaDeinventario> lstGridPRD = new List<CapturaDeinventario>();

                CapturaDeinventario filaCaptura;
                foreach (insumos myInsumo in lstInsumos)
                {
                    filaCaptura = new CapturaDeinventario();
                    filaCaptura.ClaveInsumo = myInsumo.idinsumo;
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
            TacosInventariosEntities MyContext = new TacosInventariosEntities(ConnectionStrings.MySQL);
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
            TacosInventariosEntities MyContext = new TacosInventariosEntities();
            MyContext.Connection.Open();
            IDbTransaction Transaccion = MyContext.Connection.BeginTransaction();

            try
            {
                List<CapturaDeinventario> lstInventarioCapturado = (List<CapturaDeinventario>)gridCapturaInventario.DataSource;

                inventdiarios RegistroBD;
                foreach (CapturaDeinventario Registro in lstInventarioCapturado)
                {
                    RegistroBD = new inventdiarios();
                    RegistroBD.idinsumo = Registro.ClaveInsumo;
                    RegistroBD.cantidad_cocido = Registro.CantidadCocido;
                    RegistroBD.cantidad_crudo = Registro.CantidadCrudo;
                    RegistroBD.cantidad_total = Registro.CantidadTotal;
                    RegistroBD.fecha = dtpFecha.Value.Date;

                    MyContext.inventdiarios.AddObject(RegistroBD);
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

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            ValidarListaDeInsumosConfigurados();
        }
    }
}
