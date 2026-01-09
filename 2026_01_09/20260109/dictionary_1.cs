using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260109
{
    internal class dictionary_1
    {
        static void Main(string[] args)
        {
            // Lecture 4 dictionary 문

            Dictionary<string, int> status = new Dictionary<string, int>();
            // " Dictionary<Key 값, Value 값> 변수명 "으로 선언. status[key값]으로 해당 배열 내 변수를 사용할 수 있다.

            // 데이터 추가
            status.Add("HP", 150);
            status.Add("MP", 150);
            status.Add("ATK", 150);
            status.Add("DEF", 150);
            status.Add("DEX", 150);

            // for 문 돌리는 법

            Console.WriteLine("\n=== 캐릭터 스텟 ===");
            foreach (KeyValuePair<string, int> stat in status)
            {
                Console.WriteLine($"{stat.Key}: {stat.Value}");
            }

            // 키 존재 확인
            string searchStat = "DEF";

            if (status.ContainsKey(searchStat))
            {
                Console.WriteLine(status[searchStat]);
            }
            else
            {
                Console.WriteLine("해당 스텟이 없습니다.");
            }

            Console.WriteLine("=== 상점 아이템 ===");

            Dictionary<string, int> items = new Dictionary<string, int>();

            int currentGold = 100;

            items.Add("회복 포션", 50);
            items.Add("마나 포션", 40);
            items.Add("강철 검", 500);
            items.Add("가죽 갑옷", 300);
            items.Add("마법 반지", 1000);

            foreach (KeyValuePair<string, int> i in items)
            {
                Console.WriteLine($"{i.Key}: {i.Value}G");
            }

            Console.Write("구매하실 아이템을 선택하세요.");
            string input = Console.ReadLine();

            if (currentGold < items[input])
            {
                Console.WriteLine("구매할 수 없습니다.");
            }
            else
            {
                Console.WriteLine($"'{input}' 구매 성공 !");
                currentGold -= items[input];
            }
            Console.WriteLine($"남은 골드: {currentGold}");
        }
    }
}
