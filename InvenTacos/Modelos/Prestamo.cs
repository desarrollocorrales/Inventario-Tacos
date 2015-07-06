using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvenTacos.Modelos
{
    public class Prestamo
    {
        public string idconcepto { set; get; }
        public string idinsumo { set; get; }
        public decimal cantidad { set; get; }
        public DateTime fecha { set; get; }
        public string nota { set; get; }
    }
}
