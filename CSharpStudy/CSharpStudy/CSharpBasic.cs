using FirstLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class CSharpBasic
    {
        static void Main(string[] args)
        {
            short shortNum = 0;

            int intNum = 0;

            double doubleNum = 0;

            float floatNum = 0;

            string stringText = "";

            char charText = 'a';

            bool boolVal = true;

            Int16 dotNetShort = 0; // Int16와 같은 닷넷 언어를 잘 쓰지 않음

            Int32 dotNetInt = 0;

            Int64 dotNetDouble = 0;

            String dotNetString = "";

            var dynamicType = 0; // var는 알아서 지정됨

            // ctrl k c ==> 주석 처리
            // ctrl k u ==> 주석 해제

            var num1 = 1;
            var num2 = 2;

            Console.WriteLine(num1 + num2);

            Console.WriteLine("========================");

            ////////////////////////////////////////////////
            // if문

            var num = 1;

            Console.Write("0 ~ 9 사이의 값을 입력 : ");

            var input = Console.ReadLine(); // 콘솔창에서 값 입력하기

            if (num.ToString() == input) // 중괄호 아래로 내려서 사용하기(ms 권장) - 코드 정리 ctrl+k+d
            {
                Console.WriteLine("같은 값을 입력했습니다.");
            }
            else
            {
                Console.WriteLine("다른 값을 입력했습니다.");
            }

            //if (num.ToString() == input) 
            //{
            //    Console.WriteLine("같은 값을 입력했습니다.");
            //}
            //else if(num.ToString() != input)
            //{
            //    Console.WriteLine("다른 값을 입력했습니다.");
            //}

            Console.WriteLine("========================");

            ////////////////////////////////////////////////
            // while 문
            while (true)
            {
                num++;

                if (num % 3 == 0)
                {
                    continue;
                }

                Console.WriteLine(num);

                if (num == 100)
                {
                    break;
                }
            }

            Console.WriteLine("========================");

            num = 1;

            do
            {
                Console.WriteLine(num++);
            } while (num <= 10);

            Console.WriteLine("========================");

            ////////////////////////////////////////////////
            // for문

            //for(num = 1; num<=5; num++)
            //{
            //    Console.WriteLine(num);
            //}

            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            //numberList.Add(4);
            //numberList.Add(5);

            //foreach (var num3 in numberList)
            //{
            //    Console.WriteLine(num3);
            //}

            for (var index = 0; index < numberList.Count; index++)
            {
                Console.WriteLine(numberList[index]);
            }

            Console.WriteLine("========================");

            ////////////////////////////////////////////////
            // list

            // Generic List
            List<string> list = new List<string>();
            list.Add("text1");
            list.Add("text2");
            list.Add("text3");
            list.Add("text4");
            list.Add("text5");

            foreach (var text in list)
            {
                Console.WriteLine(text);
            }

            Console.WriteLine("========================");

            var list1 = new List<int>();

            // 선언과 동시에 값을 초기화 시킬 수 있다
            var list2 = new List<string>()
            {
                "text1",
                "text2",
                "text3",
                "text4",
                "text5"
            };

            foreach (var text2 in list2)
            {
                Console.WriteLine(text2);
            }

            Console.WriteLine("========================");

            ////////////////////////////////////////////////
            // 번호 이름 나이 연락처
            // 01  김가나 20 010-1234-1234
            // 게터세터 만들기 -> User.cs

            // 이렇게 만들어줘도 되고
            //var user1 = new User()
            //{
            //    No = 1,
            //    Name = "김가나",
            //    Age = 30,
            //    Phone = "010-1234-1234"
            //};

            //var user2 = new User()
            //{
            //    No = 2,
            //    Name = "김다라",
            //    Age = 30,
            //    Phone = "010-4321-4321"
            //};

            // 다음과 같이 만들어줘도 된다
            var list3 = new List<User>()
            {
                new User()
                {
                    No = 1,
                    Name = "김가나",
                    Age = 30,
                    Phone = "010-1234-1234"
                },
                new User()
                {
                    No = 2,
                    Name = "김다라",
                    Age = 30,
                    Phone = "010-4321-4321"
                }
            };

            foreach (var user in list3)
            {
                Console.WriteLine("번호 : " + user.No + " / " + "이름 : " + user.Name);
            }

            Console.WriteLine("========================");


            ////////////////////////////////////////////////
            // 계산기 불러오기
            Calc calc = new Calc(); // 새로운 객체 생성
            //calc.PrintHello();
            Console.WriteLine(calc.Plus(10, 20));

            ////////////////////////////////////////////////
            // 다른 프로젝트에 있는 객체 부르기
            FirstClass first = new FirstClass(); // 참조 -> 참조추가 -> 프로젝트에서 다른 프로젝트에 있는 레퍼런스 FirstClass를 추가해주고 using에 작성해 주어야 한다, ctrl+. 으로 using FirstLibaray를 사용하면 훨씬 빠르게 사용 가능
            first.FirstClassPrint();

        }
    }
}
