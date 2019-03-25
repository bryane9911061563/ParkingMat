using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ParkingMat.BO;

namespace ParkingMat.DAO
{
    class Cls_TipoRecibo_DAO
    {
        string Instruccion_SQL;

        Conexion_DAO Conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();

        

        public DataTable Mostrar_tiposRecibo()
        {
            Instruccion_SQL = "SELECT *from tipo_recibo";
            MySqlDataAdapter adp = new MySqlDataAdapter(Instruccion_SQL, Conec.ConectarBD());
            DataTable virtual_Recibo = new DataTable();
            adp.Fill(virtual_Recibo);

            return (virtual_Recibo);
        }

        public int Agregar_tipoRecibo(Cls_TipoRecibo_BO objTipRecibo)
        {
            Cls_TipoRecibo_BO datos = (Cls_TipoRecibo_BO)objTipRecibo;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Insert into tipo_recibo (nombre) values ('"+objTipRecibo.Nombre_tipRecibo+"')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }
        public int Eliminar_tipoRecibo(Cls_TipoRecibo_BO objTipRecibo)
        {
            Cls_TipoRecibo_BO datos = (Cls_TipoRecibo_BO)objTipRecibo;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Delete from tipo_recibo where id_tipo_recibo= ('" + objTipRecibo.Id_tipRecibo + "')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }
        public int Actualizar_tipoRecibo(Cls_TipoRecibo_BO objTipRecibo)
        {
            Cls_TipoRecibo_BO datos = (Cls_TipoRecibo_BO)objTipRecibo;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Update  tipo_recibo set nombre_tiporecibo= '" + datos.Nombre_tipRecibo + "' where id_tipo_recibo= ('" + objTipRecibo.Id_tipRecibo + "')";
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
