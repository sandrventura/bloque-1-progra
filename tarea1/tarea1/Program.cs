using System;

namespace tarea1
{
    internal class Program
    { 
        static void Main(string[] args) 
        {   
            Console.Write("dime la tabla: ");
            int ntabla = int.Parse(Console.ReadLine());
            for (int i = 1; i<=10; i++) {
                Console.WriteLine("{0} x {1} = {2}", ntabla, i, ntabla * i);



                Console.WriteLine("Presione 0 para salir...");




            }

        }
    }
}
        