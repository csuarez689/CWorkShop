using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWorkShop.Clases
{
    class clsUsuario
    {
        private int Id { get; }
        private string Dni { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Mail { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }
        private string Rol { get; set; }
    }
}
