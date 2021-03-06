using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ParkingMat.BO;
using System.Windows.Forms;

namespace ParkingMat.DAO
{
    class Sucursal_DAO
    {
        //Coso para usar sus propiedades 
        Conexion_DAO obj_conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        //Coso para ejecutar instrucciones
        string instruccion_SQL;

        public DataTable MostrarSucursales()
        {
            instruccion_SQL = "Select id_Scurusal from sucursales";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_Sucursal = new DataTable();
            
            adp.Fill(virtual_Sucursal);

            return (virtual_Sucursal);
        }

        public DataTable tabla_sucursales()
        {
            

            instruccion_SQL = "SELECT id_Sucursal,Nombre_Sucursal,Direccion_Sucursal,Horario_Apertura,Horario_Cierre FROM sucursales where id_Sucursal > 0";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                //MessageBox.Show((leer["Nombre_Sucursal"]).ToString());
            }
            DataTable virtual_pen = new DataTable();
            
            adp.Fill(virtual_pen);
            obj_conec.CerrarBD();
            return (virtual_pen);
        }

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

        public ArrayList lista_Puestos()
        {
            instruccion_SQL = "Select Puesto from tipo_puesto";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            ArrayList lisDivision = new ArrayList();
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                lisDivision.Add(leer["Puesto"].ToString());
            }
            obj_conec.CerrarBD();
            return lisDivision;
        }

        public int Asignar_Sucursal(String sucursal)
        {
            instruccion_SQL = "Select id_Sucursal from sucursales where Nombre_Sucursal = '"+sucursal+"'";
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
        public int Asignar_Puesto(String puesto)
        {
            instruccion_SQL = "Select id_puesto from tipo_puesto where Puesto = '" + puesto + "'";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            int id = 0;
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                id = int.Parse(leer["id_puesto"].ToString());
            }
            obj_conec.CerrarBD();
            return id;
        }

        public string Mostrar_nombre_sucursal_seleccionada()
        {
            instruccion_SQL = "Select Nombre_Sucursal from sucursales where id_Sucursal='"+Cls_Static_UsuarioRunningThisMoment.id_Sucursal+"'";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            string nombre="";
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                nombre = (leer["Nombre_Sucursal"]).ToString();
            }
            obj_conec.CerrarBD();
            return nombre;
        }


    }
}