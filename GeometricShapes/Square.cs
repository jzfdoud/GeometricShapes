using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Square
    {

        public int Side1;

        public int Perimeter()
        {
            return 4 * Side1;
        }

        public int Area()
        {
            return Side1 * Side1;
        }

        public Square() { }
        public Square(int s1)
        {
            Side1 = s1;
        }
    }
}
