using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Calc
    {
        // Naming Convention(명명 규칙)

        // 자바 메소드
        // C# 메서드

        // 자바 변수 선언 : int num = 0;
        // 메서드 선언 : public void helloHi() 

        // C# 변수 선언 var num = 0;
        // 메서드 선언 : public void HelloHi()

        // 메서드 기본 선언 방식
        // 접근제한자 반환 타입 메서드이름() {}

        public void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }

        public int Plus(int num1, int num2)
        {
            return num1 + num2;
        }
        
    }
}
