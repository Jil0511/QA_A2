using TriangleSolver;

namespace Testing.nUnitTests
{
    public class Tests
    {
        private Triangle getTriangle { get; set; }

        [SetUp]
        public void Setup()
        {
            getTriangle = new Triangle();

        }

        [Test]
            public void AnalyzeTriangle_Input35and35and35_OutputvalidEquilateralTriangle()
            {
                //Arrange
                int side1 = 35;
                int side2 = 35;
                int side3 = 35;

                string output = "The triangle is valid and is an EQUILATERAL";

                //Act
                string original = Triangle.AnalyzeTriangle(side1, side2, side3);

                //Assert
                Assert.AreEqual(output, original);
            
        }

        [Test]
        public void AnalyzeTriangle_Input40and50and50_OutputvalidISOSCELESTriangle()
        {
            //Arrange
            int side1 = 40;
            int side2 = 50;
            int side3 = 50;

            string output = "The triangle is valid and is an ISOSCELES";

            //Act
            string original = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(output, original);

        }

        [Test]
        public void AnalyzeTriangle_Input32and89and89_OutputvalidISOSCELESTriangle()
        {
            //Arrange
            int side1 = 32;
            int side2 = 89;
            int side3 = 89;

            string output = "The triangle is valid and is an ISOSCELES";

            //Act
            string original = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(output, original);

        }

        [Test]
        public void AnalyzeTriangle_Input24and73and73_OutputvalidISOSCELESTriangle()
        {
            //Arrange
            int side1 = 24;
            int side2 = 73;
            int side3 = 73;

            string output = "The triangle is valid and is an ISOSCELES";

            //Act
            string original = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(output, original);

        }
    }
}