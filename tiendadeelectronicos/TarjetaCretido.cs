using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendadeelectronicos
{
    //Clase tarjeta de crédito y caracteristicas, hereda de pago.
    class TarjetaCredito : Pago, IMetodos
    {
        public string numtarjeta { get; set; }
        public double cvv { get; set; }
        public string fechatarjeta { get; set; }
        //Metodo para agregar una tarjeta de credito o debito para las compras del carrito
        public void agregartarjeta()
        {
            Console.WriteLine("\n**** AGREGA UNA TARJETA DE CREDITO/DEBITO ****");
            Carrito tarj1 = new Carrito();
            Console.WriteLine("\nIngresa tu Numero de tarjeta:");
            numtarjeta = Console.ReadLine();
            Console.WriteLine("\nIngresa el codigo cvv de la tarjeta:");
            cvv = double.Parse(Console.ReadLine());
            //while para una validacion de datos, solo pueden agregar 3 digitos al cvv
            while (cvv <= 99 && cvv >= 300)
            {
                Console.WriteLine("\n El codigo cvv debe contener 3 digitos"
                    + "\nIngresa el codigo cvv de la tarjeta:");
                cvv = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nIngresa la fecha de vencimiento de la tarjeta:");
            fechatarjeta = Console.ReadLine();
            Console.Clear();
        }
        //Metodo polimorfico mostrar datos 
        public override void Mostrar()
        {
            Console.WriteLine("**** ESTAS SON TUS TAREJTAS ****");
            Console.WriteLine("\nNúmero de tarjeta: " + numtarjeta + "\nFecha de vencimiento: " + fechatarjeta + "\nCvv: " + cvv);
        }
    }
}
