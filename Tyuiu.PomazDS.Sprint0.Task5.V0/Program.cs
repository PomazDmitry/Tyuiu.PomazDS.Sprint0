using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PomazDS.Sprint0.Task5.V0.Lib;

namespace Tyuiu.PomazDS.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(100, 50));
            Console.WriteLine("A - B = " + DataService.Subtraction(100, 50));
            Console.WriteLine("A * B = " + DataService.Multiplication(100, 50));
            Console.WriteLine("A / B = " + DataService.Division(100, 0));
            Console.ReadKey();
        }
    }
}
