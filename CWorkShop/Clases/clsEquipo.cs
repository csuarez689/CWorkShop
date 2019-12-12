using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    public class clsEquipo
    {
        private const string ARCHIVO = "equipos.dat";
        private const string DIR = "..\\Datos\\";
        private int id;
        private string marca;
        private string tipo;
        private string nroSerie;
        private string modelo;
        private string descripcion;
        private int idCliente;
        private List<clsReparacion> reparaciones;

        public clsEquipo(string marca, string tipo, string nroSerie, string modelo, string descripcion, int idCliente, int id = 0)
        {
            this.id = id;
            this.marca = marca;
            this.tipo = tipo;
            this.nroSerie = nroSerie;
            this.modelo = modelo;
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

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }
        //Cliente correspondiente al equipo
        public clsCliente Cliente
        {
            get
            {
                return clsCliente.Buscar(this.IdCliente);
            }
        }
        //Listado de reparaciones correspondientes al equipo
        public List<clsReparacion> Reparaciones
        {
            get { 
                this.reparaciones=clsReparacion.Listar().FindAll(x => x.IdEquipo == this.Id);
                return reparaciones;
            }
        }
        //Historico de ordenes concluidas del equipo
        public List<clsReparacion> Historico
        {
            get
            {
                this.reparaciones = clsReparacion.Listar().FindAll(x => x.IdEquipo == this.Id);
                return reparaciones;
            }
        }
        //Buscar equipo por id
        public static clsEquipo Buscar(int id)
        {
            return clsEquipo.Listar().Find(x => x.Id == id);
        }
        //Obtiene listado de equipos
        public static List<clsEquipo> Listar()
        {
            CheckFiles();
            clsEquipo aux;
            List<clsEquipo> equipos = new List<clsEquipo>();
            int auxid;
            try
            {
                using (BinaryReader br = new BinaryReader(new FileStream(DIR + ARCHIVO, FileMode.Open)))
                {
                    while (br.PeekChar() != -1)
                    {
                        auxid = br.ReadInt32();
                        aux = new clsEquipo(br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadInt32());
                        aux.Id = auxid;
                        equipos.Add(aux);
                    }
                }
                return equipos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrio un error. " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return equipos;
            }
        }
        //Guardar equipo
        public string Guardar()
        {
            CheckFiles();
            int idAux = ObtenerId();
            string msg = string.Empty;
            try
            {
                if (clsEquipo.Listar().Find(x => x.nroSerie == this.nroSerie && x.idCliente==this.idCliente) == null)
                {//si no existe un equipo registrado con mismo numero de serie y mismo id cliente 
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Append)))
                    {
                        bw.Write(idAux);
                        bw.Write(this.Marca);
                        bw.Write(this.Tipo);
                        bw.Write(this.NroSerie);
                        bw.Write(this.Modelo);
                        bw.Write(this.Descripcion);
                        bw.Write(this.IdCliente);
                    }
                }
                else
                    msg = "El cliente ya posee un equipo con este numero de serie registrado.";
            }
            catch (Exception ex)
            {
                msg = "Error interno. " + ex.Message;
            }
            return msg;
        }
        //Actualizar equipo
        public string Actualizar()
        {
            string msg;
            CheckFiles();
            try
            {
                List<clsEquipo> equipos = clsEquipo.Listar();
                int old = equipos.FindIndex(x => x.Id == this.Id);
                //si el cliente no posee ya un equipo registrado con este numero de serie
                int otro = equipos.FindIndex(x => this.IdCliente == x.IdCliente && this.NroSerie==x.NroSerie);
                msg = (otro != -1 && otro != old) ? "El cliente ya posee un equipo registrado con este numero de serie." : string.Empty;
                if (msg.Equals(string.Empty))
                {
                    equipos[old] = this;
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                    {
                        foreach (clsEquipo x in equipos)
                        {
                            bw.Write(x.Id);
                            bw.Write(x.Marca);
                            bw.Write(x.Tipo);
                            bw.Write(x.NroSerie);
                            bw.Write(x.Modelo);
                            bw.Write(x.Descripcion);
                            bw.Write(x.IdCliente);
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
        //Eliminar equipo
        public static string Eliminar(int id)
        {
            CheckFiles();
            List<clsEquipo> equipos = clsEquipo.Listar();
            try
            {
                string msg = (equipos.Find(x => x.Id == id).Reparaciones.Count > 0) ? "El equipo no se puede eliminar porque posee reparaciones asociadas." : string.Empty;
                if (msg.Equals(string.Empty))
                {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                    {
                        foreach (clsEquipo equipo in equipos)
                        {
                            if (equipo.Id == id) { continue; }
                            bw.Write(equipo.Id);
                            bw.Write(equipo.Marca);
                            bw.Write(equipo.Tipo);
                            bw.Write(equipo.NroSerie);
                            bw.Write(equipo.Modelo);
                            bw.Write(equipo.Descripcion);
                            bw.Write(equipo.IdCliente);
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
        //Obtener id siguiente
        private static int ObtenerId()
        {
            List<clsEquipo> lista = clsEquipo.Listar();
            return (lista.Count > 0) ? lista.Last().Id+1 : 1;
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
