using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_2025_12_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            string x = Console.ReadLine();

            int h = int.Parse(n[0]); // 현재 시
            int m = int.Parse(n[1]); // 현재 분
            int t = int.Parse(x);    // 걸리는 시간(time)

            int a = t % 60;      // time의 나머지
            int b = t / 60;      // time의 몫
            int temp = 0;

            if (b > 23)
            {
                temp = b / 24;
                b = b - temp * 24;
            }
            if (m + a >= 60)
            {
                if (h + b <= 23)
                {
                    h = h + b + 1;
                    m = m + a - 60;
                }
                else
                {
                    h = h + b - 24;
                    m = m + a - 60;
                }
            }
            else
            {
                if (h + b <= 23)
                {
                    h = h + b;
                    m = m + a;
                }
                else
                {
                    h = h + b - 24;
                    m = m + a;
                }
            }

            Console.WriteLine($"{h} {m}");

        }
    }
}
