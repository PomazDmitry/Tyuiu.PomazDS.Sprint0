using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PomazDS.Sprint0.Task4.V0.Lib;

namespace Tyuiu.PomazDS.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(100, 50));
            Console.WriteLine(DataService.Subtraction(100, 50));
            Console.WriteLine(DataService.Multiplication(100, 50));
            Console.WriteLine(DataService.Division(100, 50));
            Console.ReadKey();
        }
    }
}
