using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106LogicalOperators
{
    internal class LogicalOperatorsTest
    {
        static void Main(string[] args)
        {
            // Lecture 14: 논리 연산자

            //AND
            bool a = true;
            bool b = true;

            Console.WriteLine("=== AND 진리표 ===");
            Console.WriteLine("  A    B       S");
            a = false; b = false;
            Console.WriteLine($"{a} {b}  {a&&b}");
            a = false; b = true;
            Console.WriteLine($"{a} {b}   {a && b}");
            a = true; b = false;
            Console.WriteLine($"{a}  {b}  {a && b}");
            a = true; b = true;
            Console.WriteLine($"{a}  {b}   {a && b}");

            Console.WriteLine("\n=== OR 진리표 ===");
            Console.WriteLine("  A    B       S");
            a = false; b = false;
            Console.WriteLine($"{a} {b}  {a || b}");
            a = false; b = true;
            Console.WriteLine($"{a} {b}   {a || b}");
            a = true; b = false;
            Console.WriteLine($"{a}  {b}  {a || b}");
            a = true; b = true;
            Console.WriteLine($"{a}  {b}   {a || b}");

            Console.WriteLine("\n=== NOT 진리표 ===");
            Console.WriteLine("  X       !X");
            a = false;
            Console.WriteLine($"{a}    {!a}");
            a = true;
            Console.WriteLine($"{a}     {!a}");

        }
    }
}
