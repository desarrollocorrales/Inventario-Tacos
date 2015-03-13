using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using InvenTacos.Entity.MySQL;
using DevExpress.XtraGrid.Views.Grid;
using InvenTacos.Modelos;
namespace InvenTacos.GUIs
{
    public partial class Frm_ConfigrarInsumos : Form
    {
        private List<inventario_insumos> lstInsumosTodos;
        private List<inventario_insumos> lstInsumosSeleccioados;

        public Frm_ConfigrarInsumos(List<inventario_insumos> lstInsumosTodos)
        {
            InitializeComponent();
            this.lstInsumosTodos = lstInsumosTodos;
            ValidarListaInsumosConfigurdos();            
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

        private void ValidarListaInsumosConfigurdos()
        {
            if (Properties.Settings.Default.LstInsumosConfigurados == null)
            {
                Properties.Settings.Default.LstInsumosConfigurados = new StringCollection();
            }
        }
        private void LlenarListaInsumosSeleccionados()
        {
            TacosInventarioEntities MyContext = new TacosInventarioEntities(ConnectionStrings.MySQL);
            List<string> lstIDsConfigurados = ObtenerIDsInsumosConfigurados();
            
            var InsumosConfigurados = from buscaInsumos in MyContext.inventario_insumos
                                      where (lstIDsConfigurados.Contains(buscaInsumos.idinsumo))
                                      select buscaInsumos;

            if (InsumosConfigurados.Count() == 0)
            {
                lstInsumosSeleccioados = new List<inventario_insumos>();
            }
            else
            {
                lstInsumosSeleccioados = InsumosConfigurados.OrderBy(o => o.idinsumo).ToList();
            }

            gridInsumosSeleccionados.DataSource = lstInsumosSeleccioados;
            gvInsumosSeleccionados.BestFitColumns();

            MyContext.Dispose();
        }
        private List<string> ObtenerIDsInsumosConfigurados()
        {
            List<string> lstIDsConfigurados = new List<string>();
            foreach (string sID in Properties.Settings.Default.LstInsumosConfigurados)
            {
                lstIDsConfigurados.Add(sID);
            }

            return lstIDsConfigurados;
        }

        private void LlenarListaInsumosTodos()
        {
            gridInsumosTodos.DataSource = lstInsumosTodos;
            gvInsumosTodos.BestFitColumns();  
        }
        private void Frm_ConfigrarInsumos_Load(object sender, EventArgs e)
        {
            LlenarListaInsumosTodos();
            LlenarListaInsumosSeleccionados();
        }

        private inventario_insumos ObtenerInsumoSeleccionado(GridView gv)
        {
            int index = gv.GetSelectedRows()[0];
            inventario_insumos insumo = (inventario_insumos)gv.GetRow(index);
            return insumo;
        }

        private void gvInsumosTodos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                inventario_insumos insumo = ObtenerInsumoSeleccionado(gvInsumosTodos);
                Agregar(insumo);
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void gvInsumosSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstInsumosSeleccioados.Count != 0)
                {
                    inventario_insumos insumo = ObtenerInsumoSeleccionado(gvInsumosSeleccionados);
                    Quitar(insumo);
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                inventario_insumos insumo = ObtenerInsumoSeleccionado(gvInsumosTodos);
                Agregar(insumo);
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstInsumosSeleccioados.Count != 0)
                {
                    inventario_insumos insumo = ObtenerInsumoSeleccionado(gvInsumosSeleccionados);
                    Quitar(insumo);
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void Agregar(inventario_insumos insumo)
        {
            lstInsumosSeleccioados.Add(insumo);
            lstInsumosSeleccioados = lstInsumosSeleccioados.Distinct().ToList();

            gridInsumosSeleccionados.DataSource = lstInsumosSeleccioados;
            gvInsumosSeleccionados.BestFitColumns();
        }
        private void Quitar(inventario_insumos insumo)
        {
            lstInsumosSeleccioados.Remove(insumo);
            lstInsumosSeleccioados = lstInsumosSeleccioados.Distinct().ToList();

            gridInsumosSeleccionados.DataSource = lstInsumosSeleccioados;
            gvInsumosSeleccionados.BestFitColumns();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void Guardar()
        {
            Properties.Settings.Default.LstInsumosConfigurados = new StringCollection();
            
            foreach (inventario_insumos insumo in lstInsumosSeleccioados)
            {
                Properties.Settings.Default.LstInsumosConfigurados.Add(insumo.idinsumo);
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("Los datos se han guardado on exito...", "Guardar", 
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
