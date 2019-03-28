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
            instruccion_SQL = "SELECT * FROM pensionados";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_div = new DataTable();
            adp.Fill(virtual_div);

            return (virtual_div);
        }

        //Guardar pensionado
        public int Guardar_pensionado(Pensionados_BO objPen)
        {
            Pensionados_BO datos = (Pensionados_BO)objPen;
            instruccion_SQL = string.Format("Insert into pensionados (nombre,apellido_p,apellido_m,fecha_nac,fecha_registro,fecha_vencimiento,telfono,correo)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", objPen.Nombre_pensionado, objPen.Apellido_p_pensionado, objPen.Apellido_m_pensionado, objPen.Fecha_nac_pensionado.ToString("yyyy/mm/dd"), objPen.Fecha_registro_pensionado.ToString("yyyy/mm/dd"), objPen.Fecha_vencimiento_pensionado.ToString("yyyy/mm/dd"), objPen.Num_telefono_pensionado,objPen.Correo_pensionado);
            return obj_conec.EjecutarSQL(instruccion_SQL);
        }

        public int ultimo_agregado()
        {
            instruccion_SQL = "SELECT MAX(id_pensionado) AS Expr1 FROM pensionados";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            int x=0;
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                x = int.Parse(leer["Expr1"].ToString());
            }
            obj_conec.CerrarBD();
            return x;
        }

        

    }
}
