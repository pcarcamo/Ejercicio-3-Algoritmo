using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_de_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 20;
            Console.WriteLine("Ingrese un número: ");
            valor = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("El resultado es un numero ");
            if ((valor % 2)== 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
        
                Console.ReadKey();
        }
    }
}
   
