using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 백준풀기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            string r = Console.ReadLine();
            int M = int.Parse(m);
            int R = int.Parse(r);

            int c_M = 0;
            int c_R = 0;

            for (int i = 0; i < R; i++)
            {
                string[] n = Console.ReadLine().Split();
                int m_ = int.Parse(n[0]);
                int r_ = int.Parse(n[1]);
                c_M = c_M + m_;
                c_R = c_R + r_;
            }

            Console.Write(M == c_M && R == c_R);


        }
    }
}
