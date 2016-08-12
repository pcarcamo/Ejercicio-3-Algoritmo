using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voto_segun_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            string teclado;

            Console.WriteLine("  Elegible Para votar ");
             
            Console.WriteLine("Ingresa su fecha de nacimiento : ");
            teclado = Console.ReadLine();
            edad = int.Parse(teclado);
            if (edad <= 1998)
            {
                Console.Write("\n Felicidades puedes Votar: ");
            }
            else
            {
                Console.WriteLine("No puedes Votar: ");
            }
                     
               Console.ReadLine();

        }
    }
}
