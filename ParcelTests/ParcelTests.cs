using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParsetheParcel1;


namespace ParcelTests
{
    [TestClass]
    public class ParcelTests
    {
        //check nominal cases and Edge cases
        decimal _smallPrice;
        decimal _mediumPrice;
        decimal _largePrice;
        decimal _invalidPrice;

        [TestInitialize]
        public void SetUp()
        {
            _smallPrice = 5.00M;
            _mediumPrice = 7.50M;
            _largePrice = 8.50M;
            _invalidPrice = 0M;
    }
        [TestMethod()]
        public void CalculateParcelCostTestSmall()
        {
            Parcel Small = new Parcel(200, 300, 150, 2.5);
            var output = Small.CalculateParcelCost();
            Assert.AreEqual(_smallPrice,output,"Small Parcel Test Passed");
            
        }

        [TestMethod()]
        public void CalculateParcelCostTestSmall1()
        {
            Parcel Small1 = new Parcel(150, 250, 120, 4.5);
            var output = Small1.CalculateParcelCost();
            Assert.AreEqual(_smallPrice, output, "Small 1 Parcel Test Passed");
        }

        [TestMethod()]
        public void CalculateParcelCostTestMedium()
        {
            Parcel Medium = new Parcel(300, 400, 200, 5.5);
            var output = Medium.CalculateParcelCost();
            Assert.AreEqual(_mediumPrice, output, "Medium Parcel Test Passed");
        }

        [TestMethod()]
        public void CalculateParcelCostTestLarge()
        {
            Parcel Large = new Parcel(400, 600, 250, 7.05);
            var output = Large.CalculateParcelCost();
            Assert.AreEqual(_largePrice, output, "Large Parcel Test Passed");
        }

        [TestMethod()]
        public void CalculateParcelCostTestOverweight()
        {
            Parcel OverWeight = new Parcel(300, 400, 150, 60);
            var output = OverWeight.CalculateParcelCost();
            Assert.AreEqual(_invalidPrice, output, "Overweight Parcel Test Passed");
        }

        [TestMethod()]
        public void CalculateParcelCostTestOverweight2()
        {
            Parcel Overweight2 = new Parcel(200, 300, 150, 25);
            var output = Overweight2.CalculateParcelCost();
            Assert.AreEqual(_smallPrice, output, "Overweight2 Parcel Test Passed");
        }

        [TestMethod()]
        public void CalculateParcelCostTestOversize()
        {
            Parcel OverSize = new Parcel(500, 300, 200, 12.0);
            var output = OverSize.CalculateParcelCost();
            Assert.AreEqual(_invalidPrice, output, "Oversize Parcel Test Passed");
        }

        [TestMethod()]
        public void CalculateParcelCostTestNegativeSizeBox()
        {
            Parcel NegativesizeBox = new Parcel(-200, -300, 150, 2);
            var output = NegativesizeBox.CalculateParcelCost();
            Assert.AreEqual(_invalidPrice, output, "Negative Size Parcel Test Passed");
        }

        [TestMethod()]
        public void CalculateParcelCostTestAnotherBox()
        {
             Parcel AnotherBox = new Parcel(20, 30, 150, -2);
            var output =AnotherBox.CalculateParcelCost();
            Assert.AreEqual(_invalidPrice, output, "AnotherBox Parcel Test Passed");

        }
    }
}