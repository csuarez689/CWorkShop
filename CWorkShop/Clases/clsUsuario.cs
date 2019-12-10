using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    public class clsUsuario : clsPersona
    {
        private const string ARCHIVO = "usuarios.dat";
        private const string DIR = "..\\Datos\\";
        private string contraseña;

        public clsUsuario() :
            base(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty)
        {
            this.contraseña = string.Empty;
        }
        public clsUsuario(string Dni, string Nombre, string Apellido, string Mail, string Telefono, string Contraseña) :
        base(Dni, Nombre, Apellido, Mail, Telefono)
        {
            this.Contraseña = Contraseña;
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        //Guardar usuario
        public string Guardar()
        {
            CheckFiles();
            int idAux = ObtenerId();
            string msg = String.Empty;
            try
            {
                if (clsUsuario.Listar().Find(x => x.Dni == this.Dni) == null)
                {//si no existe el usuario
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Append)))
                    {
                        bw.Write(idAux);
                        bw.Write(this.Dni);
                        bw.Write(this.Nombre);
                        bw.Write(this.Apellido);
                        bw.Write(this.Mail);
                        bw.Write(this.Telefono);
                        bw.Write(this.Contraseña);
                    }
                }
                else
                    msg = "El usuario ya se encuentra registrado.";
            }
            catch (Exception ex)
            {
                msg = "Error interno. "+ex.Message;
            }
            return msg;
        }

        //Obtener y formar lista con Usuarios
        public static List<clsUsuario> Listar()
        {
            CheckFiles();
            clsUsuario aux;
            List<clsUsuario> usuarios = new List<clsUsuario>();
            int auxid;
            try
            {
                using (BinaryReader br = new BinaryReader(new FileStream(DIR + ARCHIVO, FileMode.Open)))
                {
                    while (br.PeekChar() != -1)
                    {
                        auxid = br.ReadInt32();
                        aux = new clsUsuario(br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString());
                        aux.Id = auxid;
                        usuarios.Add(aux);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrio un error. " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return usuarios;
            }
        }

        //Buscar por dni
        public static clsUsuario Buscar(string dni)
        {
            return clsUsuario.Listar().Find(x => x.Dni == dni);
        }

        //Buscar por id
        public static clsUsuario Buscar(int id)
        {
            clsUsuario usuario=clsUsuario.Listar().Find(x => x.Id == id);
            if (usuario != null) { usuario.Contraseña = ""; }
            return usuario;
        }

        //Actualizar usuario
        public string Actualizar()
        {
            string msg = string.Empty;
            CheckFiles();
            try
            {
                List<clsUsuario> usuarios = clsUsuario.Listar();
                int old=usuarios.FindIndex(x=>x.Dni==this.Dni);
                usuarios[old] = this;
                using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                {
                    foreach (clsUsuario x in usuarios)
                    {
                        bw.Write(x.Id);
                        bw.Write(x.Dni);
                        bw.Write(x.Nombre);
                        bw.Write(x.Apellido);
                        bw.Write(x.Mail);
                        bw.Write(x.Telefono);
                        bw.Write(x.Contraseña);
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "Ha ocurrio un error. " + ex.Message;
            }
            return msg;
        }

        //Ontener id siguiente
        private static int ObtenerId()
        {
            List<clsUsuario> lista = clsUsuario.Listar();
            return (lista.Count > 0) ? lista.Last().Id+1 : 1;
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

        //Login
        public static string Login(string dni, string contraseña)
        {
            string msg = string.Empty;
            CheckFiles();
            try
            {
                clsUsuario usuario = clsUsuario.Buscar(dni);
                if (usuario == null)
                    msg = "El usuario no se encuentra registrado.";
                else if (!usuario.contraseña.Equals(contraseña))
                    msg = "Contraseña incorrecta.";
            }
            catch (Exception ex)
            {
                msg = "Error interno. "+ex.Message;
            }
            return msg;
        }
    }
}
