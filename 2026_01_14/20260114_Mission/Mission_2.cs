using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _20260114_Mission
{
    // 부모 - 제품, 자식 - 유제품 / 육류, 손자 - 치즈 원유 / 돼지고기 닭고기 

    public class Product
    {
        public string name;
        public double price;

        public double DC;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual void Info()
        {
            Console.WriteLine();
            Console.WriteLine($"제품 이름: {name}");
            Console.WriteLine($"제품 가격: {price}");
        }
    }

    // 유제품

    public class DairyProduct   : Product
    {
        public string sth_1;

        public DairyProduct(string name, int price) : base(name, price)
        {
            sth_1 = "Dairy";
            DC = 0.5;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"상위 분류: {sth_1}");
            Console.WriteLine($"할인가: {price * DC}");
        }
    }
    public class Cheese : DairyProduct
    {
        public string sth_2;
        public Cheese(string name, int price) : base(name, price)
        {
            sth_2 = "Cheese";
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"하위 분류: {sth_2}");
        }
    }
    public class Milk : DairyProduct
    {
        public string sth_2;
        public Milk(string name, int price) : base(name, price)
        {
            sth_2 = "Milk";
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"하위 분류: {sth_2}");
        }
    }


    // 육류

    public class MeetProduct : Product
    {
        public string sth_1;

        public MeetProduct(string name, int price) : base(name, price)
        {
            sth_1 = "Meet";
            DC = 1.0;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"상위 분류: {sth_1}");
            Console.WriteLine($"할인가: {price * DC}");
        }
    }

    public class Pork : MeetProduct
    {
        public string sth_2;

        public Pork(string name, int price) : base(name, price)
        {
            sth_2 = "Pork";
            DC = 0.9;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"하위 분류: {sth_2}");
        }
    }
    public class Chicken : MeetProduct
    {
        public string sth_2;

        public Chicken(string name, int price) : base(name, price)
        {
            sth_2 = "Chicken";
            DC = 0.7;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"하위 분류: {sth_2}");
        }
    }




    internal class Mission_2
    {
        static void Main(string[] args)
        {
            Product kkiri = new Cheese("끼리 치즈", 3900);
            Product GoodMilk = new Milk("굿밀크", 2000);
            kkiri.Info();
            GoodMilk.Info();

            Product ChickenWing = new Chicken("닭날개", 990);
            Product Bacon = new Pork("베이컨", 5000);
            ChickenWing.Info();
            Bacon.Info();
        }
    }
}
