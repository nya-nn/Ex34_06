using ShapeSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal struct Hexagon:IShape
    {
        private float side;
        public Hexagon(float side)
        {
            this.side = side;
        }
        public float Width { get{ return side * 2; } }
        public float Height { get { return side * (float)(Math.Sqrt(3)); } }
        public float Surface { get { return side * side * (float)(Math.Sqrt(3)) * 3 / 2; } }
        public float Circumference { get { return side * 6; } }
    }
}
