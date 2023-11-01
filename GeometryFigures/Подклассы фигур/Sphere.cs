using System;

namespace GeometryFigures
{
    public class Sphere : BaseObject
    {
        public Sphere(double length, double width, double depth, double weight)
        : base(length, width, depth, weight)
        { }

        public override string Type
        {
            get { return "Сфера"; }
        }

        public override double CalculateVolume()
        {
            Volume = (4 / 3) * Math.PI * Math.Pow(Length / 2, 3);
            return Math.Round(Volume, 4);
        }

        public override double CalculateArea()
        {
            Area = 4 * Math.PI * Math.Pow(Length / 2, 2);
            return Math.Round(Area, 4);    
        }
    }

}
