using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Recibo_BO
    {
        private int id_recibo;
        private string motivo;
        private string descripcion;
        private int id_tipo;
        private int id_sucu;
        private DateTime fecha_creacion;
        private decimal costo;

        public int Id_recibo { get => id_recibo; set => id_recibo = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int Id_sucu { get => id_sucu; set => id_sucu = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public decimal Costo { get => costo; set => costo = value; }
    }
}
