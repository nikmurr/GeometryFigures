using System;

namespace GeometryFigures
{
    public class Pyramid : BaseObject
    {
        public Pyramid(double length, double width, double depth, double weight)
        : base(length, width, depth, weight)
        { }

        public override string Type
        {
            get { return "Пирамида"; }
        }

        public override double CalculateVolume()
        {
            Volume = (1 / 3.0) * Math.Pow(Length, 2) * Depth;
            return Math.Round(Volume, 4);
        }

        public override double CalculateArea()
        {
            Area = Length * (Length + Math.Sqrt(Math.Pow(Depth, 2) + Math.Pow(Length / 2.0, 2)));
            return Math.Round(Area, 4);
        }
    }

}
