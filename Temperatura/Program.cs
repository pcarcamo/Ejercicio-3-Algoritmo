using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static  void Main()
        {
            Console.WriteLine("Ingrese la temperatura");
            int clima = Convert.ToInt16(Console.ReadLine());
            if ( clima <= 0)
                Console.WriteLine("El clima es para congelarse");
            else
            {
                if (clima >= 1 && clima <= 10)
                    Console.WriteLine("El clima es es muy frio");
                else
                {
                    if (clima >= 11 && clima <= 20)
                        Console.WriteLine("El clima es frio");
                    else
                    {
                        if (clima >= 21 && clima <= 30)
                            Console.WriteLine("El clima es normal");
                        else
                        {
                            if (clima >= 31 && clima <= 40)
                                Console.WriteLine("El clima es caliente");
                            else
                            {
                                Console.WriteLine("El clima es muy caliente");

                            }


                        }

                    }

                }

            }
            Console.ReadLine();
        }
    }



}
