using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPVSastreriaValego.BLL
{
    class productosBLL
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
