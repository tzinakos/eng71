using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public abstract class Weapon : IShootable
    {
        private string _brand;

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return $"Shooting a {ToString()} - {_brand}";

        }


        public override string ToString()
        {
            return base.ToString();
        }

      


    }
}
