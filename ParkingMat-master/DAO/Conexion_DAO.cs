using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ref
using MySql.Data.MySqlClient;

namespace MiniProyectoABC.DAO
{
    class Conexion_DAO
    {
        MySqlConnection conex;
        public MySqlConnection ConectarBD()
        {
            string cadena = "datasource = localhost; username= root; password=123456; database=proyectoabc;";
            conex = new MySqlConnection(cadena);
            return conex;
        }

        public void abrirBD()
        {
            conex.Open();
        }

        public void cerrarBD()
        {
            conex.Close();
        }

    }

}
