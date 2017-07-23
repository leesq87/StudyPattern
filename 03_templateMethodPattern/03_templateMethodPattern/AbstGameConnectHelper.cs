using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_templateMethodPatternProcess
{
    public abstract class AbstGameConnectHelper
    {

        //알고리즘 단계이기에 외부에 노출되면 안된다.
        protected abstract string DoSecurity(string str);
        protected abstract bool Authentication(string id, string password);
        protected abstract int Authorization(string userName);
        protected abstract string Connection(string info);

        public string RequestConnection(string encodedInfo)
        {
            //보안작업 -> 암호화 된 문자열을 디코드
            string decodedInfo = DoSecurity(encodedInfo);


            //반환된 것을 가지고 id, password를 할당한다.
            string id = "aaa";
            string password = "bbb";

            //Authentication(id, password);
            if (Authentication(id, password))
            {
                Console.WriteLine("아이디 암호 일치");
            }


            string userName = "userName";
            int i = Authorization(userName);

            switch (i)
            {
                case -1:
                    Console.WriteLine("시간제한..");
                    break;

                case 0:
                    Console.WriteLine("game manager");
                    break;
                case 1:
                    Console.WriteLine("유료회원");
                    break;
                case 2:
                    Console.WriteLine("무료회원");
                    break;
                case 3:
                    Console.WriteLine("권한 없음");
                    break;
                default:
                    Console.WriteLine("etc");
                    break;

            }


            return "c";
        }


    }
}
