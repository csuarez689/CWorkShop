using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    public class clsRepuesto
    {
        private const string ARCHIVO = "repuestos.dat";
        private const string DIR = "..\\Datos\\";
        private int id;
        private string codigo;
        private string descripcion;
        private double precioCompra;
        private double precioVenta;
        private int stock;

        public clsRepuesto(string codigo, string descripcion, double precioCompra, double precioVenta, int stock, int id = 0)
        {
            this.id = id;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.stock = stock;
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

        public double PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }

        public double PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set
            {
                precioVenta = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        //Obtiene listado de repuestos
        public static List<clsRepuesto> Listar()
        {
            CheckFiles();
            clsRepuesto aux;
            List<clsRepuesto> repuestos = new List<clsRepuesto>();
            int auxid;
            try
            {
                using (BinaryReader br = new BinaryReader(new FileStream(DIR + ARCHIVO, FileMode.Open)))
                {
                    while (br.PeekChar() != -1)
                    {
                        auxid = br.ReadInt32();
                        aux = new clsRepuesto(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadDouble(), br.ReadInt32());
                        aux.Id = auxid;
                        repuestos.Add(aux);
                    }
                }
                return repuestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrio un error. " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return repuestos;
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
                msg = (stock < 0) ? "El stock no puede ser negativo." : string.Empty;
                if (clsRepuesto.Listar().Find(x => x.Codigo == this.Codigo) == null)
                {//si no existe un repuesto con el mismo numero de codigo
                    if (msg.Equals(string.Empty))
                    {
                        using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Append)))
                        {
                            bw.Write(idAux);
                            bw.Write(this.Codigo);
                            bw.Write(this.Descripcion);
                            bw.Write(this.PrecioCompra);
                            bw.Write(this.PrecioVenta);
                            bw.Write(this.Stock);
                        }
                    }
                }
                else
                    msg = "El codigo de este producto ya se encuentra registrado.";
            }
            catch (Exception ex)
            {
                msg = "Error interno. " + ex.Message;
            }
            return msg;
        }
        //Actualizar repuesto
        public string Actualizar()
        {
            string msg;
            CheckFiles();
            try
            {
                List<clsRepuesto> repuestos = clsRepuesto.Listar();
                int old = repuestos.FindIndex(x => x.Id == this.Id);
                //si no existe el mismo codigo de producto registrado
                int otro = repuestos.FindIndex(x => this.Codigo == x.Codigo && this.Id != x.Id);
                msg = (otro != -1 && otro != old) ? "El codigo ingresado ya se encuentra registrado." : string.Empty;
                if (msg.Equals(string.Empty))
                {
                    repuestos[old] = this;
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                    {
                        foreach (clsRepuesto x in repuestos)
                        {
                            bw.Write(x.Id);
                            bw.Write(x.Codigo);
                            bw.Write(x.Descripcion);
                            bw.Write(x.PrecioCompra);
                            bw.Write(x.PrecioVenta);
                            bw.Write(x.Stock);
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
        //Eliminar repuesto
        public static string Eliminar(int id)
        {
            CheckFiles();
            List<clsRepuesto> repuestos = clsRepuesto.Listar();
            try
            {
                string msg = string.Empty;
                using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                {
                    foreach (clsRepuesto repuesto in repuestos)
                    {
                        if (repuesto.Id == id) { continue; }
                        bw.Write(repuesto.Id);
                        bw.Write(repuesto.Codigo);
                        bw.Write(repuesto.Descripcion);
                        bw.Write(repuesto.PrecioCompra);
                        bw.Write(repuesto.PrecioVenta);
                        bw.Write(repuesto.Stock);
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error. " + ex.Message;
            }

        }
        //Buscar repuesto por id
        public static clsReparacion Buscar(int id)
        {
            return clsReparacion.Listar().Find(x => x.Id == id);
        }
        //Obtener id siguiente
        private static int ObtenerId()
        {
            List<clsRepuesto> lista = clsRepuesto.Listar();
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
