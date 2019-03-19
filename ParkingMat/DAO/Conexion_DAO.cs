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


        public MySqlConnection ConectarBD()
        {
            string cadena = "datasource = localhost; username = root; password =; database = parking-mat;";

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
        
    }
}
