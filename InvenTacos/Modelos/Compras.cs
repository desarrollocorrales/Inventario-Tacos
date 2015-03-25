using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvenTacos.Modelos
{
    public class Compras
    {
        public decimal ID_Compra { set; get; }
        public string ID_Insumo { set; get; }
        public decimal Cantidad { set; get; }
        public string Fecha { set; get; }
        public DateTime dtFecha
        {
            get
            {
                return Convert.ToDateTime(Fecha);
            }
        }
    }
}
