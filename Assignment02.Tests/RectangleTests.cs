using NUnit.Framework;

namespace Assignment02.Tests
{
    
    [TestFixture]  //Test Fixture is a class that contains methods annotated with NUnit test attributes (such as [Test], [SetUp], [TearDown], etc.).
    public class RectangleTests
    {
        private Rectangle _rectangle;

        [SetUp]
        public void Setup()
        {
            _rectangle = new Rectangle();
        }

        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(1000, 1000)]
        public void GetLength__Test(int initialLength, int expectedLength)
        {
            // Assign
            _rectangle.SetLength(initialLength);

            // Act
            int result = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedLength, result);
        }

        [TestCase(1, 1)]
        [TestCase(8, 8)]
        [TestCase(5, 5)]
        public void SetLength_Test(int newLength, int expectedLength)
        {
            // Act
            _rectangle.SetLength(newLength);
            int result = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedLength, result);
        }


        [TestCase(1, 1)] 
        [TestCase(5, 5)] 
        [TestCase(9, 9)] 
        public void GetWidth_Tests(int initialWidth, int expectedWidth)
        {
            // Arrange
            _rectangle.SetWidth(initialWidth);

            // Act
            int result = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedWidth, result);
        }



        [TestCase(1, 1)]
        [TestCase(8, 8)]
        [TestCase(3, 3)]
        public void SetWidth_Test(int newWidth, int expectedWidth)
        {
            // Act
            _rectangle.SetWidth(newWidth);
            int result = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedWidth, result);
        }

        [TestCase(3, 4, 14)]
        [TestCase(8, 10, 36)]
        [TestCase(5, 5, 20)]
        public void GetPerimeter_Test(int length, int width, int expectedPerimeter)
        {
            // Assign
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            // Act
            int result = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, result);
        }

        [TestCase(3, 4, 12)]
        [TestCase(100, 50, 5000)]
        [TestCase(5, 5, 25)]
        public void GetArea_Test(int length, int width, int expectedArea)
        {
            // Assign
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            // Act
            int result = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(expectedArea, result);
        }
    }
}