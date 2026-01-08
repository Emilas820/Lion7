using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260108Goto
{
    internal class GotoTest
    {
        static void Main(string[] args)
        {
            int n = 1;

        천마귀환: //레이블

            if (n <= 5)
            {
                goto 천마강림;
                Console.WriteLine(n);
                n++;
                goto 천마귀환; //레이블로 이동
            }

        천마강림:
            Console.WriteLine("나 강림");
            
        }

    }
}
