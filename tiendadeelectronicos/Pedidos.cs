using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendadeelectronicos
{
    //Clase Pedidos y caracteristicas, hereda de Articulo.
    class Pedidos : Articulo, IMetodos
    {
        public string numeropedido { get; set; }
        public string descripcionpedido { get; set; }
        public string confirmacion { get; set; }

        //Metodo polimorfico mostrar datos  
        public override void Mostrar()
        {
            Console.WriteLine("Número de pedido: " + numeropedido + "\nDescripción: "
                + descripcionpedido + "\nConfirmacion de pedido: " + confirmacion);
        }
    }
}