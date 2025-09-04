using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252JP.Shapes
{
    internal class Rectangle
    {
        private float b;
        private float h;

        public Rectangle(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float GetArea()
        {
            return b * h;
        }
    }
}
