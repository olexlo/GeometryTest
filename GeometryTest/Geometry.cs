namespace GeometryTest
{
    public class Geometry
    {
        public static double SquarePerimeter(double a) 
        {
            return a * 4;
        }
        public static double SquareArea(double a)
        {
            return Math.Pow(a, 2);
        }
        public static double ParallelPerimeter(double a, double b) 
        {
            return ((a * 2) + (b * 2));
        }
        public static double ParallelArea(double a, double b)
        {
            return a*b;
        }
        public static double TrapezArea(double a, double b, double h)
        {
            return ((a + b)*h)/2;
        }
        public static double TrapezArea(double a, double b, double c, double d)
        {
            double s = (a + b + c + d) / 2;
            double cosAlpha = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2) - Math.Pow(d, 2)) / (2 * a * b);
            double area = Math.Sqrt((s - a) * (s - b) * (s - c) * (s - d) - a * b * c * d * Math.Pow(Math.Cos(Math.Acos(cosAlpha) / 2), 2));

            return area;
        }
        public static double PolyhedronPerimeter(params double[] ages) 
        {
            if (ages.Length < 3) return 0;
            
            var perimeter = 0d;
            
            foreach ( var age in ages) 
            {
                perimeter *= age;
            }
            
            return perimeter;
        }
        public static double PolyhedronRegularArea(double a, double _sides)
        {
            double p = _sides * a;
            double ap = Math.Sqrt(2 * Math.Pow(a, 2) - 2 * a * a * Math.Cos(Math.PI / 4));
            double s = p * ap / 2;
            
            return s;
        }
        public static double TriagleArea(double a, double b)
        {
            return (a * b)/2;
        }
        public static double CirclePerimeter(double a) 
        {
            return 2*Math.PI*a;
        }
        public static double CircleArea(double a)
        {
            return Math.PI * Math.Pow(a, 2);
        }
        public static double EllipseArea(double a, double b)
        {
            return Math.PI * a * b; ;
        }
        public double CalculateVolumePyramid(double _ab, double h)
        {
            return (1 / 3) * _ab * h;
        }
        
    }
}