using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPVSastreriaValego.BLL
{
    class provclieBLL
    {
        public int id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
