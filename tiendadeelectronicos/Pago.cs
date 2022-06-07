using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendadeelectronicos
{
    //Clase padre Pago y caracteristicas.
    class Pago : IMetodos
    {
        public string id { get; set; }

        //Metodo polimorfico mostrar datos 
        public virtual void Mostrar()
        {

        }
    }
}

