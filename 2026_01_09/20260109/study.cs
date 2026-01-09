using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260109
{
    internal class study
    {
        static void Main(string[] args)
        {
            // Mission: 성적표

            Console.WriteLine("\n=== 성적표 ===");

            string[] name = { "김철수", "이영희", "박민수" };
            string[] course = { "국어", "영어", "수학", "과학" };
            int[,] scores =
            {
                { 85, 90, 88, 92 },
                { 78, 85, 90, 87 },
                { 92, 88, 95, 90 }
            };

            int[] courseAvr = new int[course.Length];

            Console.WriteLine($"이름   {course[0]}   {course[1]}   {course[2]}   {course[3]}   평균");
            Console.WriteLine("------------------------------------------");

            for (int col = 0; col < name.Length; col++)
            {
                int sum = 0;
                Console.Write($"{name[col]}  ");
                for (int row = 0; row < course.Length; row++)
                {
                    Console.Write($"{scores[col, row]}점   ");
                    sum += scores[col, row];
                    courseAvr[row] += scores[col, row];
                }

                Console.WriteLine($"{(double)sum / (double)course.Length:F1}");
                Console.WriteLine("\n");
            }

            //for (int i = 0; i < course.Length; i++)
            //{
            //    Console.WriteLine($"{course[i]}: {courseAvr[i]}");
            //}

            Console.WriteLine("\n=== 과목별 평균 ===");
            for(int i = 0;i < course.Length; i++)
            {
                Console.WriteLine($"{course[i]}: {(double)courseAvr[i]/ (double)name.Length:F1}점");
            }
            
        }
        

    }
}
