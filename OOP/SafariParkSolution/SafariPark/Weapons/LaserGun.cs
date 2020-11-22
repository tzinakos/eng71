using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class LaserGun : Weapon
    {
       

        public LaserGun(string brand) : base(brand)
        {
            
        }

        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }





    }
}
