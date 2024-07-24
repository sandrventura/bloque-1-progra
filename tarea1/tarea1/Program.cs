using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" num 1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("num 2:");
            int num2 = int.Parse(Console.ReadLine());


            int res = num1 + num2;
            Console.WriteLine(" la suma {0}+{1}={2}", num1, num2, res);

            int num = -1;
            string msg = "";
            if (num <= 0)
            {
                msg = "no Puede colocar ese valor en el numero 1";

            }

            Console.WriteLine(msg);


            Console.ReadLine();



        }
    }
}
