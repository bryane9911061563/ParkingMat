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
    class Reporte_DAO
    {
        //Coso para usar sus propiedades 
        Conexion_DAO obj_conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        //Coso para ejecutar instrucciones
        string instruccion_SQL;

        public int Guardar_Datos(Reporte_BO obj_div)
        {
            Reporte_BO datos = (Reporte_BO)obj_div;

            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Insert into reporte (Fecha_Creacion,Fecha_Comprendida,descripcion) values ('" + DateTime.Today.ToString("dd/mm/yyyy") + "','en progreso','"+datos.Descripcion+"')";
            cmd.CommandText = instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }
    
    


        public String Optener_informacion_reporte(int sucursal, int empleado)
        {
            String auxiliar="";

            instruccion_SQL = "SELECT Nombre_Sucursal FROM sucursales WHERE id_Sucursal = " + sucursal + "";
            MySqlCommand cmd = new MySqlCommand(instruccion_SQL, obj_conec.ConectarBD());
            obj_conec.AbrirBD();
            MySqlDataReader leer;
            leer = cmd.ExecuteReader();

            while (leer.Read())
            {
                auxiliar = " El emplado en truno: " + leer["Nombre_Sucursal"].ToString()+"\n";
            }

            instruccion_SQL = "SELECT * FROM empleados WHERE id_Empleado = "+ empleado+ " and id_Sucursal = "+sucursal;
            obj_conec.AbrirBD();
            leer = cmd.ExecuteReader();
           
            while (leer.Read())
            {
                auxiliar =" El emplado en truno: "+leer["Nombre_Empleado"].ToString() +" "+ leer["Apellido_1_Empleado"].ToString() + " " + leer["Apellido_2_Empleado"].ToString();
                auxiliar = auxiliar + "\n id: " + leer["id_Empleado"].ToString();
            }

            instruccion_SQL = "SELECT cajones.*,tipos_vehiculos.* FROM cajones,tipos_vehiculos WHERE cajones.id_sucursal = " + sucursal + " and cajones.id_estado_cajon = 2 and cajones.id_tipo_vehiculo = tipos_vehiculos.id_tipo_vehiculo GROUP BY cajones.id_cajon";
            obj_conec.AbrirBD();
            leer = cmd.ExecuteReader();

            while (leer.Read())
            {
                auxiliar = auxiliar + "\n " + leer["Lugar"].ToString() + " inicio: " + leer["Hora_inicio"].ToString() + " final: " + leer["Hora_final"].ToString() + " vehiculo tipo:  " + leer["tipo_vehiculo"].ToString();
            }

            instruccion_SQL = "SELECT recibos.*,tipo_recibo.* FROM recibos,tipo_recibo WHERE recibos.id_Scursal = " + sucursal + " and recibos.id_Tipo_Recibo = tipo_recibo.id_tipo_recibo GROUP BY recibos.id_Recibos";
            obj_conec.AbrirBD();
            leer = cmd.ExecuteReader();

            while (leer.Read())
            {
                auxiliar = auxiliar + "\n Recibo:  " + leer["tipo_recibo"].ToString() + " fecha creacion: " + leer["Fecha_Creacion"].ToString() + " Costo: " + leer["Costo"].ToString();
            }

            obj_conec.CerrarBD();
            return auxiliar;
        }
    }
}