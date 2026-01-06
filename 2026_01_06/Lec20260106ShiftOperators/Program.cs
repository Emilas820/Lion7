using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec20260106ShiftOperators
{
    internal class ShiftOperatorsTest
    {
        static void Main(string[] args)
        {
            // Lecture 16: 시프트 연산자

            int value = 4; // 0101

            string binary = Convert.ToString(value << 1, 2);
            Console.WriteLine(binary.PadLeft(8, '0')); // 1000

            binary = Convert.ToString(value >> 1, 2);
            Console.WriteLine(binary.PadLeft(8, '0')); // 0010

            // Mission 16: 시프트 연산자를 활용하여 인벤토리 구현

            int inventory = 0; // 0000 0000
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            // 슬롯 번호
            int slot1 = 1; //활
            int slot2 = 2; // 지팡이

            // 슬롯 0에 활 추가
            inventory = inventory | (1 << slot1); // inventory의 'slot1'칸에 1을 덮어써라
            Console.WriteLine($"슬롯 {slot1}에 활 추가");
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            // 슬롯 0에 활 추가
            inventory = inventory | (1 << slot2); // inventory의 'slot2'칸에 1을 덮어써라
            Console.WriteLine($"슬롯 {slot2}에 지팡이 추가");
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

        }
    }
}
