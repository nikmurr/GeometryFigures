using System;
using System.Windows.Forms;

namespace GeometryFigures
{
    public class BaseObject
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }
        public double PricePerKg { get; set; } = 0;
        public double Density { get; set; } = 0;
        public double Price { get; set; } = 0;
        public double Volume { get; set; } = 0;
        public double Area { get; set; } = 0;
        public string Material { get; set; } = "Неизвестно";

        public BaseObject(double length, double width, double depth, double weight)
        {
            Length = length;
            Width = width;
            Depth = depth;
            Weight = weight;
        }

        public virtual string Type
        {
            get { return "Неизвестно"; }
        }

        public virtual double CalculateVolume()
        {
            Volume = Length * Width * Depth;
            return Math.Round(Volume, 4);
        }

        public virtual double CalculateArea()
        {
            Area = 2 * (Length * Width + Length * Depth + Width * Depth);
            return Math.Round(Area, 4);
        }

        public double CalculatePrice()
        {
            Price = PricePerKg * Weight;
            return Math.Round(Price, 2);
        }

        public double CalculateDensity()
        {
            Density = Math.Round(Weight / Volume, 0);
            return Density;
        }

        public double CalculateGoodWeight(Random random)
        {
            if (Volume == 0) 
            {
                CalculateVolume();
            }
            Weight = Volume * random.Next(220, 23000);
            return Math.Round(Weight, 5);
        }
    }
}
