using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_templateMethodPatternProcess;


/* 템플릿 메소드 패턴
알고리즘의 구조를 메소드에 정의하고 하위 클레스에서 알고리즘 구조의 변경없이 알고리즘을 재정의 하는 패턴


구현하려는 알고리즘이 일정한 프로세스가 있는경우
구현하려는 알고리즘이 변경 가능성이 있는경우

->알고리즘을 여러 단계로 나눈다
-> 나눠진 알고리즘의 단계를 메소드로 선언한다
-> 수행할 템플릿 메소드를 만든다
-> 나눠진 메소드들을 구현한다.
*/




/* Ex
    게임 접속을 구현 (requestConnection(string str)) / return string
    보안과정 (doSecurity(string string)) / return stirng
    인증과정 (authentication(string id, string passworld)) return bool 
    권한과정 (authorization (string userName)) / return int
    접속과정 (connection(string info)) / return string


*/



namespace _03_templateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstGameConnectHelper helper = new defaultGameConnectHelper();

            helper.RequestConnection("info");
        }
    }
}
