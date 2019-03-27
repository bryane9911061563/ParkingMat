using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Vehiculo_BO
    {
        private String placas;
        private int id_cliente, id_cajon, id_tipo;

        public string Placas { get => placas; set => placas = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_cajon { get => id_cajon; set => id_cajon = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
    }
}
