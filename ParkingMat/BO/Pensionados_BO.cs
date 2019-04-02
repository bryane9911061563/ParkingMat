using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Pensionados_BO
    {
        private int id_pensionado;
        private string nombre_pensionado;
        private string apellido_p_pensionado;
        private string apellido_m_pensionado;
        private string fecha_nac_pensionado;
        private string fecha_registro_pensionado;
        private string fecha_vencimiento_pensionado;
        private string num_telefono_pensionado;
        private string correo_pensionado;


        public int Id_pensionado { get => id_pensionado; set => id_pensionado = value; }
        public string Nombre_pensionado { get => nombre_pensionado; set => nombre_pensionado = value; }
        public string Apellido_p_pensionado { get => apellido_p_pensionado; set => apellido_p_pensionado = value; }
        public string Apellido_m_pensionado { get => apellido_m_pensionado; set => apellido_m_pensionado = value; }
        public string Fecha_nac_pensionado { get => fecha_nac_pensionado; set => fecha_nac_pensionado = value; }
        public string Fecha_registro_pensionado { get => fecha_registro_pensionado; set => fecha_registro_pensionado = value; }
        public string Fecha_vencimiento_pensionado { get => fecha_vencimiento_pensionado; set => fecha_vencimiento_pensionado = value; }
        public string Num_telefono_pensionado { get => num_telefono_pensionado; set => num_telefono_pensionado = value; }
        public string Correo_pensionado { get => correo_pensionado; set => correo_pensionado = value; }
    }
}
