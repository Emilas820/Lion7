using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Mission3
    {
        static void Main(string[] args)
        {
            Console.Write("값를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());
            bool isPrimeNum = Checker(input);

            Console.WriteLine(isPrimeNum == true ? "이 값은 소수입니다" : "이 값은 소수가 아닙니다.");
        }

        static bool Checker(int input)
        {
            bool temp = false;
            bool result = true;

            if (input != 1)
            {
                for (int i = 2; i <= input - 1; i++)
                {
                    if (input % i == 0)
                    {
                        temp = false;
                    }
                    else
                    {
                        temp = true;
                    }
                    if (temp == false)
                        result = false;
                }
                if (result == true) return true;
                else return false;
            }
            else return false;


        }
    }
}
