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
    class Cls_ADMIN_DAO
    {
        string Instruccion_SQL;
        Conexion_DAO obj_conec = new Conexion_DAO();

        public string num_Empleados()
        {
            string NumeroEmpleados;
            Instruccion_SQL = "SELECT COUNT(*) FROM empleados";
            MySqlDataAdapter adp = new MySqlDataAdapter(Instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_numEmpleado = new DataTable();
            adp.Fill(virtual_numEmpleado);
            NumeroEmpleados = virtual_numEmpleado.ToString();

            return NumeroEmpleados;
            
        }
    }
}
