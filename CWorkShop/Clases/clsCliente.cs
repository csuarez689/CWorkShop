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
        private List<clsEquipo> equipos;

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

        public List<clsEquipo> Equipos
        {
            get
            {
                this.equipos= clsEquipo.Listar().FindAll(x => x.IdCliente == this.Id);
                return equipos;
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
            string msg = string.Empty;
            try
            {
                if (clsCliente.Listar().Find(x => x.Dni == this.Dni) == null)
                {//si no existe cliente
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
        //Actualizar cliente
        public string Actualizar()
        {
            string msg = string.Empty;
            CheckFiles();
            try
            {
                List<clsCliente> clientes = clsCliente.Listar();
                int old = clientes.FindIndex(x => x.Dni == this.Dni);
                if (msg.Equals(string.Empty))
                {
                    clientes[old] = this;
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                    {
                        foreach (clsCliente x in clientes)
                        {
                            bw.Write(x.Id);
                            bw.Write(x.Dni);
                            bw.Write(x.Nombre);
                            bw.Write(x.Apellido);
                            bw.Write(x.Mail);
                            bw.Write(x.Telefono);
                            bw.Write(x.Direccion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "Ha ocurrio un error. " + ex.Message;
            }
            return msg;
        }
        //Obtener id siguiente
        private static int ObtenerId()
        {
            List<clsCliente> lista = clsCliente.Listar();
            return (lista.Count > 0) ? lista.Last().Id++ : 1;
        }
        //Eliminar cliente
        public static string Eliminar(string dni)
        {
            List<clsCliente> clientes = clsCliente.Listar();
            try
            {
                string msg = (clientes.Find(x=>x.Dni==dni).Equipos.Count>0) ? "El cliente no se puede eliminar porque posee registros asociados." : string.Empty;
                    if (msg.Equals(string.Empty))
                    {
                        using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                        {
                            foreach(clsCliente cliente in clientes)
                            {
                                if (cliente.Dni.Equals(dni)) { continue; }
                                bw.Write(cliente.Id);
                                bw.Write(cliente.Dni);
                                bw.Write(cliente.Nombre);
                                bw.Write(cliente.Apellido);
                                bw.Write(cliente.Mail);
                                bw.Write(cliente.Telefono);
                                bw.Write(cliente.Direccion);
                            }
                        }
                    }
                return msg;
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error. " + ex.Message;
            }

        }
        //Buscar por dni
        public static clsCliente Buscar(string dni)
        {
            return clsCliente.Listar().Find(x => x.Dni == dni);
        }
        //Buscar por id
        public static clsCliente Buscar(int id)
        {
            return clsCliente.Listar().Find(x => x.Id == id);
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
