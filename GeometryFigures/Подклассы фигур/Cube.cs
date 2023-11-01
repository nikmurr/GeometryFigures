using System;

namespace GeometryFigures
{
    public class Cube : BaseObject
    {
        public Cube(double length, double width, double depth, double weight)
        : base(length, width, depth, weight)
        {
            this.Width = Length;
            this.Depth = Length;
        }

        public override string Type
        {
            get { return "Куб"; }
        }

        public override double CalculateVolume()
        {
            Volume = Math.Pow(Length, 3);
            return Math.Round(Volume, 4);
        }

        public override double CalculateArea()
        {
            Area = 6 * Math.Pow(Length, 2);
            return Math.Round(Area, 4);
        }
    }

}
