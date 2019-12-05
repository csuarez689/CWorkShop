using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CWorkShop.Clases
{
    public class clsUsuario : clsPersona
    {
        private const string ARCHIVO = "usuarios.dat";
        private const string DIR = "..\\Datos\\";
        private string contraseña;
        private string rol;

        public clsUsuario(string Dni, string Nombre, string Apellido, string Mail, string Telefono, string Rol, bool Borrado = false, string Contraseña = null) :
        base(Dni, Nombre, Apellido, Mail, Telefono, Borrado)
        {
            this.Contraseña = Contraseña;
            this.Rol = Rol;
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

        public string Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
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
                        bw.Write(this.Rol);
                        bw.Write(this.Borrado);
                        bw.Write(this.Contraseña);
                    }
                }
                else
                    msg = "El usuario ya se encuentra registrado.";
            }
            catch (Exception) { throw; }
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
                        aux = new clsUsuario(br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadBoolean(), br.ReadString());
                        aux.Id = auxid;
                        usuarios.Add(aux);
                    }
                }
                return usuarios;
            }
            catch (Exception ex) { throw; }

        }

        //Desabilitar o habilitar usuario
        public static string SaveState(string dni)
        {
            CheckFiles();
            string res = String.Empty;
            try
            {
                clsUsuario usuario=clsUsuario.Buscar(dni);
                if(usuario==null){ res = "No se encontro el usuario"; }
                else
                {
                    usuario.Borrado = !(usuario.Borrado);//invierte estado
                    usuario.Actualizar();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }

        //Buscar por dni
        public static clsUsuario Buscar(string dni)
        {
            return clsUsuario.Listar().Find(x => x.Dni == dni);
        }

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
                        bw.Write(x.Rol);
                        bw.Write(x.Borrado);
                        bw.Write(x.Contraseña);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return msg;
        }

        //Id siguiente
        private static int ObtenerId()
        {
            List<clsUsuario> lista = clsUsuario.Listar();
            return (lista.Count > 0) ? lista.Last().Id++ : 1;
        }

        //Chequeo archivos
        private static void CheckFiles()
        {
            try
            {
                if (!Directory.Exists(DIR))
                {
                    Directory.CreateDirectory(DIR);
                }
                if (!File.Exists(DIR + ARCHIVO)) { File.Create(DIR + ARCHIVO); }
            }
            catch (Exception ex) { throw; }
        }

        //Login
        public static string Login(string dni, string contraseña)
        {
            string msg = string.Empty;
            try
            {
                clsUsuario usuario = clsUsuario.Buscar(dni);
                if (usuario == null)
                    msg = "El usuario no se encuentra registrado.";
                else if (usuario.Borrado)
                    msg = "Su usuario se encuentra deshabilitado, contacte al administrador.";
                else if (!usuario.contraseña.Equals(contraseña))
                    msg = "Contraseña incorrecta.";
            }
            catch (Exception) { throw; }
            return msg;
        }
    }
}
