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
    public partial class FormCajero : Form
    {
        private static string servidor = "localhost"; //Nombre o ip del servidor de MySQL
        private static string bd = "biblioteca"; //Nombre de la base de datos
        private static string usuario = "root"; //Usuario de acceso a MySQL
        private static string password = "Fvpafalu2202"; //Contraseña de usuario de acceso a MySQL

        // crear cadena de conexxion
        static string cadenaconexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

        //instancia de mysql
        static MySqlConnection TransaccionBd = new MySqlConnection(cadenaconexion);

        public FormCajero()
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

        private void btnAgregarTransaccion_Click(object sender, EventArgs e)
        {

            if (!Validar())
            {
                //Se crea una instancia de la clase Cliente de nombre cliente
                Transaccion transaccion = new Transaccion(txtProducto.Text, cbxtipo.Text, txtabono.Text, txtdebito.Text);
                ingresartransaccion(transaccion);



            }
            else
            {
                MessageBox.Show("Ingrese datos en los campos" + CamposVacios());
            }
        }

        public bool Validar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "txtIDtransaccion")
                    {
                        if (TextoVacio(item.Text))
                            return true;
                    }
                }
            }
            return false;
        }//fin del método Validar
         //Metodo verifica campo este vacio o nulo
        public bool TextoVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto) || string.IsNullOrEmpty(texto) || texto.Equals("");
        }
        public string CamposVacios()
        {
            string campos = "";
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "txtIDtransaccion")
                    {
                        if (TextoVacio(item.Text))
                            campos += "\n" + item.Name;
                    }
                }
            }
            return campos;
        }


        public void ingresartransaccion(Transaccion c)
        {
            MySqlConnection conexion = transaccionBD.ObtenerConexion(); // Obtener conexión
            MySqlCommand consulta = new MySqlCommand();

            consulta.Connection = conexion;
            consulta.CommandText = "INSERT INTO  transaccion  (ID_TRANSACCION,ID_CLIENTE, TIPO_TRANSACCION, ABONO_TRANSACCION,DEBITO_TRANSACCION,PRODUCTO)" + " VALUES ('" + c.Idtransaccion + "', '" + c.Idcliente + "' , '" + c.Tipotransaccion + "','" + c.Abonotransaccion + "','" + c.Debitotransaccion + "','" + c.Producto + "' )";

            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla); //ejecutar el insert
                MessageBox.Show("elemento ingresado exitosamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("elemento no se ingreso!" + ex);
            }
            finally
            {
                transaccionBD.CerrarConexion(conexion); // Cerrar conexión
            }
        }


        private void dgtransaccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Recupera el id seleccionado a eliminar
            int id = Convert.ToInt32(dgtransaccion.CurrentRow.Cells["ID_transaccion"].Value);
            MySqlCommand consulta = new MySqlCommand();
            MySqlConnection conexion = transaccionBD.ObtenerConexion(); // Obtener conexión
            consulta.Connection = conexion;
            consulta.CommandText = "select * FROM transaccion  WHERE ID_CLIENTE = '" + id +
           "'";
            try
            {
                //Inicializa una nueva instancia de la clase MySqlDataAdapter con
                //el MySqlCommand especificado como propiedad SelectCommand.
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);

                txtIDtransaccion.Text = tabla.Rows[0]["ID_TRANSACCION"].ToString();
                txtProducto.Text = tabla.Rows[0]["PRODUCTO"].ToString();
                cbxtipo.Text = tabla.Rows[0]["TIPO_TRANSACCION"].ToString();
                txtabono.Text = tabla.Rows[0]["ABONO_TRANSACCION"].ToString();
                txtdebito.Text = tabla.Rows[0]["DEBITO_TRANSACCION"].ToString();

            }
            catch
            {
                MessageBox.Show("elemento no se ingreso!");
            }
            finally
            {
                transaccionBD.CerrarConexion(conexion);

            }


        }
    
        private void btnleer_Click(object sender, EventArgs e)
        {
           
            {
                leerBase();
                // fin boton leer

            }
             //Método leer Base
              void leerBase()

            { 

                // Obtener conexión

                // Crear consulta con la conexión obtenida
                try
                {
                    MySqlConnection conexion = conexionBD.ObtenerConexion(); // Obtener conexión
                    MySqlCommand consulta = new MySqlCommand("SELECT * FROM transaccion", conexion);
                    // Inicializar una nueva instancia de la clase MySqlDataAdapter con
                    // el MySqlCommand especificado como propiedad SelectCommand.
                    MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                    adaptadorMySQL.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptadorMySQL.Fill(tabla);
                    dgtransaccion.DataSource = tabla;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
              
            }
        }
    }
}
