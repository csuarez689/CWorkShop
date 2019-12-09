using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWorkShop.Clases
{
    class clsRepuestosUsados
    {
        private const string ARCHIVO = "repuestosUsados.dat";
        private const string DIR = "..\\Datos\\";
        private int id;
        private string codigo;
        private string descripcion;
        private float precio;

        public clsRepuestosUsados(string codigo, string descripcion, float precio, int id = 0)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
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

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }
}
