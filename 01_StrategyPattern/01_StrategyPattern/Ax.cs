using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern
{
    class Ax : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Ax Attack..");
        }
    }
}
