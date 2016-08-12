using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_iguales_o_no
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            Console.WriteLine("Escribe el primer número");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número");
            num2 = Convert.ToInt16(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("Los numeros son iguales");
            else
                Console.WriteLine("Los numeros no son iguales" );
            Console.ReadLine();
        }
    }

}

