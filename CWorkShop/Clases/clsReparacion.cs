using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    public class clsReparacion
    {
        private const string ARCHIVO = "reparaciones.dat";
        private const string DIR = "..\\Datos\\";
        private int id;
        private string fechaIngreso;
        private string fechaEntrega;
        private bool anulada;
        private string accesorios;
        private string diagnostico;
        private double costoManoObra;
        private int idEquipo;
        private int idTecnico;
        private string estado;

        public clsReparacion(string accesorios, string diagnostico, double costoManoObra, int idEquipo, int idTecnico, string estado, string fechaIngreso, string fechaEntrega, bool anulada = false, int id = 0)
        {
            this.id = id;
            this.anulada = anulada;
            this.accesorios = accesorios;
            this.diagnostico = diagnostico;
            this.costoManoObra = costoManoObra;
            this.idEquipo = idEquipo;
            this.idTecnico = idTecnico;
            this.estado = estado;
            this.fechaIngreso = fechaIngreso;
            this.fechaEntrega = fechaEntrega;
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

        public string FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }
            set
            {
                fechaIngreso = value;
            }
        }

        public string FechaEntrega
        {
            get
            {
                return fechaEntrega;
            }
            set
            {
                fechaEntrega = value;
            }
        }

        public bool Anulada
        {
            get
            {
                return anulada;
            }

            set
            {
                anulada = value;
            }
        }

        public string Accesorios
        {
            get
            {
                return accesorios;
            }

            set
            {
                accesorios = value;
            }
        }

        public string Diagnostico
        {
            get
            {
                return diagnostico;
            }

            set
            {
                diagnostico = value;
            }
        }

        public double CostoManoObra
        {
            get
            {
                return costoManoObra;
            }

            set
            {
                costoManoObra = value;
            }
        }

        public int IdEquipo
        {
            get
            {
                return idEquipo;
            }

            set
            {
                idEquipo = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int IdTecnico
        {
            get
            {
                return idTecnico;
            }

            set
            {
                idTecnico = value;
            }
        }

        //Cliente al cual le corresponde la reparacion
        public clsCliente Cliente
        {
            get
            {
                clsCliente cliente=clsCliente.Buscar(this.Equipo.IdCliente);
                return cliente;
            }
        }
        //Equipo al cual le corresponde la reparacion
        public clsEquipo Equipo
        {
            get
            {
                return clsEquipo.Buscar(this.IdEquipo);
            }
        }
        //Tecnico encargado de la reparacion
        public clsUsuario Tecnico
        {
            get
            {
                return clsUsuario.Buscar(this.IdTecnico);
            }
        }
        //Lista de repuestos utilizados en la reparacion
        public List<clsRepuestoUtilizado> Repuestos
        {
            get
            {
                List<clsRepuestoUtilizado> res= clsRepuestoUtilizado.Listar().FindAll(x => x.IdReparacion == this.id);
                return res;
            }
        }
        //Calcula costo total de la reparacion
        public double CostoTotal
        {
            get
            {
                double total = 0;
                if (this.Repuestos.Count > 0)
                {
                    foreach (clsRepuestoUtilizado x in this.Repuestos)
                    {
                        total += x.PrecioVenta;
                    }
                }
                total += this.CostoManoObra;
                return total;
            }
        }

        //Listar reparaciones
        public static List<clsReparacion> Listar()
        {
            CheckFiles();
            clsReparacion aux;
            List<clsReparacion> reparacion = new List<clsReparacion>();
            int auxid;
            try
            {
                using (BinaryReader br = new BinaryReader(new FileStream(DIR + ARCHIVO, FileMode.Open)))
                {
                    while (br.PeekChar() != -1)
                    {
                        auxid = br.ReadInt32();
                        aux = new clsReparacion(br.ReadString(), br.ReadString(), br.ReadDouble(), br.ReadInt32(), br.ReadInt32(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadBoolean(), auxid);
                        reparacion.Add(aux);
                    }
                }
                return reparacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrio un error. " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return reparacion;
            }
        }
        //Actualizar reparacion
        public string Actualizar()
        {
            string msg = string.Empty;
            CheckFiles();
            try
            {
                List<clsReparacion> reparaciones = clsReparacion.Listar();
                int old = reparaciones.FindIndex(x => x.Id == this.Id);
                reparaciones[old] = this;
                using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                {
                    foreach (clsReparacion x in reparaciones)
                    {
                        bw.Write(x.Id);
                        bw.Write(x.Accesorios);
                        bw.Write(x.Diagnostico);
                        bw.Write(x.CostoManoObra);
                        bw.Write(x.IdEquipo);
                        bw.Write(x.IdTecnico);
                        bw.Write(x.Estado);
                        bw.Write(x.FechaIngreso);
                        bw.Write(x.FechaEntrega);
                        bw.Write(x.Anulada);
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "Ha ocurrio un error. " + ex.Message;
            }
            return msg;
        }
        //Guardar reparacion
        public string Guardar()
        {
            CheckFiles();
            int idAux = ObtenerId();
            string msg = string.Empty;
            try
            {   //si el equipo ya posee una reparacion sin concluir 
                msg = (clsReparacion.Listar().Find(x => x.IdEquipo == this.IdEquipo && (this.Estado != "ENTREGADO" && x.Anulada)) != null) ? "Este equipo ya posee una reparación sin concluir." : string.Empty;
                if (msg.Equals(string.Empty))
                {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Append)))
                    {
                        bw.Write(idAux);
                        bw.Write(this.Accesorios);
                        bw.Write(this.Diagnostico);
                        bw.Write(this.CostoManoObra);
                        bw.Write(this.IdEquipo);
                        bw.Write(this.IdTecnico);
                        bw.Write(this.Estado);
                        bw.Write(this.FechaIngreso);
                        bw.Write(string.Empty);
                        bw.Write(this.Anulada);
                    }
                    msg = idAux.ToString();
                }
            }
            catch (Exception ex)
            {
                msg = "Error interno. " + ex.Message;
            }
            return msg;
        }
        //Eliminar reparacion
        public static string Eliminar(int id)
        {
            string msg = string.Empty;
            CheckFiles();
            List<clsReparacion> reparaciones = clsReparacion.Listar();
            try
            {
                using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Create)))
                {
                    foreach (clsReparacion reparacion in reparaciones)
                    {
                        if (reparacion.Id == id) { reparacion.Anulada = !reparacion.Anulada; }
                        bw.Write(reparacion.Id);
                        bw.Write(reparacion.Accesorios);
                        bw.Write(reparacion.Diagnostico);
                        bw.Write(reparacion.CostoManoObra);
                        bw.Write(reparacion.IdEquipo);
                        bw.Write(reparacion.IdTecnico);
                        bw.Write(reparacion.Estado);
                        bw.Write(reparacion.FechaIngreso);
                        bw.Write(reparacion.FechaEntrega);
                        bw.Write(reparacion.Anulada);
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error. " + ex.Message;
            }

        }
        //Buscar reparacion por id
        public static clsReparacion Buscar(int idBuscar)
        {
            clsReparacion res= clsReparacion.Listar().Find(x => x.Id == idBuscar);
            return res;
        }
        //Obtener id siguiente
        private static int ObtenerId()
        {
            List<clsReparacion> lista = clsReparacion.Listar();
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
