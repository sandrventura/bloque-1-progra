using System;

namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Ingrese un número:");
                int numero = int.Parse(Console.ReadLine());

                if (numero  >=2)
                {
                    Console.WriteLine($"{numero} es un número primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} no es un número primo.");
                }
                Console.ReadLine();
            }
        }
       

    }
}



        