using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double x = double.Parse(s);
            double F = Math.Sin(x) - 2 * Math.Cos(x);//формула
            Console.WriteLine(x + " " + F);//вывод ответа
            Console.ReadKey();
            return;
        }
    }
}
