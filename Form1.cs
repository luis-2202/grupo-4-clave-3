using System;
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
    public partial class Form1Credenciales : Form
    {
        public Form1Credenciales()
        {
            InitializeComponent();
        }

        /// <summary>
        /// boton iniciar secion
        /// </summary>
        private void btnIniciarsecion_Click(object sender, EventArgs e)
        {
            // creacion de variables
            string usuario = txtUsuario.Text;
            string contrasena = txtContraeña.Text;

            //verificacion de credenciales de cajero
            if (usuario == "cajero" && contrasena == "caja 1")
            {
                MessageBox.Show("credenciales correctas");
                //crear una instancia en el formulsrio form cajero
                FormCajero formCajero = new FormCajero();

                //mostrar el formulario form cajero
                formCajero.Show();
            }
            // verificacion credenciales asesor
            else if (usuario == "asesor"&& contrasena=="asesor 1")
            {
                MessageBox.Show("credenciales correctas");
                //crear una instancia en el formulsrio form asesor
                FormAsesor formAsesor = new FormAsesor();

                //mostrar el formulario form cajero
                formAsesor.Show();
            }
            //verificacion credenciales gerente
            else if(usuario=="gerente" && contrasena=="unico gerente")
            {
                MessageBox.Show("credenciales correctas");
                //crear una instancia en el formulsrio form gerente
                FormGerente formGerente = new FormGerente();

                //mostrar el formulario form cajero
                formGerente.Show();
            }


            else
            {
                MessageBox.Show("error credenciales incorrectas intentelo de nuevo");
            }


        }
    }
}
