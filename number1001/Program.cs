using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number1001
{
    /// <summary>
    /// 백준 A-B 문제
    ///  link :https://www.acmicpc.net/problem/1001
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] s = str.Split();
            int number1 = Int32.Parse(s[0]);
            int number2 = Int32.Parse(s[1]);
            Console.WriteLine(number1 - number2);
        }
    }
}
