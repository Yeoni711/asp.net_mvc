using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class User
    {
        // 번호, 이름, 나이, 연락처

        public int No { get; set; } // prop + tab + tab 자동 생성
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        // 아래의 코드와 위의 코드가 동일한 기능을 한다
        //private int _no;
        //private string name;

        //public void setNo(int no)
        //{
        //    _no = no;
        //}
        //public int getNo(int no)
        //{
        //    return no;
        //}


    }
}
