using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPVSastreriaValego.BLL
{
    class transaccionesBLL
    {
        public int id { get; set; }
        public string Tipo { get; set; }
        public int Prov_Clie_id { get; set; }
        public decimal GranTotal { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public decimal iva { get; set; }
        public decimal Descuento { get; set; }
        public int added_by { get; set; }
    }
}
