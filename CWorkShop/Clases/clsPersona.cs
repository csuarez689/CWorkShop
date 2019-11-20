using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWorkShop.Clases
{
    abstract class clsPersona
    {
        private int Id { get; }
        private string Dni { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Mail { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }

        public clsPersona(string Dni, string Nombre, string Apellido, string Mail, string Telefono, string Direccion)
        {
            this.Dni = Dni;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Mail = Mail;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }
    }
}
