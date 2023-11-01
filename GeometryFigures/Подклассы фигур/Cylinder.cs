using System;

namespace GeometryFigures
{
    public class Cylinder : BaseObject
    {
        public Cylinder(double length, double width, double depth, double weight)
        : base(length, width, depth, weight)
        {
            this.Width = Length;
        }

        public override string Type
        {
            get { return "Цилиндр"; }
        }

        public override double CalculateVolume()
        {
            Volume = Math.PI * Math.Pow(Length / 2.0, 2) * Depth;
            return Math.Round(Volume, 4);
        }

        public override double CalculateArea()
        {
            Area = 2 * Math.PI * Math.Pow(Length / 2.0, 2) + 2 * Math.PI * (Length / 2.0) * Depth;
            return Math.Round(Area, 4);
        }
    }

}
