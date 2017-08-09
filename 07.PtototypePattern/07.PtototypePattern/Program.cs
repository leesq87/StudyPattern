using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
복잡한 인스턴스를 복사한다.

    인스턴스 생산비용이 높은경우
    -> 종류가 너무 많아서 클래스로 정리가 안되는경우
    클래스로부터 인스턴스 생성이 어려운 경우 (??)



    요구사항
    일러스트레이터와 같은 그림 그리기툴을 개발중입니다.
    모양을 그릴수 있도록 하고 복사 붙여넣기 기능을 구현해주세요.

*/
namespace _07.PtototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(1,1,3);

            Circle circle2 = circle1.copy();

            Console.WriteLine("{0} , {1} , {2}", circle1.X, circle1.Y, circle1.R);

            Console.WriteLine("{0} , {1} , {2}", circle2.X, circle2.Y, circle2.R);


        }
    }
}
