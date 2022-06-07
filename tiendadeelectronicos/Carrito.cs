using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendadeelectronicos
{
    //Clase carrito, hereda de Articulo.
    class Carrito : Articulo, IMetodos
    {
        //public string nombre { get; set; }
        //public string id { get; set; }

        //Metodo polimorfico mostrar datos 
        public override void Mostrar()
        {
            Console.WriteLine("\nArtículo: " + nombre + "\nDescripción: "
                + descripcion + "\nPrecio total: $" + precio);

        }


    }
}
