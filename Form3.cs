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
using proyecto_grupo_4.clases;

namespace proyecto_grupo_4
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
        public FormAsesor()
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
                conexion = ConexionBD.ObtenerConexion();
                
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
                    ConexionBD.CerrarConexion(conexion);
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
                MySqlConnection conexion = ConexionBD.ObtenerConexion(); // Obtener conexión
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
            finally
            {
                ConexionBD.CerrarConexion(conexionBD);// Cerrar conexión
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)

        {
            if (!Validar())
            {
                //Se crea una instancia de la clase Cliente de nombre cliente
                Cliente cliente = new Cliente(txtDui.Text, txtNombre.Text, txtApellido.Text, txtproducto.Text );
                ingresarCliente(cliente);
                //leerBase();
                Limpiar(this);
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
                    if (item.Name != "txtID")
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
            return string.IsNullOrWhiteSpace(texto) || string.IsNullOrEmpty(texto) ||
           texto.Equals("");
        }
        public void ingresarCliente(Cliente c)
        {
            MySqlConnection conexion = ConexionBD.ObtenerConexion(); // Obtener conexión
            MySqlCommand consulta = new MySqlCommand();
           
            consulta.Connection = conexion;
            consulta.CommandText = "INSERT INTO  cliente  (DUI_CLIENTE,NOMBRE_CLIENTE, APELLIDO_CLIENTE, PRODUCTO_CLIENTE)"+" VALUES ('" + c.Duicliente + "', '" + c.Nombrecliente + "', '" + c.ApellidoCliente + "', '" + c.Productocliente + "')";

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
                MessageBox.Show("elemento no se ingreso!"+ex);
            }
            finally
            {
                ConexionBD.CerrarConexion(conexion); // Cerrar conexión
            }
        }
        // A continuación, se muestra el código para el método CamposVacios.
        public string CamposVacios()
        {
            string campos = "";
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "txtID")
                    {
                        if (TextoVacio(item.Text))
                            campos += "\n" + item.Name;
                    }
                }
            }
            return campos;
        }

        private void DGTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Recupera el id seleccionado a eliminar
            int id = Convert.ToInt32(DGTabla.CurrentRow.Cells["ID_CLIENTE"].Value);
            MySqlCommand consulta = new MySqlCommand();
            MySqlConnection conexion = ConexionBD.ObtenerConexion(); // Obtener conexión
            consulta.Connection = conexion;
            consulta.CommandText = "select * FROM cliente WHERE ID_CLIENTE = '" + id + "'";
            try
            {
                //Inicializa una nueva instancia de la clase MySqlDataAdapter con
                //el MySqlCommand especificado como propiedad SelectCommand.
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                txtID.Text = tabla.Rows[0]["ID_CLIENTE"].ToString();
                txtDui.Text = tabla.Rows[0]["DUI_CLIENTE"].ToString();
                txtNombre.Text = tabla.Rows[0]["NOMBRES_CLIENTE"].ToString();
                txtApellido.Text = tabla.Rows[0]["APELLIDOS_CLIENTE"].ToString();
                txtproducto.Text = tabla.Rows[0]["PRODUCTO_CLIENTE"].ToString();

            }
            catch
            {
                MessageBox.Show("elemento no se ingreso!");
            }
            finally
            {
                ConexionBD.CerrarConexion(conexion);





            }
        }
            public static void Limpiar(Form ofrm)
            {
                //Checar todos los textbox del formulario
                foreach (Control oControls in ofrm.Controls)
                {
                    if (oControls is TextBox)
                    {
                        oControls.Text = string.Empty; //Eliminar el texto del TextBox
                    }
                }
            }// fin del método limpiar

        
        

        
    }
}

