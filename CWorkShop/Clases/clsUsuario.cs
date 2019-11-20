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

        private List<clsReparacion> Reparaciones { get; set; }

        public clsUsuario (string Dni, string Nombre, string Apellido, string Mail, string Telefono, string Direccion, string Contraseña, string Rol) :
            base(Dni,Nombre,Apellido,Mail,Telefono,Direccion)
        {
            this.Contraseña = Contraseña;
            this.Rol = Rol;
            Reparaciones = new List<clsReparacion>();
        }



        public bool Guardar()
        {
            return true;
        }
    }
}
