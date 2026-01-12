using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Mission2
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());
            string playerGrade = grader(score);

            Console.WriteLine($"당신은 {playerGrade}등급 입니다.");
        }

        static string grader (int score)
        {
            if(score>= 90)
            {
                return "A";
            }else if(score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
