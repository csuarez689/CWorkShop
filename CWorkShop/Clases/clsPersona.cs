using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWorkShop.Clases
{
    public abstract class clsPersona
    {
        private int id;
        private string dni;
        private string nombre;
        private string apellido;
        private string mail;
        private string telefono;
        private bool borrado;

        public clsPersona(string Dni, string Nombre, string Apellido, string Mail, string Telefono,bool borrado=false)
        {
            this.Dni = Dni;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Mail = Mail;
            this.Telefono = Telefono;
            this.Borrado = borrado;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public bool Borrado
        {
            get
            {
                return borrado;
            }

            set
            {
                borrado = value;
            }
        }
    }
}
