using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106RelationalOperators
{
    internal class RelationalOperatorsTest
    {
        static void Main(string[] args)
        {
            // Lecture 13: 관계형 연산자

            int x = 5;
            int y = 10;

            Console.WriteLine($"x < y는 {x < y}이다.");
            Console.WriteLine($"x > y는 {x > y}이다.");
            Console.WriteLine($"x <= y는 {x <= y}이다.");
            Console.WriteLine($"x >= y는 {x >= y}이다.");
            Console.WriteLine($"x = y는 {x == y}이다.");
            Console.WriteLine($"x != y는 {x != y}이다.");
        }
    }
}
