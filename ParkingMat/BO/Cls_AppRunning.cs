using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Cls_AppRunning
    {
        private int AppExecut;
        private string ruta;

        public int AppExecut1 { get => AppExecut; set => AppExecut = value; }

        public string CambiaFoto()
        {
            switch(AppExecut)
            {
                case 1:
                    ruta = "Museum_75px.png";
                    break;
                case 2:
                    ruta = "User Location_75px.png";
                    break;
                case 3:
                    ruta = "Carpark_75px.png";
                    break;
                case 4:
                    ruta = "Train Ticket_75px.png";
                    break;
                case 5:
                    ruta = "Test Passed_75px.png";
                    break;
            }
            return ruta;
        }

    }
}
