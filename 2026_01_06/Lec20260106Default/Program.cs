using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106Default
{
    internal class DefaultTest
    {
        static void Main(string[] args)
        {
            // Lecture 5: default 키워드를 사용한 기본값 설정

            int defaultInt = default;
            string defaultString = default;
            bool defaultBool = default;

            Console.WriteLine($"정수 기본값: {defaultInt}");
            Console.WriteLine($"문자열 기본값: {defaultString}");
            Console.WriteLine($"논리값 기본값: {defaultBool}");
        }
    }
}
