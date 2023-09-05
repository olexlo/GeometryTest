using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTest
{
    public class Square
    {
        public double CalculatePerimeter(double a)
        {
            return Geometry.SquarePerimeter(a);
        }

        public double CalculateArea(double a)
        {
            return Geometry.SquareArea(a);
        }
        public double CalculateVolumeCoub(double a)
        {
            return CalculateArea(a) * a;
        }
        
        
    }
}

