using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Cls_PuestoEmpleado_BO
    {
        private int id_puestoempleado;
        private string nombre_puestoempleado;

        public int Id_puestoempleado { get => id_puestoempleado; set => id_puestoempleado = value; }
        public string Nombre_puestoempleado { get => nombre_puestoempleado; set => nombre_puestoempleado = value; }
    }
}
