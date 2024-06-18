using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class WeaponFactory
    {
        public static IWeapon GetWeapon(string weaponChoice)
        {
            switch (weaponChoice.ToLower())
            {
                case "sword":
                    return new LongSword();
                case "axe":
                    return new DaneAxe();
                default:
                    return new LongSword();
            }
        }
    }
}
