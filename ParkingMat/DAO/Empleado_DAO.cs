using System;
using System.Collections;
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
            Empleado_BO datos = (Empleado_BO)obj_div;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Insert into empleados (Nombre_Empleado,Apellido_1_Empleado,Apellido_2_Empleado,Fecha_Nacimiento,Puesto,Salario_Base,Correo_Electronico,Clave_Sesion,Horario,id_Sucursal) values ('" + datos.Nombre + "','" + datos.Apellido_11 + "','" +datos.Apellido_21 + "','" +datos.Fecha_nacimiento + "','" + datos.Puesto + "','"+datos.Salario_Base+"','" +datos.Correo_Electronico1 + "','" +datos.Clave_Sesion1 + "','" +datos.Horario_Trabajo1 + "','" +datos.Id_sucursal+"')";
            cmd.CommandText = instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }


        public int Iniciar_Sesion (String Correo, String Contraseņa)
        {
            instruccion_SQL = "Select id_Sucursal from empleados where Correo_Electronico = '" + Correo + "' and Clave_Sesion = '" + Contraseņa + "'";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            int match = -1;
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                match = int.Parse(leer["id_Sucursal"].ToString());
            }
            obj_conec.CerrarBD();
            if (match>0)
            {
                return match;
            }
            else
            {
                return -1;
            }
        }
    }
}