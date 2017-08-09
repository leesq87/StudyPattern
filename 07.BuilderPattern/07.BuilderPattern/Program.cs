using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*

    학습목표 
    복잡한 단계가 필요한 인스턴트 생성을 빌더 패턴을 통해서 구현 할 수 있다.

    템플렛 메소드랑 비슷한느낌

    복잡한 단계를 거쳐야 생성되는 객체의 구현을 서브클래스에 넘겨주는 패턴


*/




namespace _07.BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ComputerFactory factory = new ComputerFactory();
            factory.SetBlueprint(new LgGramBlueprint());
            //factory.SetBlueprint(new MacAirBlueprint());
            //factory.SetBlueprint(new SonyBlueprint());

            factory.Make();
            //factory.GetComputer();

            //Computer computer = new Computer("i7", "16g", "256g ssd");
            Computer computer = factory.GetComputer();

            Console.WriteLine(computer.ToString());


        }
    }
}
