using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    public class clsRepuestoUtilizado
    {
        private const string ARCHIVO = "repuestosUtilizados.dat";
        private const string DIR = "..\\Datos\\";
        private int id;
        private string codigo;
        private string descripcion;
        private double precioCompra;
        private double precioVenta;
        private int cantidad;
        private int idReparacion;

        public clsRepuestoUtilizado(string codigo, string descripcion, double precioCompra, double precioVenta, int cantidad, int idReparacion, int id = 0)
        {
            this.id = id;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
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

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
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
                        aux = new clsRepuestoUtilizado(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadDouble(), br.ReadInt32(), br.ReadInt32(), auxid);
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
        //Buscar repuesto por id
        public static clsRepuestoUtilizado Buscar(int id)
        {
            return clsRepuestoUtilizado.Listar().Find(x => x.Id == id);
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
                    bw.Write(this.PrecioCompra);
                    bw.Write(this.PrecioVenta);
                    bw.Write(this.cantidad);
                    bw.Write(this.IdReparacion);
                }
                //Busco el repuesto del inventario y actualizo su stock con la cantidad del repuesto utilizado
                clsRepuesto repuesto = clsRepuesto.Buscar(this.codigo);
                repuesto.Stock -= this.cantidad;
                msg= repuesto.Actualizar();
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
            CheckFiles();
            List<clsRepuestoUtilizado> repuestosUtilizados = clsRepuestoUtilizado.Listar();
            string msg = string.Empty;
            try
            {
                //para actualizar a posterior el stock
                clsRepuestoUtilizado repEliminado = clsRepuestoUtilizado.Buscar(id);
                using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                {
                    foreach (clsRepuestoUtilizado repuesto in repuestosUtilizados)
                    {
                        if (repuesto.Id == id) { continue; }
                        bw.Write(repuesto.Id);
                        bw.Write(repuesto.Codigo);
                        bw.Write(repuesto.Descripcion);
                        bw.Write(repuesto.PrecioCompra);
                        bw.Write(repuesto.precioVenta);
                        bw.Write(repuesto.cantidad);
                        bw.Write(repuesto.IdReparacion);
                    }
                }
                //Busco el repuesto utilizado a eliminar y lo utilizo para actualizar el stock del inventario
                
                clsRepuesto rep = clsRepuesto.Buscar(repEliminado.Codigo);
                rep.Stock += repEliminado.Cantidad;
                rep.Actualizar();
                
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error. " + ex.Message;
            }
            return msg;
        }
        //Buscar repuestos por idReparacion
        public static List<clsRepuestoUtilizado> BuscarTodos(int idReparacion)
        {
            return clsRepuestoUtilizado.Listar().FindAll(x => x.IdReparacion == idReparacion);
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
