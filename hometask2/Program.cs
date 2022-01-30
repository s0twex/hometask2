using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwtask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            if (a > b) a = b;
            if (a > c) a = c;
            Console.WriteLine("Min = {0}", a);
            Console.WriteLine("Нажмите ENTER");
            Console.ReadKey();


            Console.WriteLine("введите целое положительное число менее 2000000000");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (n != 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}