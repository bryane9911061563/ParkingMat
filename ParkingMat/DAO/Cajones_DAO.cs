using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ParkingMat.BO;

namespace ParkingMat.DAO
{
    class Cajones_DAO
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

        public int Cajones_por_Sucursal(int id)
        {
            instruccion_SQL = "Select Cantidad_Cajones from sucursales where id_Sucursal = '"+id.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            int match=0;
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                match = int.Parse(leer["Cantidad_Cajones"].ToString());
            }
            obj_conec.CerrarBD();
            if (match >0)
            {
                return match;
            }
            else
            {
                return 0;
            }
        }

        public ArrayList info_Cajones(int id)
        {
            instruccion_SQL = "Select * from cajones where id_sucursal = '" + id.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            ArrayList cajas = new ArrayList();
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                String auxiliar =leer["estado_cajon"].ToString() + "|";
                auxiliar = auxiliar + "|" + leer["tipo_vehiculo"].ToString() + "|";
                auxiliar = auxiliar + "|" + leer["Hora_inicio"].ToString() + "|";
                auxiliar = auxiliar + "|" + leer["Lugar"].ToString() + "|";
                cajas.Add(auxiliar);
            }
            obj_conec.CerrarBD();
            return cajas;
        }
    }
}