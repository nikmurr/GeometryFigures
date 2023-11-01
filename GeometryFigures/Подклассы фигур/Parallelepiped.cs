using System;

namespace GeometryFigures
{
    public class Parallelepiped : BaseObject
    {
        public Parallelepiped(double length, double width, double depth, double weight)
        : base(length, width, depth, weight)
        { }

        public override string Type
        {
            get { return "Параллелепипед"; }
        }

        public override double CalculateVolume()
        {
            Volume = Length * Width * Depth;
            return Math.Round(Volume, 4);
        }

        public override double CalculateArea()
        {
            Area = 2 * (Length * Width + Length * Depth + Width * Depth);
            return Math.Round(Area, 4);
        }
    }

}
