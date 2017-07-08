/*
어댑터패턴 = 연관성없는 두 객체 묶어 사용하기
- 알고리즘을 요구사항에 맞춰 사용할 수 있다.
- 알고리즘을 수정하지 않고 추가로 구현이 가능하다.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdapter adapter = new AdapterImplement();


            Console.WriteLine(adapter.TwiceOf(100f));
            Console.WriteLine(adapter.HalfOf(88f));
            Console.WriteLine(adapter.TwiceOf(120f));


        }
    }
}
