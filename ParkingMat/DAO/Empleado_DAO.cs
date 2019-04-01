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
            //instruccion_SQL = "select empleados.Nombre_Empleado,empleados.Apellido_1_Empleado,empleados.Apellido_2_Empleado,empleados.id_Empleado,empleados.Fecha_Nacimiento,empleados.id_puesto,empleados.Salario_Base,empleados.Correo_Electronico,empleados.Clave_Sesion,empleados.Horario,empleados.Horario,empleados.id_Sucursal from empleados inner join sucursales on empleados.id_Sucursal=sucursales.id_Sucursal INNER JOIN tipo_puesto ON empleados.id_puesto=tipo_puesto.id_puesto WHERE sucursales.id_Sucursal='"+Cls_Static_UsuarioRunningThisMoment.id_Sucursal+"' ";
            instruccion_SQL = "Select empleados.* from empleados where id_Sucursal ="+Cls_Static_UsuarioRunningThisMoment.id_Sucursal;
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_pen = new DataTable();
            adp.Fill(virtual_pen);

            return (virtual_pen);
        }


        public int Guardar_Datos(Empleado_BO obj_div)
        {
            Empleado_BO datos = (Empleado_BO)obj_div;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Insert into empleados (Nombre_Empleado,Apellido_1_Empleado,Apellido_2_Empleado,Fecha_Nacimiento,id_puesto,Salario_Base,Correo_Electronico,Clave_Sesion,Horario,id_Sucursal,imagen) values ('" + datos.Nombre + "','" + datos.Apellido_11 + "','" +datos.Apellido_21 + "','" +datos.Fecha_nacimiento + "','" + datos.Puesto + "','"+datos.Salario_Base+"','" +datos.Correo_Electronico1 + "','" +datos.Clave_Sesion1 + "','" +datos.Horario_Trabajo1 + "','" +Cls_Static_UsuarioRunningThisMoment.id_Sucursal+"','"+datos.Imagen+"')";
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
            String instruccion_SQL2 = "Update  empleados set Nombre_Empleado= '" + datos.Nombre + "',Apellido_1_Empleado='"+datos.Apellido_11+"',Apellido_2_Empleado='"+datos.Apellido_21+ "',Fecha_Nacimiento='"+datos.Fecha_nacimiento+ "',id_puesto='"+datos.Puesto+ "',Salario_Base="+datos.Salario_Base+ ",Correo_Electronico='"+datos.Correo_Electronico1+ "',Clave_Sesion='"+datos.Clave_Sesion1+ "',Horario='"+datos.Horario_Trabajo1+ "',id_Sucursal="+datos.Id_sucursal+ ", imagen = '"+datos.Imagen+"'  where id_Empleado = "+ datos.Id_Empleado;
            //exe cmd
            cmd.CommandText = instruccion_SQL2;
            //gdr vlr
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();


            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public String imagen_empleado(int id)
        {
            instruccion_SQL = "SELECT imagen FROM empleados where id_Empleado = "+id.ToString();
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            string x = "";
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                x = leer["imagen"].ToString();
            }
            obj_conec.CerrarBD();
            return x;
        }

        public int Iniciar_Sesion (String Correo, String Contraseña)
        {
            instruccion_SQL = "Select id_Sucursal from empleados where Correo_Electronico = '" + Correo + "' and Clave_Sesion = '" + Contraseña + "'";
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
        public DataTable Capturar_ID_sucursal(String corre, String contraseña)
        {
            instruccion_SQL = "Select id_Sucursal from empleados where Correo_Electronico='" + corre + "' and Clave Sesion='" + contraseña + "'";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_Suc = new DataTable();
            adp.Fill(virtual_Suc);

            return (virtual_Suc);
        }
    }
    
}