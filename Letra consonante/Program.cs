using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letra_consonante
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("INGRESE UNA LETRA:");
            letra = Console.ReadLine();
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")

            {
                Console.WriteLine("La letra es una vocal");

            }
            else
            {
                Console.WriteLine("La letra es una consonante");
            }
            Console.ReadKey();
        }
    }

}  

