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

        public int Guardar_Datos(Cajones_BO obj_div)
        {
            Cajones_BO datos = (Cajones_BO)obj_div;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Insert into cajones (id_sucursal,Hora_inicio,Hora_final,Lugar,id_tipo_vehiculo,id_estado_cajon) values ('" + datos.Id_sucursal + "','" + datos.Hora_inicio1 + "','00:00','" +datos.Lugar1 + "','" + datos.Tipo_vehiculo + "',1)";
            cmd.CommandText = instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }
        public int Actualizar_Datos(Cajones_BO ObjEmp)
        {
            Cajones_BO datos = (Cajones_BO)ObjEmp;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            //modif access to BD
            instruccion_SQL = "Update  cajones set Hora_final= '" + datos.Hora_final1 + "',id_estado_cajon='2'  where id_sucursal ='" + datos.Id_sucursal + "' and Lugar = "+datos.Lugar1+ " and matricula = "+datos.Matricula1+"";
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



        public ArrayList info_Cajones(int id)
        {
            instruccion_SQL = "SELECT cajones.*, estados_cajones.*,tipos_vehiculos.* FROM cajones,estados_cajones,tipos_vehiculos WHERE cajones.id_estado_cajon = estados_cajones.id_estado_cajon and tipos_vehiculos.id_tipo_vehiculo = cajones.id_tipo_vehiculo and cajones.id_sucursal = " + id+" GROUP BY cajones.id_cajon";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            ArrayList cajas = new ArrayList();
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                String auxiliar =leer["estado"].ToString();
                auxiliar = auxiliar + "|" + leer["tipo_vehiculo"].ToString();
                auxiliar = auxiliar + "|" + leer["Hora_inicio"].ToString();
                auxiliar = auxiliar + "|" + leer["Hora_final"].ToString();
                auxiliar = auxiliar + "|" + leer["Lugar"].ToString();
                cajas.Add(auxiliar);
            }
            obj_conec.CerrarBD();
            return cajas;
        }
    }
}