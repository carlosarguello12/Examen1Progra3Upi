using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Progra3
{
    internal class Articulos
    {
        protected int codigo { get; set; }
        protected string nombre { get; set; }
        protected double precio { get; set; }
        public static void articulo()
        {
            int[] codigo = new int[5];  // Vector para almacenar codigos
            string[] nombre = new string[5]; // Vector para almacenar nombres
            double[] precio = new double[5]; // Vector para almacenar precios

    

     

        for (int i = 0; i< 5; i++) // Ciclo para llenar codigos 
            {
                Console.WriteLine("Digite  el codigo ");
                codigo[i] =i;
            }
            for (int j = 0; j < 5; i++) // Ciclo para llenar nombres
            {
                Console.WriteLine("Digite  el nombre ");
                nombre[j] = j;
            }


        }












    }
}

