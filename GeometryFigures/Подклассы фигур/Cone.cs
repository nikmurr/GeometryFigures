using System;

namespace GeometryFigures
{
    public class Cone : BaseObject
    {
        public Cone(double length, double width, double depth, double weight)
        : base(length, width, depth, weight)
        { }

        public override string Type
        {
            get { return "Конус"; }
        }

        public override double CalculateVolume()
        {
            Volume = (1 / 3.0) * Math.PI * Math.Pow(Length / 2.0, 2) * Depth;
            return Math.Round(Volume, 4);
        }

        public override double CalculateArea()
        {
            double slantHeight = Math.Sqrt(Math.Pow(Length / 2.0, 2) + Math.Pow(Depth, 2));
            Area = Math.PI * Length / 2.0 * (Length / 2.0 + slantHeight);
            return Math.Round(Area, 4);
        }
    }

}
