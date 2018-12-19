using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number1002
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int t,  x1 = 0, y1 = 0, r1 = 0, x2 = 0, y2 = 0, r2 = 0;
            t = Int32.Parse(Console.ReadLine());
            string[] res = new string[t];

            for (int j=0; t > 0; t--,j++)
            {
                string[] str = Console.ReadLine().Split();

                x1 = Convert.ToInt32(str[0]);
                y1 = Convert.ToInt32(str[1]);
                r1 = Convert.ToInt32(str[2]);
                x2 = Convert.ToInt32(str[3]);
                y2 = Convert.ToInt32(str[4]);
                r2 = Convert.ToInt32(str[5]);

                double d = Math.Sqrt(Math.Pow(x1 - x2, 2.0) + Math.Pow(y1 - y2, 2.0));  

                if (x1 == x2 && y1 == y2)
                {
                    if (r1 == r2)
                    {
                        // 위치의 갯수가 같으면 무한대..
                        res[j] = "-1";
                    }
                    else
                    {   // 한점에서 만나는 경우.
                        res[j] = "0";
                    }
                }

                else
                {
                    if ((r1 + r2) > d && Math.Abs(r1 - r2)<d)
                    {           // 교점이 두개 생기는 경우.
                        res[j] = "2";
                    }
                    else if ((r1 + r2 == d) || (d==Math.Abs(r1-r2))) // 한점에서 만나는 경우.
                    {
                        res[j] = "1";
                    }
                    else
                    {
                        res[j] = "0";
                    }
                }
            }
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}