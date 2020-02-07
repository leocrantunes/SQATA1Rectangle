using NUnit.Framework;
using System;

namespace SQATA1Rectangle.Tests
{
    public class RectangleTest
    {
        private Rectangle fixture;

        /// <summary>
        /// Test identifier: 1.1
        /// Test description: tests get length of a rectangle
        /// Method of execution: Automated
        /// Created rectangle: length (5) width (10)
        /// Expected output: 5
        /// </summary>
        [Test]
        public void TestGetLength_Input5_Output5()
        {
            // 1. Arrange
            int length = 5;
            int width = 10;
            fixture = new Rectangle(length, width);

            // 2. Act
            int result = fixture.GetLength();

            // 3. Assert
            Assert.AreEqual(length, result);
        }

        /// <summary>
        /// Test identifier: 1.2
        /// Test description: tests set length of a rectangle
        /// Method of execution: Automated
        /// Created rectangle: length (5) width (10)
        /// Modified value: 8
        /// Expected output: 8
        /// </summary>
        [Test]
        public void TestSetLength_Input8_Output8()
        {
            // 1. Arrange
            int originalLength = 5;
            int width = 10;
            int updatedLength = 8;
            fixture = new Rectangle(originalLength, width);

            // 2. Act
            int result = fixture.SetLength(updatedLength);

            // 3. Assert
            Assert.AreEqual(updatedLength, result);
        }

        /// <summary>
        /// Test identifier: 1.3
        /// Test description: tests get width of a rectangle
        /// Method of execution: Automated
        /// Created rectangle: length (5) width (10)
        /// Expected output: 10
        /// </summary>
        [Test]
        public void TestGetWidth_Input10_Output10()
        {
            // 1. Arrange
            int length = 5;
            int width = 10;
            fixture = new Rectangle(length, width);

            // 2. Act
            int result = fixture.GetWidth();

            // 3. Assert
            Assert.AreEqual(width, result);
        }

        /// <summary>
        /// Test identifier: 1.4
        /// Test description: tests set width of a rectangle
        /// Method of execution: Automated
        /// Created rectangle: length (5) width (10)
        /// Modified value: 12
        /// Expected output: 12
        /// </summary>
        [Test]
        public void TestSetWidth_Input12_Output12()
        {
            // 1. Arrange
            int length = 5;
            int width = 10;
            int updatedWidth = 12;
            fixture = new Rectangle(length, width);

            // 2. Act
            int result = fixture.SetWidth(updatedWidth);

            // 3. Assert
            Assert.AreEqual(updatedWidth, result);
        }

        /// <summary>
        /// Test identifier: 1.5
        /// Test description: tests get perimeter of a rectangle
        /// Method of execution: Automated
        /// Created rectangle: length (5) width (10)
        /// Expected output: 30
        /// </summary>
        [Test]
        public void TestGetPerimeter_Input5and10_Output30()
        {
            // 1. Arrange
            int length = 5;
            int width = 10;
            int expectedPerimeter = 30;
            fixture = new Rectangle(length, width);

            // 2. Act
            int result = fixture.GetPerimeter();

            // 3. Assert
            Assert.AreEqual(expectedPerimeter, result);
        }

        /// <summary>
        /// Test identifier: 1.6
        /// Test description: tests get perimeter of a rectangle
        /// Method of execution: Automated
        /// Created rectangle: length (5) width (10)
        /// Expected output: 50
        /// </summary>
        [Test]
        public void TestGetPerimeter_Input5and10_Output50()
        {
            // 1. Arrange
            int length = 5;
            int width = 10;
            int expectedArea = 50;
            fixture = new Rectangle(length, width);

            // 2. Act
            int result = fixture.GetArea();

            // 3. Assert
            Assert.AreEqual(expectedArea, result);
        }
    }
}