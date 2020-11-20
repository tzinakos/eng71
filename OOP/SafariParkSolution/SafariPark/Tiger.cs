using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    class Tiger : Animals
    {
        //fields
        private double _strength = 1;
        
        //properties
        public double Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
        //constructor;

        public Tiger(animalType type, double health, double attackDamage, Point3D position, double strength)
            :  base(type, health, attackDamage, position)
        {
            _strength = strength;
            Health *= Strength;
            AttackDamage *= (Strength / 2);
        }
    }
}
