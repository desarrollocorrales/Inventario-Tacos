using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvenTacos.Modelos
{
    public class CapturaDeinventario
    {
        public string ClaveInsumo { set; get; }
        public string NombreInsumo { set; get; }
        public decimal CantidadCrudo { set; get; }
        public decimal Rendimiento { set; get; }
        public decimal CantidadCocido { set; get; }
        public decimal CantidadTotal
        {
            get
            {
                decimal Total = (CantidadCrudo * Rendimiento) + CantidadCocido;
                return Total;
            }
        }
        public string Unidad { set; get; }
    }
}
