using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _20260109
{
    internal class Array_3
    {
        static void Main(string[] args)
        {

            // 고정 배열

            int[,] map = new int[5, 5]
            {
                {0, 0, 1, 0, 0 },
                {0, 2, 1, 0, 0 },
                {0, 0, 1, 0, 0 },
                {1, 1, 1, 0, 0 },
                {0, 0, 0, 0, 0 },
            };

            Console.WriteLine("=== 던전 ===");
            Console.WriteLine("0: 통로, 1: 벽, 2: 몬스터, 3: 보물, 9: 출구\n");


            // 실습: 맵 출력
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    switch (map[x, y])
                    {
                        case 0:
                            Console.Write("□ ");
                            break;

                        case 1:
                            Console.Write("■ ");
                            break;
                        case 2:
                            Console.Write("X ");
                            break;
                        case 3:
                            Console.Write("$ ");
                            break;
                        case 9:
                            Console.Write("★ ");
                            break;
                    }

                }
                Console.WriteLine();
            }


            // 가변 배열

            string[][] raid = new string[3][];

            raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };
            raid[1] = new string[] { "도적", "전사", "힐러" };
            raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" };


            Console.WriteLine("\n=== 레이드 파티 구성 ===");
            for (int i = 0; i < raid.Length; i++)
            {
                Console.WriteLine($"파티: {i + 1} ({raid[i].Length}명)");
                for (int j = 0; j < raid[i].Length; j++)
                {
                    Console.WriteLine($" - {raid[i][j]}");
                }
            }


        }
    }
}
