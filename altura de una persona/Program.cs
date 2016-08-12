using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altura_de_una_persona
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; string altura;
            Console.Write("INGRESE SU ALTURA :");
            altura = Console.ReadLine();
            numero = int.Parse(altura);
            if (numero < 150)
            {
                Console.Write("SU ALTURA ES BAJA");
            }
            else
            {
                Console.Write("SU ALTURA ES PROMEDIO");
            }
            if (numero > 170)
            {
                Console.Write("SU ALTURA ES MAYOR A LA PROMEDIO");
            }
            Console.ReadKey();
        }
    }
}





