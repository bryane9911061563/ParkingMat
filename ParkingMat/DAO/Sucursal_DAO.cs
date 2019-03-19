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
    class Sucursal_DAO
    {
        //Coso para usar sus propiedades 
        Conexion_DAO obj_conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        //Coso para ejecutar instrucciones
        string instruccion_SQL;

        public int Guardar_Datos(Sucursal_BO obj_div)
        {
            Sucursal_BO datos = (Sucursal_BO)obj_div;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Insert into sucursales (Nombre_Sucursal,Direccion_Sucursal,Horario_Apertura,Horario_Cierre,Numero_Telefonico,Cantidad_Cajones) values ('" + datos.Nombre+"','"+datos.Direccion +"','"+datos.Horario_apaertura+ "','"+datos.Horario_cierre+"','"+datos.Numerotelefonico+"','"+datos.Cantidad_Cajones+"')";
            cmd.CommandText = instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }

        public ArrayList lista_Sucursales()
        {                 
            instruccion_SQL = "Select Nombre_Sucursal from sucursales";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            ArrayList lisDivision = new ArrayList();
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                lisDivision.Add(leer["Nombre_Sucursal"].ToString());
            }
            obj_conec.CerrarBD();
            return lisDivision;
        }


        public int Asignar_Sucursal(String sucursal)
        {
            instruccion_SQL = "Select id_Sucursal from sucursales where Nombre_Sucursal = '" + sucursal + "'";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            int id = 0;
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                id = int.Parse(leer["id_Sucursal"].ToString());
            }
            obj_conec.CerrarBD();
            return id;
        }

    }
}