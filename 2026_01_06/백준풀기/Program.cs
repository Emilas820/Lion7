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
            string w = Console.ReadLine();
            int x = int.Parse(w);
            string[] y = new string[x];

            for (int i = 0; i < x; i++)
            {
                string[] k = Console.ReadLine().Split();
                y[i] = k[0] + k[1];
            }

            for (i = 0; i < x; i++)
            {
                Console.WriteLine($"{y[i]}");
            }


        }
    }
}
