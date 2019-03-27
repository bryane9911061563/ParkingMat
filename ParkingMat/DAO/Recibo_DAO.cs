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
    class Recibo_DAO
    {
        Conexion_DAO obj_conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        Recibo_BO reciboBO;
        string instruccion_SQL;

        public DataTable Mostrar_Recibos()
        {
            instruccion_SQL = "SELECT recibos.id_Recibo, recibos.Fecha_Creacion,recibos.Costo,recibos.motivo,recibos.descripcion,tipo_recibo.id_tipo_recibo,sucursales.id_Sucursal FROM recibos,sucursales,tipo_recibo WHERE recibos.id_Scursal=sucursales.id_Sucursal AND recibos.id_Tipo_Recibo=tipo_recibo.id_tipo_recibo";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion_SQL, obj_conec.ConectarBD());
            DataTable virtual_pen = new DataTable();
            adp.Fill(virtual_pen);

            return (virtual_pen);
        }
        public int Agregar_Recibo(Recibo_BO objRecibo)
        {
            reciboBO = (Recibo_BO)objRecibo;
            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Insert into recibos (Costo,Descripcion,Fecha_Creacion,id_Sucursal,id_Tipo_Recibo,motivo) values ('" + objRecibo.Costo + "','" + objRecibo.Descripcion + "','" + objRecibo.Fecha_creacion + "','" + objRecibo.Id_sucu + "','" + objRecibo.Id_tipo + "','" + objRecibo.Motivo + "')";
            cmd.CommandText = instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }

        public int Eliminar_Recibo(Recibo_BO objRecibo)
        {
            reciboBO = (Recibo_BO)objRecibo;
            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Delete from recibos where id_recibo= '" + objRecibo.Id_recibo + "'";
            cmd.CommandText = instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }

        public int Actualizar_Recibo(Recibo_BO objRecibo)
        {
            reciboBO = (Recibo_BO)objRecibo;
            cmd.Connection = obj_conec.ConectarBD();
            obj_conec.AbrirBD();
            instruccion_SQL = "Update recibos set Costo='"+objRecibo.Costo+"',Descripcion='"+objRecibo.Descripcion+",Fecha_Creacion='"+objRecibo.Fecha_creacion+"',id_Sucursal='"+objRecibo.Id_sucu+"',id_Tipo_Recibo='"+objRecibo.Id_tipo+"',motivo='"+objRecibo.Motivo+"')";
            cmd.CommandText = instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            obj_conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }


    }
}
