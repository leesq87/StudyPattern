using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    객체란?
    객체 : 속성과 기능을 갖춘것
    클래스 : 속성과 기능을 정의한것
    인스턴스 : 속성과 기능을 가진 것 중 실제하는것



    요구사항
    개발중인 시스템에서 스피커에 접근 할 수 있는 클래스를 만들어 주세요.


*/

namespace _05_SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemSpeaker speker1 = SystemSpeaker.GetInstance();
            SystemSpeaker speker2 = SystemSpeaker.GetInstance();


            Console.WriteLine(speker1.GetVolume());
            Console.WriteLine(speker2.GetVolume());


            speker1.SetVolume(11);

            Console.WriteLine(speker1.GetVolume());
            Console.WriteLine(speker2.GetVolume());

            speker2.SetVolume(16);

            Console.WriteLine(speker1.GetVolume());
            Console.WriteLine(speker2.GetVolume());

        }
    }
}
