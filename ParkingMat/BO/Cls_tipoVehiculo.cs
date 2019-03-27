using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Cls_tipoVehiculo
    {
        private int id_tipo_vehiculo;
        private string tipo_vehiculo;

        public int Id_tipo_vehiculo { get => id_tipo_vehiculo; set => id_tipo_vehiculo = value; }
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
    }
}
