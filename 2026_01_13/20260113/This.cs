using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260113
{
    class Skill
    {
        private string name;
        private int atk;

        public Skill()
        {

        }

        public Skill(string name, int atk)
        {
            this.name = name;   // 변수 이름이 충돌하는 경우 사용. ( This 붙은 게 생성된 객체의 것. )
            this.atk = atk;
        }

        public void SkillStart()
        {
            Console.WriteLine("스킬 이름: " + this.name);   // 이건 사실 생략해도 됨
            Console.WriteLine("스킬 데미지: " + this.atk);
        }
    }
    internal class This
    {
        static void Main(string[] args)
        {
            Skill s = new Skill("블리자드", 1000000);
            s.SkillStart();
        }
    }
}
