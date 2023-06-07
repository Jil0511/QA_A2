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

                string expected = "The triangle is valid and is an EQUILATERAL";

                //Act
                string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

                //Assert
                Assert.AreEqual(expected, actual);
            
        }


    }
}