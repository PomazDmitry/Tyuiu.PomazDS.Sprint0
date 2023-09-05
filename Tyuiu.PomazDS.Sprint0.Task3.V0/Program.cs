using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PomazDS.Sprint0.Task3.V0.Lib;

namespace Tyuiu.PomazDS.Sprint0.Task3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Sum(20, 10));
            Console.WriteLine(DataService.Minus(20, 10));
            Console.WriteLine(DataService.Mult(20, 10));
            Console.WriteLine(DataService.Div(20, 10));
            Console.ReadKey();
        }
    }
}
