using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec202601082dimensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lecture 3: 2차원 반복문

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"i: {i} j: {j}");
                }
                Console.WriteLine();
            }

            // Mission: 3X3 사각형 그리기

            Console.WriteLine("=== 예제 1 ===");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }

            // Mission: 숫자표 만들기

            Console.WriteLine("=== 예제 2 ===");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            // Mission: 좌표 만들기

            Console.WriteLine("=== 예제 3 ===");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"({j}, {i})");
                }
                Console.WriteLine();
            }

            // Mission: 별 쌓기

            Console.WriteLine("\n=== 예제 4 ===");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            // Mission: 별 쌓기(우배열)

            Console.WriteLine("\n=== 예제 5 ===");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Mission: 별 쌓기 (중앙배열)

            Console.WriteLine("\n=== 예제 6 ===");

            int range = 0;
            int half = 4;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j >= half - range && j <= half + range )
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                range++;
                Console.WriteLine();
                
            }

            //Mission: 2단자

            Console.WriteLine("\n=== 예제 7 ===");

            int k = 1;
            for(int i = 1;i <= 3;i++)
            {
                for(int j = 1;j <= 3;j++)
                {
                    Console.Write($"2 X {k} = {2*(k)} ");
                    k++;
                }
                Console.WriteLine();
            }


            // Mission: 간단한 맵 만들기

            Console.WriteLine("\n=== 예제 8 ===");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        Console.Write("□ ");
                    }
                    else if(i == 4 && j == 4)
                    {
                        Console.Write("○ ");
                    }
                    else
                    {
                        Console.Write("■ ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
