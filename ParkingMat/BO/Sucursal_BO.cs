using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Sucursal_BO
    {
        private String nombre = "", direccion, horario_apaertura, horario_cierre;
        private int cantidad_Cajones;
        private String numerotelefonico;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Horario_apaertura { get => horario_apaertura; set => horario_apaertura = value; }
        public string Horario_cierre { get => horario_cierre; set => horario_cierre = value; }
        public String Numerotelefonico { get => numerotelefonico; set => numerotelefonico = value; }
        public int Cantidad_Cajones { get => cantidad_Cajones; set => cantidad_Cajones = value; }
    }
}