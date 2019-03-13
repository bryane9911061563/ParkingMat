using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Recibo_BO
    {
        private int folio;
        DateTime fecha_reg;
        private int precio;
        private string tipo;
        private int id_cliente;
        private int id_sucursal;



        public int Folio { get => folio; set => folio = value; }
        public DateTime Fecha_reg { get => fecha_reg; set => fecha_reg = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
    }
}
