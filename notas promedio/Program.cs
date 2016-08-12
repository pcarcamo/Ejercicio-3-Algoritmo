using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas_promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float suma;
            float promedio;

            Console.WriteLine("     Escribe el código del alumno    ");
            int codigo = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("  Escribe el nombre del alumno  ");
            string nombre = Console.ReadLine();

            Console.WriteLine("  ");
            Console.WriteLine("     Ingresa las siguientes notas  ");
            Console.WriteLine("   ");
            Console.WriteLine(" Escribe la nota de física: ");
            int nota1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" Escribe la nota de Química:  ");
            int nota2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" Escribe la nota de Programación:  ");
            int nota3 = Convert.ToInt16(Console.ReadLine());
            suma = (nota1 + nota2 + nota3);
            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("    ");
            Console.WriteLine("     Datos del almuno:  ");
            Console.WriteLine("    ");
            Console.WriteLine("Codigo del alumno:   {0}  ", codigo);
            Console.WriteLine("Nombre del estudiante:   {0}  ", nombre);
            Console.WriteLine("Nota total:   {0}  ", suma);
            Console.WriteLine("Promedio es:   {0}  ", promedio);

            Console.ReadLine();
        }
    }


}
   
