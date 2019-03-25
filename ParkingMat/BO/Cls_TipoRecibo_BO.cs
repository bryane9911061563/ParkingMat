using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Cls_TipoRecibo_BO
    {
        private int id_tipRecibo;
        private string nombre_tipRecibo;

        public int Id_tipRecibo { get => id_tipRecibo; set => id_tipRecibo = value; }
        public string Nombre_tipRecibo { get => nombre_tipRecibo; set => nombre_tipRecibo = value; }
    }
}
