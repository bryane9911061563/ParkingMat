using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class CLs_TIempoActual
    {
        private string Hora;


        public string HoraActualTimer()
        {
            Hora = DateTime.Now.ToLongTimeString();
            return Hora;
        }
    }
}
