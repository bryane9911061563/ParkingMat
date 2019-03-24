using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ParkingMat.BO;
using System.Data;

namespace ParkingMat.DAO
{
    class Empleado_DAO
    {
        string instruccion_SQL;

        //Coso para usar sus propiedades 
        Conexion_DAO obj_conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        //Mostrar empleados
        public DataTable tabla_empleado()
        {
            instruccion_SQL = "SELECT id_Empleado,Nombre_Empleado,Apellido_1_Empleado,Apellido_2_Empleado,Fecha_Nacimiento,Puesto,Salario_Base,Correo_Electronico,Clave_Sesion,Horario, Nombre_Sucursal from empleados INNER JOIN sucursales ON empleados.id_Sucursal=sucursales.id_Sucursal";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_pen = new DataTable();
            adp.Fill(virtual_pen);

            return (virtual_pen);
        }

        //Coso para ejecutar instrucciones

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
        public int Eliminar_Datos(Empleado_BO ObjEmp)
        {
            Empleado_BO datos = (Empleado_BO)ObjEmp;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            //modif access to BD
            instruccion_SQL = "Delete  from empleados  where id_Empleado='" + datos.Id_Empleado + "'";
            //exe cmd
            cmd.CommandText = instruccion_SQL;
            //gdr vlr
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();


            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int Actualizar_Datos(Empleado_BO ObjEmp)
        {
            Empleado_BO datos = (Empleado_BO)ObjEmp;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            //modif access to BD
            instruccion_SQL = "Update  empleados set Nombre_Empleado= '" + datos.Nombre + "',Apellido_1_Empleado='"+datos.Apellido_11+"',Apellido_2_Empleado='"+datos.Apellido_21+ "',Fecha_Nacimiento='"+datos.Fecha_nacimiento+ "',Puesto='"+datos.Puesto+ "',Salario_Base='"+datos.Salario_Base+ "',Correo_Electronico='"+datos.Correo_Electronico1+ "',Clave_Sesion='"+datos.Clave_Sesion1+ "',Horario='"+datos.Horario_Trabajo1+ "',id_Sucursal='"+datos.Id_sucursal+ "'  where id_Empleado='" + datos.Id_Empleado + "'";
            //exe cmd
            cmd.CommandText = instruccion_SQL;
            //gdr vlr
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
        public DataTable Capturar_ID_sucursal(String corre, String contraseņa)
        {
            instruccion_SQL = "Select id_Sucursal from empleados where Correo_Electronico='" + corre + "' and Clave Sesion='" + contraseņa + "'";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_Suc = new DataTable();
            adp.Fill(virtual_Suc);

            return (virtual_Suc);
        }
    }
    
}