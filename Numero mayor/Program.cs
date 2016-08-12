using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, mayor;
            //ingresamos los tres numeros
            Console.Write("Ingrese el primer Numero :");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo Numero :");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer Numero :");
            numero3 = int.Parse(Console.ReadLine());
            //calculamos el mayor
            if (numero1 > numero2 && numero1 > numero3)
                mayor = numero1;
            else if (numero2 > numero1 && numero2 > numero3)
                mayor = numero2;
            else
                mayor = numero3;
            //mostramos el mayor
            Console.WriteLine("El Mayor es :{0}", mayor);
            Console.Read();
        }
    }
}
