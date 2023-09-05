using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PomazDS.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine($"Ошибка. Переменная b={b}. На 0 делить нельзя.");
                return -1;
            }
            else
                return a / b;
        }
    }
}

