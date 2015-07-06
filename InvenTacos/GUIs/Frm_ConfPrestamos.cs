using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InvenTacos.Entity.MSSQL;
using InvenTacos.Modelos;

namespace InvenTacos.GUIs
{
    public partial class Frm_ConfPrestamos : Form
    {
        public Frm_ConfPrestamos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Cargar()
        {
            SoftRestaurantEntities MSContext = new SoftRestaurantEntities(ConnectionStrings.MSSQL);
            List<conceptos> lstConceptos = MSContext.conceptos.ToList();

            Concepto conceptoGrid;
            List<Concepto> lstConceptosGrid = new List<Concepto>();
            foreach (conceptos concept in lstConceptos)
            {
                conceptoGrid = new Concepto();
                conceptoGrid.Seleccion = false;
                conceptoGrid.ConceptoID = concept.idconcepto;
                conceptoGrid.Descripcion = concept.descripcion;

                lstConceptosGrid.Add(conceptoGrid);
            }

            gridConceptos.DataSource = lstConceptosGrid;
            gvConceptos.BestFitColumns();

            gridConceptos.Visible = true;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Guardar()
        {
            List<Concepto> lstConceptosSeleccionados = 
                ((List<Concepto>)gridConceptos.DataSource).FindAll(o => o.Seleccion == true);

            StringBuilder WhereConcepto = new StringBuilder();
            foreach (Concepto concept in lstConceptosSeleccionados)
            {
                WhereConcepto.Append(string.Format("'{0}', ", concept.ConceptoID));
            }
            if (WhereConcepto.Length != 0)
            {
                WhereConcepto.Remove((WhereConcepto.Length - 2), 2);

                Properties.Settings.Default.WhereConcepto = WhereConcepto.ToString();
                Properties.Settings.Default.Save();

                MessageBox.Show("¡La configuracion se ha guardado con exito!", "OK", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione al menos un concepto...", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
