using System;
using System.Collections.Generic;

namespace ParsetheParcel1
{
    public class Parcel : IParcel
    {
        private Dimension _dimension;
        private decimal Price { get; set; }
        private double Weight { get; set; }
        double maxWeight = 25.0;
        private Dictionary<string, Dimension> _parcelSpecs = new Dictionary<string, Dimension>();

        //initialise the parcel Specs
        public void InitParcelSpecs()
        {
            _parcelSpecs.Add("Small", new Dimension(200, 300, 150));
            _parcelSpecs.Add("Medium", new Dimension(300, 400, 200));
            _parcelSpecs.Add("Large", new Dimension(400, 600, 250));

        }
        public Parcel(int pLength, int pBreadth, int pHeight, double pWeight)
        {
            _dimension.Length = pLength;
            _dimension.Breadth = pBreadth;
            _dimension.Height = pHeight;
            Weight = pWeight;
        }

        public Parcel(Dimension pDimension, double pWeight)
        {
            _dimension = pDimension;
            Weight = pWeight;
        }

        private bool CheckOverweight()
        {
            if (Weight > 0  && Weight <= maxWeight)
                return false;

            return true;

        }

        public decimal CalculateParcelCost()
        {
            Price = Decimal.Zero;
            try
            {
                if (!CheckOverweight())
                {
                    InitParcelSpecs();
                    if (ValidateDimensions())
                    {
                        if (_dimension.Length <= _parcelSpecs["Small"].Length &&
                            _dimension.Breadth <= _parcelSpecs["Small"].Breadth &&
                            _dimension.Height <= _parcelSpecs["Small"].Height)
                        {
                            Price = 5.00M;
                        }
                        else if (_dimension.Length <= _parcelSpecs["Medium"].Length &&
                                 _dimension.Breadth <= _parcelSpecs["Medium"].Breadth &&
                                 _dimension.Height <= _parcelSpecs["Medium"].Height)
                        {
                            Price = 7.50M;
                        }
                        else if (_dimension.Length <= _parcelSpecs["Large"].Length &&
                                 _dimension.Breadth <= _parcelSpecs["Large"].Breadth &&
                                 _dimension.Height <= _parcelSpecs["Large"].Height)
                        {
                            Price = 8.50M;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Price;
        }

        private bool ValidateDimensions()
        {
            if (_dimension.Length > 0 && _dimension.Breadth > 0 && _dimension.Height > 0)
                return true;
            return false;

        }
        public decimal CalculateParcelCost(Dimension pDimension, double pWeight)
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

