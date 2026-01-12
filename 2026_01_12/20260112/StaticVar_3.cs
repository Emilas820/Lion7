using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260112
{
    internal class StaticVar_3
    {
        static int HP = 100;

        static void Attack()
        {
            HP--;
        }

        static void Main(string[] args)
        {
            Attack();
            Console.WriteLine("HP: " + HP);
        }
    }
}
