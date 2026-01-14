using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260114_2
{// 부모 클래스
    class Parent2
    {
        public virtual void Method()  // virtual: 재정의 가능
        {
            // 기본 구현
        }
    }

    // 자식 클래스
    class Child2 : Parent2
    {
        public override void Method()  // override: 재정의
        {
            // 새로운 구현
        }
    }
    internal class Override_1
    {
        static void Main(string[] args)
        {
            
        }
    }
}
