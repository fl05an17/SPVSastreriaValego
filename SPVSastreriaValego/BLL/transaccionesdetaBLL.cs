using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPVSastreriaValego.BLL
{
    class transaccionesdetaBLL
    {
        public int id { get; set; }
        public int Producto_id { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public int Prov_Clie_id { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
