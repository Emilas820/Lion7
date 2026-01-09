using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260109
{
    internal class List_1
    {
        static void Main(string[] args)
        {
            // 동적 배열 List

            List<int> numbers = new List<int>();
            List<string> names = new List<string>();
            List<float> price = new List<float>();

            // 초기값과 함께 선언

            List<int> scores = new List<int> { 85, 90, 78, 95 };
            List<string> items = new List<string> { "검", "방패", "포션" };

            items.Add("회복 포션");
            items.Add("마나 포션");


            // 실습: List 생성

            List<string> inventory = new List<string>();

            Console.WriteLine("\n=== 도적 인벤토리 시스템 ===");

            // 아이템 추가 (Add)
            inventory.Add("회복 포션");
            inventory.Add("마나 포션");
            inventory.Add("강철 검");
            // List는 Add로 박스를 생성 후 변수를 변경할 수 있다.

            Console.WriteLine("아이템 3개 추가");

            // 현재 인벤토리
            Console.WriteLine($"인벤토리 ({inventory.Count}개)");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

            // 배열 변경
            Console.WriteLine("\n");

            inventory[0] = "알사탕";

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

            // 특정 위치에 추가 (Insert) - 칸 자체가 삽입되어 배열이 한 칸 늘어났다.
            Console.WriteLine("\n");
            inventory.Insert(1, "전설의 검");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

            // 제거 Remve - 칸 자체가 삭제되어 배열이 한 칸 줄었다.
            Console.WriteLine("\n");
            inventory.Remove("알사탕");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }


            // Index로 제거 (RemoveAt)
            Console.WriteLine("\n");
            inventory.RemoveAt(0);

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }



        }
    }
}
