using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260114_Mission
{

    // 부모 클래스 - 동물
    // 자식 클래스 - 육상 동물 / 수생 동물
    

    public class Animals
    {
        public string name;
        public string food;


        public Animals(string name, string food)
        {
            this.name = name;
            this.food = food;
        }

        public virtual void Info()
        {
            Console.WriteLine();
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"먹이: {food}");
        }
    }


    public class TerrestrialAnimals : Animals
    {
        public string habitat;

        public TerrestrialAnimals(string name, string food) : base(name, food)
        {
            habitat = "land";
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"서식지: {habitat}");
        }
    }

    public class aquaticAnimals : Animals
    {
        public string habitat;

        public aquaticAnimals(string name, string food) : base(name, food)
        {
            habitat = "water";
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"서식지: {habitat}");
        }
    }



    internal class Mission_1
    {
        static void Main(string[] args)
        {

            Animals Monkey = new TerrestrialAnimals("Monkey", "Fruit");
            Animals Lion = new TerrestrialAnimals("Lion", "Meet");

            Monkey.Info();
            Lion.Info();

            Animals Whale = new aquaticAnimals("Whale", "Krill");
            Animals Fish = new aquaticAnimals("Fish", "plankton");

            Whale.Info();
            Fish.Info();

            // 개구리는 뭍에서도 산다.
            Animals Frog = new aquaticAnimals("Frog", "Bug");

            if(Frog is aquaticAnimals)
            {
                aquaticAnimals frog = (aquaticAnimals)Frog;
                frog.habitat = "water and land";
                frog.Info();
                Frog.Info();
            }
            
            

        }
    }
}
