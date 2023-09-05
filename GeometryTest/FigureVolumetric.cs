using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTest
{
    public class FigureVolumetric
    {
        public double CalculateVolumeAllParallel(double _area, double h)
        {
            return _area * h;
        }
        public double CalculateVolumeParallel(double a,double b, double h)
        {
            return Geometry.ParallelArea(a,b) * h;
        }
        public double CalculateVolumeCoub(double a)
        {
            return Geometry.SquareArea(a) * a;
        }
        public double CalculateVolumeTriaglePyramid(double a, double b, double h) 
        {
            return Geometry.TriagleArea(a,b) * h * (1/3);
        }
        public double CalculateVolumePyramid(double a, double h)
        {
            return Geometry.SquareArea(a) * h * (1 / 3);
        }
        public double CalculateVolumePyramid(double a, double b, double h)
        {
            return Geometry.ParallelArea(a,b) * h * (1 / 3);
        }
        public double CalculateVolumeAllPyramid(double _area, double h)
        {
            return _area * h * (1 / 3);
        }
        public double CalculateVolumeBall(double a) 
        {
            return (4/3)*Math.PI*Math.Pow(a,3);
        }
    }
}
