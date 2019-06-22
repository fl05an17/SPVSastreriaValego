using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPVSastreriaValego.BLL
{
    class usuariosBLL
    {
        //Para sacar rapidamente los Get y Set abreviar [prop + 2 veces TAB]
        //Agregaremos todos los metodos de los campos de la tabla de Usuarios
        public int id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Genero { get; set; }

        public string TipodeUsuario { get; set; }

        public DateTime added_date { get; set; }

        public int added_by { get; set; }

    }
}
