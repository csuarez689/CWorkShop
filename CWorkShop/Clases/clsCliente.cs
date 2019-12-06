using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    class clsCliente : clsPersona
    {
        private const string ARCHIVO = "clientes.dat";
        private const string DIR = "..\\Datos\\";
        private string direccion;

        public clsCliente(string Dni, string Nombre, string Apellido, string Mail, string Telefono, string Direccion) :
            base(Dni, Nombre, Apellido, Mail, Telefono)
        {
            this.Direccion = Direccion;
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        //Obtener y formar lista con Clientes
        public static List<clsCliente> Listar()
        {
            CheckFiles();
            clsCliente aux;
            List<clsCliente> clientes = new List<clsCliente>();
            int auxid;
            try
            {
                using (BinaryReader br = new BinaryReader(new FileStream(DIR + ARCHIVO, FileMode.Open)))
                {
                    while (br.PeekChar() != -1)
                    {
                        auxid = br.ReadInt32();
                        aux = new clsCliente(br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString());
                        aux.Id = auxid;
                        clientes.Add(aux);
                    }
                }
                return clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrio un error. " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return clientes;
            }

        }
        //Guardar cliente
        public string Guardar()
        {
            CheckFiles();
            int idAux = ObtenerId();
            string msg = String.Empty;
            try
            {
                if (clsCliente.Listar().Find(x => x.Dni == this.Dni) == null)
                {//si no existe el usuario
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Append)))
                    {
                        bw.Write(idAux);
                        bw.Write(this.Dni);
                        bw.Write(this.Nombre);
                        bw.Write(this.Apellido);
                        bw.Write(this.Mail);
                        bw.Write(this.Telefono);
                        bw.Write(this.Direccion);
                    }
                }
                else
                    msg = "El cliente ya se encuentra registrado.";
            }
            catch (Exception ex)
            {
                msg = "Error interno. " + ex.Message;
            }
            return msg;
        }

        //actualizar cliente
        public string Actualizar() { return string.Empty; }

        //Obtener id siguiente
        private static int ObtenerId()
        {
            List<clsCliente> lista = clsCliente.Listar();
            return (lista.Count > 0) ? lista.Last().Id++ : 1;
        }

        //Chequeo archivos
        private static void CheckFiles()
        {
            string msg=string.Empty;
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
