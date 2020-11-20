using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Point3D
    {
        /// x Axis Is Forwards, Backwards
        /// Y Axis Is Left, Right
        /// Z Axis Is Up, Down
        private int _x, _y, _z;

        public int X 
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public Point3D(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
    }
}
