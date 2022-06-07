using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendadeelectronicos
{
    //Clase padre usuario y caracteristicas.
    class Usuario : IMetodos
    {
        public string nombre { get; set; }
        public string username { get; set; }
        public string contraseña { get; set; }
        public string email { get; set; }
        public int edad { get; set; }

        //Metodo polimorfico mostrar datos 
        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre completo: " + nombre + "\nUsername: " + username +
                "\nCorreo Electrónico: " + email + "\nContraseña: **********" + "\nEdad: " + edad);
        }
    }
}
