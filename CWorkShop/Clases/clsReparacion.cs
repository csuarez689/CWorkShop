using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWorkShop.Clases
{
    class clsReparacion
    {
        private int idEquipo;

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

        public static List<clsReparacion> Listar()
        {
            return new List<clsReparacion>();
        }
    }
}
