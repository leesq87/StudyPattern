﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StrategyPattern
{
    class Knife : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Knife Attack");

        }
    }
}
