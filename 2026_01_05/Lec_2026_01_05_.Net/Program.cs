using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2026_01_05_.Net
{
    internal class DotNetTest
    {
        static void Main(string[] args)
        {
            System.Int32 number = 1234;         //int의 .NET 형식, System.Int32를 int로 간략하게 표현 가능
            System.String text = "Hello";       //string의 .NET 형식, System.String을 string으로 간략하게 표현 가능
            System.Boolean flag = true;         //bool의 .NET 형식, System.Boolean을 bool로 간략하게 표현 가능
                                                
            System.Console.WriteLine(number);   //using System 생략 가능 (상단에 선언함)
            Console.WriteLine(text);
            Console.WriteLine(flag);
        }
    }
}
