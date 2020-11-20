using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public abstract class Shape
    {

        public abstract int CalculateArea();
    }

    public sealed class Rectangle : Shape
    {
        private int _width, _height;
        public override int CalculateArea()
        {
            return _width * _height;
        }
    }
}
