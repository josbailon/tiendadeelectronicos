using System;
using System.Collections.Generic;
using System.Text;

namespace tiendadeelectronicos
{

    //Clase padre articulo y caracteristicas
    class Articulo : IMetodos
    {
        public string nombre { get; set; }
        public string id { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public double stock { get; set; }
        public double precio { get; set; }

        //Metodo polimorfico mostrar datos 
        public virtual void Mostrar()
        {
            Console.WriteLine("\nArtículo: " + nombre + " id: #" + id + "\nCategoría: " + categoria + "\nDescripción: " + descripcion +
              "\nDisponibilidad: " + stock + "\nPrecio: $" + precio);
        }
    }
}
