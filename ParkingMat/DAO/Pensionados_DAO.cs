using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ParkingMat.BO;

namespace ParkingMat.DAO
{
    class Pensionados_DAO
    {
        string instruccion_SQL;

        Conexion_DAO obj_conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        //Mostrar pensionados
        public DataTable Mostrar_pensionados()
        {
            instruccion_SQL = "SELECT * FROM Pensionados";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_div = new DataTable();
            adp.Fill(virtual_div);

            return (virtual_div);
        }

        //Guardar pensionado
        public int Guardar_pensionado(Pensionados_BO objPen)
        {
            Pensionados_BO datos = (Pensionados_BO)objPen;
            instruccion_SQL = string.Format("Insert into alumno (nombre,apellido_p,apellido_m,fecha_nac,fecha_registro,fecha_venimiento,telfono,correo)values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}')", objPen.Nombre_pensionado, objPen.Apellido_p_pensionado, objPen.Apellido_m_pensionado, objPen.Fecha_nac_pensionado.ToString("dd/MM/yyyy HH:mm:ss"), objPen.Fecha_registro_pensionado.ToString("dd/MM/yyyy HH:mm:ss"), objPen.Fecha_vencimiento_pensionado.ToString("dd/MM/yyyy HH:mm:ss"), objPen.Num_telefono_pensionado,objPen.Correo_pensionado);
            return obj_conec.EjecutarSQL(instruccion_SQL);
        }
    }
}
