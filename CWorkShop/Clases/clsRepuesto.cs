﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Clases
{
    class clsRepuesto
    {
        private const string ARCHIVO = "repuestos.dat";
        private const string DIR = "..\\Datos\\";
        private int id;
        private string codigo;
        private string descripcion;
        private float precio;

        public clsRepuesto(string codigo, string descripcion, double precio, int id=0)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
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
                        aux = new clsRepuesto(br.ReadString(), br.ReadString(), br.ReadDouble());
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
                if (clsRepuesto.Listar().Find(x => x.Codigo == this.Codigo) == null)
                {//si no existe un repuesto con el mismo numero de codigo
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DIR + ARCHIVO, FileMode.Append)))
                    {
                        bw.Write(idAux);
                        bw.Write(this.Codigo);
                        bw.Write(this.Descripcion);
                        bw.Write(this.Precio);
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
                            bw.Write(x.Precio);
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
        //Eliminar cliente
        public static string Eliminar(int id)
        {
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
