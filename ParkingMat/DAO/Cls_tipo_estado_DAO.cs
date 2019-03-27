using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ParkingMat.BO;

namespace ParkingMat.DAO
{
    class Cls_tipo_estado_DAO
    {
        Conexion_DAO Conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();


        string Instruccion_SQL;

        public DataTable Mostrar_tiposEstado()
        {
            Instruccion_SQL = "SELECT *from estados_cajones";
            MySqlDataAdapter adp = new MySqlDataAdapter(Instruccion_SQL, Conec.ConectarBD());
            DataTable virtual_Recibo = new DataTable();
            adp.Fill(virtual_Recibo);

            return (virtual_Recibo);
        }

        public int Agregar_tipoEstado(Cls_tipo_estado_BO objTipEstado)
        {
            Cls_tipo_estado_BO datos = (Cls_tipo_estado_BO)objTipEstado;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Insert into estados_cajones(estado  ) values ('" + datos.Estado + "')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }

        public int Eliminar_tipoEstado(Cls_tipo_estado_BO objTipEstado)
        {
            Cls_tipo_estado_BO datos = (Cls_tipo_estado_BO)objTipEstado;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Delete from estados_cajones where id_estado_cajon= ('" + datos.Id_estado_cajon + "')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }

        public int Actualizar_tipoRecibo(Cls_tipo_estado_BO objTipEstado)
        {
            Cls_tipo_estado_BO datos = (Cls_tipo_estado_BO)objTipEstado;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Update  estados_cajones set estado= '" + datos.Estado + "' where id_estado_cajon= ('" + datos.Id_estado_cajon + "')";
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
