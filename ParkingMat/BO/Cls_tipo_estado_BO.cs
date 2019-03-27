using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Cls_tipo_estado_BO
    {
        private int id_estado_cajon;
        private string estado;

        public int Id_estado_cajon { get => id_estado_cajon; set => id_estado_cajon = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
