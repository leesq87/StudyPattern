using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern
{
    class Character
    {
        //접근점
        private IWeapon iWeapon;

        //교환가능
        public void SetWeapon(IWeapon iWeapon)
        {
            this.iWeapon = iWeapon;
        }


        public void Attack()
        {
            if (iWeapon == null)
            {
                Console.WriteLine("default attack..");
            }
            else {
                iWeapon.Attack();
            }
        }
    }
}
