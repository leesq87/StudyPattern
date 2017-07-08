/*
인터페이스
- 기능에 대한 선언과 구현 분리
- 기능을 사용하는 통로

델리게이트 
- 위임하다 (떠넘기다)
- C#의 delegate와 비슷하나, delegate , action, func는 콜백에 많이 씌임

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Character myCharacter = new Character();

            myCharacter.Attack();

            myCharacter.SetWeapon(new Sword());
            myCharacter.Attack();

            myCharacter.SetWeapon(new Knife());
            myCharacter.Attack();

            myCharacter.SetWeapon(new Ax());
            myCharacter.Attack();
            myCharacter.Attack();
            myCharacter.Attack();

        }
    }
}
