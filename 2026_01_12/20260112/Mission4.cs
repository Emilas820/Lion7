using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class Mission4
    {
        static void Main(string[] args)
        {
            Console.Write("현재 경험치: ");
            int curentExp = int.Parse(Console.ReadLine());
            Console.Write("획득한 경험치: ");
            int getExp = int.Parse(Console.ReadLine());
            bool levelUp = false;

            expCounter(curentExp, getExp, out levelUp, out curentExp);

            if (levelUp == true)
            {
                Console.WriteLine($"레벨 업!");
                Console.WriteLine($"현재 경험치: {curentExp}");
            }else
            {
                Console.WriteLine($"현재 경험치: {curentExp}");
            }
        }
        static void expCounter(int currenstExp, int getExp, out bool levelUp, out int currentExp)
        {
            int fullExp = 100;
            levelUp = false;
            

            if (currenstExp + getExp >= fullExp)
            {
                levelUp = true;
                currentExp = currenstExp + getExp - fullExp;
            }
            else
            {
                levelUp = false;
                currentExp = currenstExp + getExp;
            }                    

        }
    }
}
