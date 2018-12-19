using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            int zero = 0, one = 0;
            t = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n;
                n = Int32.Parse(Console.ReadLine());
                Fibonacci(n);
                Console.WriteLine($"{zero}  {one}");
                zero = 0;
                one = 0;
            }
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("0");
                return 0;
            }
            else if (n == 1)
            {
                Console.WriteLine("1");
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
