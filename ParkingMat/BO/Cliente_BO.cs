using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Cliente_BO
    {
        private int id_cliente;
        private string nombre;
        private string apellido_m;
        private string apellido_p;
        private int id_sucursal;


        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_m { get => apellido_m; set => apellido_m = value; }
        public string Apellido_p { get => apellido_p; set => apellido_p = value; }
        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
    }
}
