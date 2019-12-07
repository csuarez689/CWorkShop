using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    class clsEquipo
    {
        private const string ARCHIVO = "equipos.dat";
        private const string DIR = "..\\Datos\\";
        private int id;
        private string marca;
        private string tipo;
        private string nroSerie;
        private string descripcion;
        private int idCliente;

        public clsEquipo(string marca, string tipo, string nroSerie, string descripcion, int idCliente)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.nroSerie = nroSerie;
            this.descripcion = descripcion;
            this.idCliente = idCliente;
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

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string NroSerie
        {
            get
            {
                return nroSerie;
            }

            set
            {
                nroSerie = value;
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

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }
        //Obtiene listado de equipos
        public static List<clsEquipo> Listar()
        {
            return new List<clsEquipo>();
        }
        //Obtener id siguiente
        private static int ObtenerId()
        {
            List<clsCliente> lista = clsCliente.Listar();
            return (lista.Count > 0) ? lista.Last().Id++ : 1;
        }
        //Chequeo archivos
        private static void CheckFiles()
        {
            string msg = string.Empty;
            try
            {
                if (!Directory.Exists(DIR))
                {
                    Directory.CreateDirectory(DIR);
                }
                if (!File.Exists(DIR + ARCHIVO)) { File.Create(DIR + ARCHIVO); }
            }
            catch (DirectoryNotFoundException)
            {
                msg = "No se encuentra el directorio.";
            }
            catch (FileNotFoundException)
            {
                msg = "No se encuentran los archivos.";
            }
            catch (Exception ex)
            {
                msg = "Error interno. " + ex.Message;
            }
            if (msg != string.Empty)
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
