using System;

namespace ParsetheParcel1
{
    public class Parcel : IParcel
    {
        private dimension _dimension;
        private decimal Price { get; set; }
        private double Weight { get; set; }
        double maxWeight = 25.0;
        private Dictionary<string, dimension> _parcelSpecs = new Dictionary<string, dimension>();

        //initialise the parcel Specs
        public void initParcelSpecs()
        {
            _parcelSpecs.Add("Small", new dimension(200, 300, 150));
            _parcelSpecs.Add("Medium", new dimension(300, 400, 200));
            _parcelSpecs.Add("Large", new dimension(400, 600, 250));

        }
        public Parcel(int pLength, int pBreadth, int pHeight, double pWeight)
        {
            _dimension.Length = pLength;
            _dimension.Breadth = pBreadth;
            _dimension.Height = pHeight;
            Weight = pWeight;
        }

        public Parcel(dimension pDimension, double pWeight)
        {
            _dimension = pDimension;
            Weight = pWeight;
            CalculateParcelCost();
        }

        private bool CheckOverweight()
        {
            if (Weight > maxWeight)
                return true;

            return false;

        }
        public decimal CalculateParcelCost()
        {
            if (!CheckOverweight())
            {
                initParcelSpecs();
                if (_dimension.Length > 0 && _dimension.Length <= _parcelSpecs["small"].Length && _dimension.Breadth > 0 && _dimension.Breadth <= _parcelSpecs["small"].Breadth && _dimension.Height > 0 && _dimension.Height <= _parcelSpecs["small"].Height)
                {
                    Price = 5.00M;
                }
                if (_dimension.Length > 0 && _dimension.Length <= _parcelSpecs["medium"].Length && _dimension.Breadth > 0 && _dimension.Breadth <= _parcelSpecs["medium"].Breadth && _dimension.Height > 0 && _dimension.Height <= _parcelSpecs["medium"].Height)
                {
                    Price = 7.50M;
                }
                if (_dimension.Length > 0 && _dimension.Length <= _parcelSpecs["Large"].Length && _dimension.Breadth > 0 && _dimension.Breadth <= _parcelSpecs["Large"].Breadth && _dimension.Height > 0 && _dimension.Height <= _parcelSpecs["Large"].Height)
                {
                    Price = 8.50M;
                }
            }
            else
                Price = Decimal.Zero;

            return Price;
        }

        public decimal CalculateParcelCost(dimension pDimension, double pWeight)
        {
            _dimension = pDimension;
            Weight = pWeight;
            return CalculateParcelCost();

        }

        public decimal CalculateParcelCost(int pLength, int pBreadth, int pHeight, double pWeight)
        {
            _dimension.Length = pLength;
            _dimension.Length = pLength;
            _dimension.Length = pLength;

            Weight = pWeight;
            return CalculateParcelCost();

        }
    }
}

