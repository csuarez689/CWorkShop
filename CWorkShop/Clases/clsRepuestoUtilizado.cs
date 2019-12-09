using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    class clsRepuestoUtilizado
    {
        private const string ARCHIVO = "repuestosUtilizados.dat";
        private const string DIR = "..\\Datos\\";
        private int id;
        private string codigo;
        private string descripcion;
        private double precio;
        private int idReparacion;

        public clsRepuestoUtilizado(string codigo, string descripcion, double precio, int idReparacion, int id = 0)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.idReparacion = idReparacion;
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

        public double Precio
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

        public int IdReparacion
        {
            get
            {
                return idReparacion;
            }

            set
            {
                idReparacion = value;
            }
        }

        //Obtiene listado de repuestos
        public static List<clsRepuestoUtilizado> Listar()
        {
            CheckFiles();
            clsRepuestoUtilizado aux;
            List<clsRepuestoUtilizado> repuestosUtilizados = new List<clsRepuestoUtilizado>();
            int auxid;
            try
            {
                using (BinaryReader br = new BinaryReader(new FileStream(DIR + ARCHIVO, FileMode.Open)))
                {
                    while (br.PeekChar() != -1)
                    {
                        auxid = br.ReadInt32();
                        aux = new clsRepuestoUtilizado(br.ReadString(), br.ReadString(), br.ReadDouble(),br.ReadInt32());
                        aux.Id = auxid;
                        repuestosUtilizados.Add(aux);
                    }
                }
                return repuestosUtilizados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrio un error. " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return repuestosUtilizados;
            }

        }
        //Guardar repuesto
        public string Guardar()
        {
            CheckFiles();
            int idAux = ObtenerId();
            string msg = string.Empty;
            try
            {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Append)))
                    {
                        bw.Write(idAux);
                        bw.Write(this.Codigo);
                        bw.Write(this.Descripcion);
                        bw.Write(this.Precio);
                        bw.Write(this.IdReparacion);
                    }
                }
            catch (Exception ex)
            {
                msg = "Error interno. " + ex.Message;
            }
            return msg;
        }
        //Eliminar repuesto
        public static string Eliminar(int id)
        {
            List<clsRepuestoUtilizado> repuestosUtilizados = clsRepuestoUtilizado.Listar();
            try
            {
                string msg = string.Empty;
                using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                {
                    foreach (clsRepuestoUtilizado repuesto in repuestosUtilizados)
                    {
                        if (repuesto.Id == id) { continue; }
                        bw.Write(repuesto.Id);
                        bw.Write(repuesto.Codigo);
                        bw.Write(repuesto.Descripcion);
                        bw.Write(repuesto.IdReparacion);
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
            List<clsRepuestoUtilizado> lista = clsRepuestoUtilizado.Listar();
            return (lista.Count > 0) ? lista.Last().Id + 1 : 1;
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
