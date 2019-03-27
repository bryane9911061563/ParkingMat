using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingMat.DAO;
using MySql.Data.MySqlClient;
using System.Data;
using ParkingMat.BO;

namespace ParkingMat.DAO
{
    class Cls_tipoVehiculoDAO
    {
        Conexion_DAO Conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        string Instruccion_SQL;

        public DataTable Mostrar_tiposVehiculo()
        {
            Instruccion_SQL = "SELECT *from tipos_vehiculos";
            MySqlDataAdapter adp = new MySqlDataAdapter(Instruccion_SQL, Conec.ConectarBD());
            DataTable virtual_Recibo = new DataTable();
            adp.Fill(virtual_Recibo);

            return (virtual_Recibo);
        }

        public int Agregar_tipoVehiculo(Cls_tipoVehiculo objTipVehiculo)
        {
            Cls_tipoVehiculo datos  = (Cls_tipoVehiculo)objTipVehiculo;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Insert into tipos_vehiculos(tipo_vehiculo ) values ('" + datos.Tipo_vehiculo + "')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }

        public int Eliminar_tipoVehiculo(Cls_tipoVehiculo objTipVehiculo)
        {
            Cls_tipoVehiculo datos = (Cls_tipoVehiculo)objTipVehiculo;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Delete from tipos_vehiculos where id_tipo_vehiculo= ('" + datos.Id_tipo_vehiculo + "')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }

        public int Actualizar_tipoRecibo(Cls_tipoVehiculo objTipvehiculo)
        {
            Cls_tipoVehiculo datos = (Cls_tipoVehiculo)objTipvehiculo;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Update  tipos_vehiculos set tipo_vehiculo= '" + datos.Tipo_vehiculo + "' where id_tipo_vehiculo= ('" + datos.Id_tipo_vehiculo + "')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }
    }
}
