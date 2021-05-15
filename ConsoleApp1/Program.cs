using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //13.
            Console.WriteLine("Введите число p1");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число p2");
            int p2 = Convert.ToInt32(Console.ReadLine());
            int a1 = p1 - p2;
            int c1 = a + b;
            int d = c + c1;
            Console.WriteLine(c1);
            Console.WriteLine(d);
            Console.WriteLine(a1);
            Console.ReadKey();



        }
    }
}
