using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person
    {
        private string _camera;
        private double _health =100;
        private Point3D _position;

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

        public Hunter(string fName, string lName, Point3D position, string camera="") : base(fName, lName)
        {
            _camera = camera;
            _position = position;
            
        }
        public Hunter() { }
        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }

        
    }
    //public class SDET : Hunter
    //{
    //    public string IDE { get; set; }
    //}
}
