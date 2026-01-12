using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Mission5
    {
        static void Main(string[] args)
        {
            int level = 0;

            while (level < 10)
            {
                Console.WriteLine("강화하려면 엔터를 눌러주세요.");
                Console.ReadLine();
                level = Reinforce(level);
                Console.WriteLine($"현재 강화 레벨: {level}");
            }
        }

        static int Reinforce(int level)
        {
            Random rnd = new Random();

            int result = rnd.Next(0, 101);

            if(result <= (101 - (level * 10))*0.3 && result > 0)
            {
                Console.WriteLine($"강화 성공 !");
                return level+1
                    ;
            }
            else
            {
                Console.WriteLine($"강화 실패...");
                return level;
            }
        }
    }
}
