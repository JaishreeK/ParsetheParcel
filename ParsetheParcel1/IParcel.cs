using System;

namespace ParsetheParcel1
{
    public interface IParcel
    {
        decimal CalculateParcelCost(Dimension pDimension, double pWeight);
        decimal CalculateParcelCost(int pLength, int pBreadth, int pHeight, double pWeight);
        decimal CalculateParcelCost();
    }
    public struct Dimension
    {
        public int Length { get; set; }

        public int Breadth { get; set; }

        public int Height { get; set; }

        public Dimension(int pLength, int pBreadth, int pHeight)
        {
            Length = pLength;
            Breadth = pBreadth;
            Height = pHeight;
        }
    }
}

