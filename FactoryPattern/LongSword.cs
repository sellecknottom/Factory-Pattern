﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class LongSword : IWeapon
    {
        public void Forge()
        {
            Console.WriteLine("Forging a long sword...");
        }
    }
}
