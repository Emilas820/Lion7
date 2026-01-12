using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Mission1
    {
        // 실습 1 - 평균 계산 함수
        static void Main(string[] args)
        {
            double avr = Aver();
            Console.WriteLine("평균: " + avr);
        }

        static double Aver()
        {
            double sum = 0;
            string[] n = Console.ReadLine().Split();
            int[] x = new int[n.Length];
            for (int i =0;i<n.Length;i++)
            {
                x[i] = int.Parse(n[i]);
                sum += x[i];
            }
            return sum/n.Length;
        }


    }
}
