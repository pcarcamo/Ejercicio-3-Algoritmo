using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_positivo_o_negatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero");
            int numero = Convert.ToInt16(Console.ReadLine());
            { 
            if (numero > 0)
               Console.WriteLine("El numero " + numero + " es positivo");
            else
               Console.WriteLine("El numero " + numero + " es negativo");
                }
            Console.ReadLine();
        }
            
     }
 }


