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
    class Vehiculos_DAO
    {
        //Coso para usar sus propiedades 
        Conexion_DAO obj_conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        //Coso para ejecutar instrucciones
        string instruccion_SQL;

        public int Guardar_Datos(Vehiculo_BO obj_div)
        {
            Vehiculo_BO datos = (Vehiculo_BO)obj_div;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Insert into vehiculos (Placas,Modelo,Color,id_Cliente,id_Cajon,id_Tipo) values ('" + datos.Placas + "','notyet','none',"+datos.Id_cliente+"," +datos.Id_cajon + "," + datos.Id_tipo +")";
            cmd.CommandText = instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }
        public int Actualizar_Datos(Vehiculo_BO ObjEmp)
        {
            Vehiculo_BO datos = (Vehiculo_BO)ObjEmp;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            //modif access to BD
            instruccion_SQL = "Update  vehiculos set id_Cliente= '" + datos.Id_cliente +" where id_sucursal ='" + datos.Id_cajon + "";
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

        public ArrayList lista_tipos()
        {
            instruccion_SQL = "Select tipo_vehiculo from tipos_vehiculos";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            ArrayList lisDivision = new ArrayList();
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                lisDivision.Add(leer["tipo_vehiculo"].ToString());
            }
            obj_conec.CerrarBD();
            return lisDivision;
        }

        public String hora_inicio(int sucursal,int cajon)
        {
            instruccion_SQL = "Select Hora_inicio from cajones where id_sucursal = "+sucursal+" and Lugar = "+cajon+" and id_estado_cajon = 1";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            String hora = "";
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                hora = leer["Hora_inicio"].ToString();
            }
            obj_conec.CerrarBD();
            return hora;
        }

       /* public int asignar_tipo(String tipo)
        {
            instruccion_SQL = "Select tipo_vehiculo from tipos_vehiculos where id_tipo_vehiculo = " + sucursal + " and Lugar = " + cajon + " and id_estado_cajon = 1";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            String hora = "";
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                hora = leer["Hora_inicio"].ToString();
            }
            obj_conec.CerrarBD();
            return hora;
        }*/

        public String matricula (int sucursal, int cajon)
        {
            instruccion_SQL = "Select matricula from cajones where id_sucursal = " + sucursal + " and Lugar = " + cajon + " and id_estado_cajon = 1";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            String hora = "";
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                hora = leer["matricula"].ToString();
            }
            obj_conec.CerrarBD();
            return hora;
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
    }
}