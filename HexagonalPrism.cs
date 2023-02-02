using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class HexagonalPrism:Column
    {
        public HexagonalPrism(float side, float height) : base(new Hexagon(side), height)
        {
            this.height = height;
        }
        static public float GetVolume(float radius, float height)
        {
            return (float)(new HexagonalPrism(radius, height).Volume);
        }
        static public float GetSurface(float radius, float height)
        {
            return (float)(new HexagonalPrism(radius, height).Surface);
        }
    }
}
