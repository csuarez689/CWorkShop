using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWorkShop.Clases
{
    class clsCliente : clsPersona
    {

        public clsCliente(string Dni, string Nombre, string Apellido, string Mail, string Telefono) :
            base(Dni, Nombre, Apellido, Mail, Telefono)
        {
        }

        //Listar clientes
        public static List<clsCliente> All()
        {
            try
            {
            }
            catch { throw; }
            return null;
        }

        //guardar cliente
        public bool Guardar()
        {
            return true;
        }

        public bool Actualizar()
        {

            return true;
        }

        public bool Borrar()
        {

            return true;
        }
    }
}
