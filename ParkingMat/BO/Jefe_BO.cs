using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Jefe_BO
    {

        private String nombre = "bryanedilberto@hotmail.com";
        private String clave = "parkingmat";

        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}