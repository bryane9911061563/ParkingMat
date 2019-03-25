using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Reporte_BO
    {
        private int id_reporte;
        private DateTime fecha_creacion;
        private String fecha_comprendida, descripcion;

        public int Id_reporte { get => id_reporte; set => id_reporte = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Fecha_comprendida { get => fecha_comprendida; set => fecha_comprendida = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
