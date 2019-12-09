using CWorkShop.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWorkShop.Vistas
{
    public partial class frmRepuestos : Form
    {
        public frmRepuestos()
        {
            InitializeComponent();
        }





        //private string Validar()
        //{
        //    Regex nameApellido = new Regex(@"^[a-zA-Z]+(([a-zA-Z ])?[a-zA-Z]*)*$");
        //    Regex dni = new Regex(@"^\d{8}(?:[-\s]\d{4})?$");
        //    Regex mail = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
        //    Regex telefono = new Regex(@"^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$");
        //    Regex contraseña = new Regex(@"^(?=\w*\d)(?=\w*[a-z])\S{5,16}$");
        //    if (!dni.IsMatch(tbDni.Text)) { return "Campo dni incorrecto.  Ingrese solo numeros.346"; }
        //    if (!nameApellido.IsMatch(tbNombre.Text)) { return "Campo nombre incorrecto."; }
        //    if (!nameApellido.IsMatch(tbApellido.Text)) { return "Campo apellido incorrecto."; }
        //    if (!mail.IsMatch(tbCorreo.Text)) { return "Campo correo incorrecto."; }
        //    if (!telefono.IsMatch(tbTelefono.Text)) { return "Campo telefono incorrecto."; }
        //    if (userLog.Contraseña == string.Empty || (tbContraseña.Text != string.Empty && tbConfirmar.Text != string.Empty))
        //    {
        //        if (!contraseña.IsMatch(tbContraseña.Text)) { return "Campo contraseña incorrecto. La contraseña debe ser alfanumerica, entre 5 y 16 caracteres."; }
        //    }
        //    if (!tbContraseña.Text.Equals(tbConfirmar.Text)) { return "Las contraseñas no coinciden."; }
        //    return string.Empty;
        //}


    }
}
