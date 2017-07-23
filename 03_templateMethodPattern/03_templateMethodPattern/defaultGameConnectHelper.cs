using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_templateMethodPatternProcess
{
    public class defaultGameConnectHelper : AbstGameConnectHelper
    {
        protected override bool Authentication(string id, string password)
        {
            Console.WriteLine("아이디 / 암호확인과정");
            return true;
        }

        protected override int Authorization(string userName)
        {
            Console.WriteLine("권한 확인");
            //서버에서 유저이름으로 유저의 나이를 알아서 check
            return 0;
        }

        protected override string Connection(string info)
        {
            Console.WriteLine("마지막 접속 단계");
            return "b";
        }

        protected override string DoSecurity(string str)
        {
            //Console.WriteLine("디코드");
            Console.WriteLine("강화된 디코드...");


            return "a";
        }
    }
}
