using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWorkShop.Clases
{
    class clsUsuario : clsPersona
    {
        private string Contraseña { get; set; }
        private string Rol { get; set; }

        public bool Guardar()
        {
            return true;
        }
    }
}
