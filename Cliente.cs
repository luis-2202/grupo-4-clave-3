using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_grupo_4
{
   public class Cliente
    {
        //atributos de la clase cliente
        private int idcliente;
        private string duicliente;
        private string nombrecliente;
        private string apellidoCliente;
        private string productocliente;


        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Duicliente { get => duicliente; set => duicliente = value; }
        public string Nombrecliente { get => nombrecliente; set => nombrecliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string Productocliente { get => productocliente; set => productocliente = value; }

        public Cliente(string DUI, string NOMBRE, string APELLIDO, string PRODUCTO)
        {


            //realizando constructores de clase cliente
            this.duicliente = DUI;
            this.nombrecliente = NOMBRE;
            this.apellidoCliente = APELLIDO;
            this.productocliente = PRODUCTO;

        }
        public Cliente(int ID, string DUI, string NOMBRE, string APELLIDO,
                       string PRODUCTO)
        {
            this.idcliente = ID;
            this.duicliente = DUI;
            this.nombrecliente = NOMBRE;
            this.apellidoCliente = APELLIDO;
            this.productocliente = PRODUCTO;
        }
        //Constructor por defecto
        public Cliente()
        {
        }
    }
}
