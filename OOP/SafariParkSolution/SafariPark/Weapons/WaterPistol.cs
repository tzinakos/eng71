﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public  class WaterPistol : Weapon
    {
       

        public WaterPistol(string brand) : base(brand)
        {
            
        }

        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }





    }
}
