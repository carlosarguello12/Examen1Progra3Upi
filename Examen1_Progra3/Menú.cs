using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Progra3
{
    internal class Menú
    {

        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()//metodo para desplegar menu
        {
            int opcion = 0; // Variable para opcion de menu 
            do
            {
                Console.WriteLine("Bienvenido al menu");
                Console.WriteLine("1 - Articulos ");
                Console.WriteLine("2 - Facturacion");
                Console.WriteLine("3 - Reporte");
                Console.WriteLine("4 - Salir ");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:; break;
                    case 2:; break;
                    case 3: break;
                    default: Console.WriteLine(" Error digite una opcion valida"); break;

                }
            } while (opcion != 4); //Valor para salir del menu   



        }
    }
}
