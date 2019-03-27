using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hacer referencia a la libreria
using MySql.Data.MySqlClient;

namespace ParkingMat.DAO
{
    class Conexion_DAO
    {
        MySqlConnection Conex;
        MySqlCommand cmd = new MySqlCommand();


        public MySqlConnection ConectarBD()
        {
            string cadena = "datasource = localhost; username = root; password =; database = parking-mat; Convert zero datetime = true;";

            Conex = new MySqlConnection(cadena);
            return Conex;

        } 
        public void AbrirBD()
        {
            Conex.Open();
        }
        public void CerrarBD()
        {
            Conex.Close();
        }

        public int EjecutarSQL(string InstruccionABC)
        {
            cmd.Connection = ConectarBD();
            AbrirBD();
            cmd.CommandText = InstruccionABC;
            int acuse = cmd.ExecuteNonQuery();
            CerrarBD();
            if (acuse <= 0)
            {
                return 0;
            }
            return 1;
        }

    }
}
