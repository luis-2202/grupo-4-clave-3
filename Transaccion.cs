using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_grupo_4
{
    public class Transaccion
    {
        //declarar atributos de clase trnsaccion
        private int idtransaccion;
        private int idcliente;
        private string producto;
        private string tipotransaccion;
        private string abonotransaccion;
        private string debitotransaccion;

        //encapsulamientos de atributos
        public int Idtransaccion { get => idtransaccion; set => idtransaccion = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Tipotransaccion { get => tipotransaccion; set => tipotransaccion = value; }
        public string Abonotransaccion { get => abonotransaccion; set => abonotransaccion = value; }
        public string Debitotransaccion { get => debitotransaccion; set => debitotransaccion = value; }
        public string Producto { get => producto; set => producto = value; }


        //creacion de constructores
        public Transaccion ( string PRODUCTO,  string TIPO_TRANSACCION, string ABONO_TRANSACCION, string DEBITO_TRANSACCION)
        {
            
            tipotransaccion = TIPO_TRANSACCION;
            producto = PRODUCTO;
            abonotransaccion = ABONO_TRANSACCION;
            debitotransaccion = DEBITO_TRANSACCION;

        }

        public Transaccion(int ID_TRANSACCION,int ID_CLIENTE,string PRODUCTO, string TIPO_TRANSACCION, string ABONO_TRANSACCION, string DEBITO_TRANSACCION)
        {
            idtransaccion = ID_TRANSACCION;
            idcliente = ID_CLIENTE;
            tipotransaccion = TIPO_TRANSACCION;
            producto = PRODUCTO;
            abonotransaccion = ABONO_TRANSACCION;
            debitotransaccion = DEBITO_TRANSACCION;

        }

    }
}


    

