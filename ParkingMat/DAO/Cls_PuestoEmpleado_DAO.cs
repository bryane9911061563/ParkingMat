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
    class Cls_PuestoEmpleado_DAO
    {
        Conexion_DAO Conec = new Conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        Cls_PuestoEmpleado_BO objPuestoEmpleadoBO;

        public string Instruccion_SQL;

        public DataTable MostrarPuestos()
        {
            Instruccion_SQL = "SELECT *from tipo_puesto";
            MySqlDataAdapter adp = new MySqlDataAdapter(Instruccion_SQL, Conec.ConectarBD());
            DataTable virtual_Puesto = new DataTable();
            adp.Fill(virtual_Puesto);

            return (virtual_Puesto);
        }

        public int Agregar_Puesto(Cls_PuestoEmpleado_BO objPuesto)
        {
            objPuestoEmpleadoBO = (Cls_PuestoEmpleado_BO)objPuesto;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Insert into tipo_puesto(Puesto) values ('" + objPuesto.Nombre_puestoempleado + "')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;

        }
        public int Eliminar_Puesto(Cls_PuestoEmpleado_BO objPuesto)
        {
            objPuestoEmpleadoBO = (Cls_PuestoEmpleado_BO)objPuesto;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Delete from tipo_puesto where id_puesto= ('"+ objPuesto.Id_puestoempleado + "')";
            cmd.CommandText = Instruccion_SQL;
            int valor = cmd.ExecuteNonQuery();
            Conec.CerrarBD();

            if (valor <= 0)
            {
                return 0;
            }

            return 1;
        }
        public int Actualizar_Puesto(Cls_PuestoEmpleado_BO objPuesto)
        {
            objPuestoEmpleadoBO = (Cls_PuestoEmpleado_BO)objPuesto;

            cmd.Connection = Conec.ConectarBD();
            Conec.AbrirBD();
            Instruccion_SQL = "Update  tipo_puesto set Puesto= '" + objPuesto.Nombre_puestoempleado + "' where id_puesto= ('" + objPuesto.Id_puestoempleado + "')";
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
