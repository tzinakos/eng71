using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public  class Bow : Weapon
    {
       private int _numOfArrows, _damage=20;

        public int NumOfArrows
        {
            get { return _numOfArrows; }
            set { _numOfArrows = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Bow(string brand, int numOfArrows) : base(brand)
        {
            _numOfArrows = numOfArrows;   
        }

        public override string Shoot()
        {
            if (NumOfArrows >= 1)
            {
                _numOfArrows--;
                return $"Splash!! {base.Shoot()}";
               
            }
            else return "O oh, Not enough Arrows";
        }





    }
}
