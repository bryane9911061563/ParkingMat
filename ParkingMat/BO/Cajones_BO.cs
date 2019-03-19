using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Cajones_BO
    {
        private String estado_cajon, tipo_vehiculo, Hora_inicio, Hora_final;
        private int id_sucursal, Lugar;

        public string Estado_cajon { get => estado_cajon; set => estado_cajon = value; }
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
        public string Hora_inicio1 { get => Hora_inicio; set => Hora_inicio = value; }
        public string Hora_final1 { get => Hora_final; set => Hora_final = value; }
        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
        public int Lugar1 { get => Lugar; set => Lugar = value; }
    }
}
