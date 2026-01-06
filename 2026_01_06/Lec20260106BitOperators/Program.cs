using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106BitOperators
{
    internal class BitOperatorsTest
    {
        static void Main(string[] args)
        {
            // Lecture 15: 비트 연산자
            int x = 5; //0000 0101
            int y = 3; //0000 0011

            string binary = Convert.ToString(x & y, 2);

            Console.WriteLine("=== 비트 연산자 ===");

            binary = Convert.ToString(x & y, 2);
            Console.WriteLine($"X AND Y = {binary.PadLeft(8, '0')}");
            
            binary = Convert.ToString(x | y, 2);
            Console.WriteLine($"X OR Y = {binary.PadLeft(8, '0')}");

            binary = Convert.ToString(x ^ y, 2);
            Console.WriteLine($"X XOR Y = {binary.PadLeft(8, '0')}");

            binary = Convert.ToString(~x, 2);
            Console.WriteLine($"NOT X = {binary.PadLeft(8, '0')}");


        }
    }
}
