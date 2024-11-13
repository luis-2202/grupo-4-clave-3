using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_grupo_4
{
    public class transaccionBD
    {

        private static string servidor = "localhost"; //Nombre o ip del servidor de MySQL
        private static string bd = "biblioteca"; //Nombre de la base de datos
        private static string usuario = "root"; //Usuario de acceso a MySQL
        private static string password = "Fvpafalu2202"; //Contraseña de usuario de acceso a MySQL
        public static MySqlConnection ObtenerConexion()
        {
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor +
            "; User Id=" + usuario + "; Password=" + password +
           "";
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();
            return conexionBD;
        }
        public static void CerrarConexion(MySqlConnection conexionBD)
        {
            conexionBD.Close();
        }
    }
}
