using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ParkingMat.BO;

namespace ParkingMat.DAO
{
    class Empleado_DAO
    {
        //Coso para usar sus propiedades 
        Conexion_DAO obj_conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        //Coso para ejecutar instrucciones
        string instruccion_SQL;

        public int Guardar_Datos(Empleado_BO obj_div)
        {

            //Asegurar que esta clase voy a trabajar :v
            Empleado_BO datos = (Empleado_BO)obj_div;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();

            //La wea de INSERT se modifica y queda tu programa papu
            instruccion_SQL = "Insert into division (nombre_div) values ('" + datos.Nombre + "')";

            //Ejecuten comandos 
            cmd.CommandText = instruccion_SQL;

            //Guardar el valor 
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }

    }
}