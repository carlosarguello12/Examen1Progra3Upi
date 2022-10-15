using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Progra3


{
    internal class Categorias
    {

        public static void mensaje ()  

        {
            Console.WriteLine("Descuentos y promociones");

        }


        List<string> Categoria = new List<string>()
{
    "1",
    "2",
    "3"

};

        class Categoria1 : Categorias  // Herencia
        {
            public static void promocion()

            {
                Console.WriteLine("Descuento del 15 %");

            }
        }

        class Categoria2 : Categorias  // Herencia
        {
            public static void promocion()

            {
                Console.WriteLine("Promocion dos por 1");

            }
        }

        class Categoria3 : Categorias  // Herencia
        {
            public static void promocion()

            {
                Console.WriteLine("Todo a mitad de precio ");

            }
        }


    }
}
