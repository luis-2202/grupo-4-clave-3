using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_grupo_4
{
    public partial class FormGerente : Form
    {
        public partial class FormAsesor : Form
        {

            private static string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            private static string bd = "biblioteca"; //Nombre de la base de datos
            private static string usuario = "root"; //Usuario de acceso a MySQL
            private static string password = "Fvpafalu2202"; //Contraseña de usuario de acceso a MySQL

            // crear cadena de conexxion
            static string cadenaconexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //instancia de mysql
            static MySqlConnection conexionBD = new MySqlConnection(cadenaconexion);


        }
        public FormGerente()
        {
            InitializeComponent();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnConexxion_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = null;
            try
            {

                //obtiene la conexión usando el método ObtenerConexion de la clase ConexionBD
                conexion = conexionBD.ObtenerConexion();

                //envia un mensaje de estado de exito de conexion
                MessageBox.Show("Conexión exitosa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                if (conexion != null)
                {
                    //cierra la conexión usando el método CerrarConexion de la claseConexionBD
                    conexionBD.CerrarConexion(conexion);
                }
            }

        }




        private void btnleer_Click(object sender, EventArgs e)
        {


            leerBase();
            // fin boton leer

        }
        //Método leer Base
        public void leerBase()
        {


            // Obtener conexión

            // Crear consulta con la conexión obtenida
            try
            {
                MySqlConnection conexion = conexionBD.ObtenerConexion(); // Obtener conexión
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM cliente", conexion);
                // Inicializar una nueva instancia de la clase MySqlDataAdapter con
                // el MySqlCommand especificado como propiedad SelectCommand.
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                DGTabla.DataSource = tabla;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }



        }
        public void eliminarCliente()
        {
            //Recuperas el id seleccionado a eliminar
            if (Convert.IsDBNull(DGTabla.Rows[0].Cells[0].FormattedValue))
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar un id");
            }
            else
            {
                MySqlCommand consulta = new MySqlCommand();
                MySqlConnection conexion = conexionBD.ObtenerConexion(); // Obtener conexión
                try
                {
                    // Obtener el ID del cliente de la fila seleccionada
                    int id =
                    Convert.ToInt32(DGTabla.CurrentRow.Cells["ID_CLIENTE"].Value);
                    consulta.Connection = conexion;
                    consulta.CommandText = "DELETE FROM CLIENTE WHERE ID_CLIENTE = '" + id
                    + "'";
                    //---
                    MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                    adaptadorMySQL.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptadorMySQL.Fill(tabla); //ejecutar el insert
                    MessageBox.Show("se elimino elemento de la base");
                    
                }
                catch (MySqlException ex) //manejo de excepciones MySQL
                {
                    MessageBox.Show("elemento no se ingreso!");
                }
                finally
                {
                    conexionBD.CerrarConexion(conexion);
                }
            }
        }         //fin método eliminar cliente

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarCliente();
                leerBase();
            }
            catch (Exception )
            {
                MessageBox.Show("Presione el botón leer primero para seleccionar un id");
            }
        }
        //Se procederá a escribir el código para el método actualizarCliente como se muestra a continuación.
          //Método actualizar Cliente
            
    }
}
    

             
