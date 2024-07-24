using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" ingrese un numero");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("");
                }

                if (numero > 0)

                {
                    Console.WriteLine("es numero positivo");
                }

                else
                {
                    Console.WriteLine(" el numero es negativo");
                    Console.WriteLine("finalizado");
                }

            }

        }
    }
}
        