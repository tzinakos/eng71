using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person, IShootable
    {
        private string _camera;
        private double _health =100;
        private Point3D _position;
        private IShootable _shootable;
        public double Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public Point3D Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public IShootable Shootable
        {
            get { return _shootable; }
            set { _shootable = value; }
        }

        public Hunter(string fName, string lName, Point3D position, IShootable shootable) : base(fName, lName)
        {
            _shootable = shootable;
            _position = position;
            
        }
        public Hunter() { }
        public string Shoot()
        {
            return $"{GetFullName()}: {_shootable.Shoot()}";
        }

        
    }
    //public class SDET : Hunter
    //{
    //    public string IDE { get; set; }
    //}
}
