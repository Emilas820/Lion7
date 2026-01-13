using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _20260113
{
    class Students
    {
        private string name;
        private int score;
        public int Score
        {
            get { return score; }
            set
            {
                if (value >= 0 && value <= 100) score = value;
                else { Console.WriteLine("잘못된 값입니다."); }
            }
        }

        public string Grade // 읽기 전용이면 굳이 원본 변수 선언할 필요 없음.
        {
            get
            {
                {
                    if (score >= 90) return "A";
                    else if (score >= 80) return "B";
                    else if (score >= 70) return "C";
                    else if (score >= 60) return "D";
                    else return "F";
                }
            }
        }

        public Students(string _name)
        {
            name = _name;
        }

        public void StudentInfo()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"점수: {score}");
            Console.WriteLine($"등급: {Grade}");
            Console.WriteLine("-----------------------------\n");
        }

    }
    internal class Property_3
    {
        static void Main(string[] args)
        {
            Students student = new Students("홍길동");

            student.Score = 95;
            student.StudentInfo();

            Console.WriteLine();

            student.Score = 75;
            student.StudentInfo();

            Console.WriteLine();

            // 잘못된 값 입력 시도
            student.Score = 150;  // 100으로 제한되어야 함
            student.Score = -10;  // 0으로 제한되어야 함
            student.StudentInfo();
        }
    }
}
