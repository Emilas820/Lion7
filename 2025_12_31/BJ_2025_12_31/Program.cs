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

            int A = int.Parse(n[0]);
            int B = int.Parse(n[1]);
            int C = int.Parse(n[2]);

            char a = '"';

            Console.WriteLine(@"|\_/|");
            Console.WriteLine(@"|q p|   /}");
            Console.WriteLine($@"( 0 ){a}{a}{a}\");
            Console.WriteLine($@"|{a} ^ {a}`    |");
            Console.WriteLine(@"||_/=\\__|");

        }
    }
}
