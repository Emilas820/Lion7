using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lec_2026_01_05_Mission
{
    internal class Mission_2026_01_05
    {
        static void Main(string[] args)
        {
            //// Mssion 1: 딜레이 주기
            //// Therad.Sleep(): 괄호 안의 시간만큼 시스템을 정지 시키는 함수.
            //// 참고 - 1000 = 1sec

            //Console.Write("안");
            //Thread.Sleep(1000);     // 1sec sleep
            //Console.Write("녕");
            //Thread.Sleep(1000);     // 1sec sleep
            //Console.Write("하");
            //Thread.Sleep(1000);     // 1sec sleep
            //Console.Write("세");
            //Thread.Sleep(1000);     // 1sec sleep
            //Console.Write("요");
            //Thread.Sleep(1000);     // 1sec sleep
            //Console.Write(".");
            //Thread.Sleep(1000);     // 1sec sleep
            //Console.Write(".");
            //Thread.Sleep(1000);     // 1sec sleep
            //Console.Write(".");
            //Thread.Sleep(1000);     // 1sec sleep

            //Thread.Sleep(2000);     // 2sec sleep
            //Console.Clear();        // Console 창 클리어

            //// Mission 2: 저번 시간에 만든 UI에 애니메이션 적용하기

            string char1 = "가나";
            string char2 = "다라";
            string char3 = "마바";
            string char4 = "사아";
            string char5 = "자차";
            string char6 = "카타";
            string char7 = "파하";
            string char8 = "기니";
            string char9 = "디리";
            string char10 = "미비";
            string char11 = "시이";

            Thread.Sleep(3000);

            Console.WriteLine("┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛");
            Console.WriteLine($"   {char1}     {char2}     {char3}     {char4}");

            Thread.Sleep(100);

            Console.WriteLine("┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛");
            Console.WriteLine($"   {char5}     {char6}     {char7}     {char8}");

            Thread.Sleep(100);

            Console.WriteLine("┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛");
            Console.WriteLine($"   {char9}     {char10}     {char11}");

            Thread.Sleep(100);

            Console.WriteLine("┏━━┓┏━━━━━━━━━━━━━━━━━━━━━━━━━━┓┏━━┓");
            Console.WriteLine("┃▼ ┃┃ 기본                     ┃┃↑↓┃");
            Console.WriteLine("┗━━┛┗━━━━━━━━━━━━━━━━━━━━━━━━━━┛┗━━┛");

            Thread.Sleep(1000);
            Move(18);

            Console.WriteLine("┏━━┓┏━━━━━━━━━━━━━━━━━━━━━━━━━━┓┏━━┓");
            Console.WriteLine("┃▽ ┃┃ 기본                     ┃┃↑↓┃");
            Console.WriteLine("┗━━┛┗━━━━━━━━━━━━━━━━━━━━━━━━━━┛┗━━┛");

            Thread.Sleep(1000);
            Move(18);

            Console.WriteLine("┏━━┓┏━━━━━━━━━━━━━━━━━━━━━━━━━━┓┏━━┓");
            Console.WriteLine("┃△ ┃┃ 기본                     ┃┃↑↓┃");
            Console.WriteLine("┗━━┛┗━━━━━━━━━━━━━━━━━━━━━━━━━━┛┗━━┛");

            Thread.Sleep(1000);
            Move(18);

            Console.WriteLine("┏━━┓┏━━━━━━━━━━━━━━━━━━━━━━━━━━┓┏━━┓");
            Console.WriteLine("┃▲ ┃┃ 기본                     ┃┃↑↓┃");
            Console.WriteLine("┗━━┛┗━━━━━━━━━━━━━━━━━━━━━━━━━━┛┗━━┛");

            Thread.Sleep(100);
            Move(0);

            Console.WriteLine("┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛");
            Console.WriteLine($"   {char11}     {char10}     {char9}     {char8}");

            Thread.Sleep(100);

            Console.WriteLine("┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛");
            Console.WriteLine($"   {char7}     {char6}     {char5}     {char4}");

            Thread.Sleep(100);

            Console.WriteLine("┏━━━━━━━┓┏━━━━━━━┓┏━━━━━━━┓");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┃       ┃┃       ┃┃       ┃");
            Console.WriteLine("┗━━━━━━━┛┗━━━━━━━┛┗━━━━━━━┛");
            Console.WriteLine($"   {char3}     {char2}     {char1}");

            Thread.Sleep(100);

            Console.WriteLine("┏━━┓┏━━━━━━━━━━━━━━━━━━━━━━━━━━┓┏━━┓");
            Console.WriteLine("┃▲ ┃┃ 기본                     ┃┃↑↓┃");
            Console.WriteLine("┗━━┛┗━━━━━━━━━━━━━━━━━━━━━━━━━━┛┗━━┛");




        }
        static void Move(int y)
        {
            // 1. 커서를 해당 줄의 맨 앞으로 이동
            Console.SetCursorPosition(0, y);

            // 2. 현재 콘솔 가로 너비만큼 공백(' ')을 만들어서 출력
            // Console.WindowWidth는 현재 창의 가로 칸 수입니다.
            Console.Write(new string(' ', Console.WindowWidth));

            // 3. (옵션) 출력이 끝난 후 커서를 다시 해당 줄 맨 앞으로 되돌림
            Console.SetCursorPosition(0, y);
        }
    }
}

