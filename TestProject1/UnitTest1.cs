using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        /* This Test will verify whether it is valid triangle when sum of firstAngle, secondAngle and thirdAngle  have sum of 180.
            Here the firstAngle == secondAngle == thirdAngle

        code by Ravneet
        */
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        /* This Test will verify whether it is valid triangle when sum of firstAngle, secondAngle and thirdAngle  have sum of 180.
            Here the firstAngle != secondAngle != thirdAngle
         code by Ravneet
        */

        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage2()
        {
            // Arrange
            int firstAngle = 50;
            int secondAngle = 70;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        /* This Test will verify whether it is valid triangle when sum of firstAngle, secondAngle and thirdAngle  have sum of 180.
            Here the sum of all angles is not equal to 180. So, it is not a valid Triangle
         code by Ravneet
        */

        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 40;
            int secondAngle = 70;
            int thirdAngle = 50;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }


        /* This Test will verify whether it a valid triangle or not.
         * Valid Triangle must not have any negative angle, so for the below test, it is not a valid Triangle
         *   code by Ravneet
        */

        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage2()
        {
            // Arrange
            int firstAngle = -40;
            int secondAngle = -70;
            int thirdAngle = 50;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        /* This Test will verify whether it a valid Scalene triangle or not
         * Scalene Triangle must have different Angles and sum of the angles still must be 180.
         * Below Test is a valid Scalene Triangle.
         *  code by Ravneet
        */
        [Test]
        public void ValidScaleneTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 50;
            int thirdAngle = 70;


            // Act
            string result = Triangle.ValidScaleneTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is Scalene", result);
        }


        /* This Test will verify whether it a valid Scalene triangle or not
         * Scalene Triangle must have different angles and sum of the angles still must be 180.
         * Below Test is a invalid scalene as two angles have same value.
         *  code by Ravneet
        */

        [Test]
        public void InValidScaleneTriangle_InValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 50;
            int secondAngle = 50;
            int thirdAngle = 80;


            // Act
            string result = Triangle.ValidScaleneTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is not Scalene", result);
        }

        /* This Test will verify whether it a valid Scalene triangle or not
        * Scalene Triangle must have different angles and sum of the angles still must be 180.
        * Below Test is a invalid scalene as sum of three angles is greater than 180 which means it is an invalid Triangle
        *  code by Ravneet
       */

        [Test]
        public void ValidScaleneTriangle_InValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 80;


            // Act
            string result = Triangle.ValidScaleneTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is not Scalene", result);
        }

        /* This Test will verify whether it a valid Isosceles triangle or not
        * Isosceles Triangle must have same two angles and sum of the angles still must be 180.
        * Below Test is a valid Isosceles as it has two angles with the same value
        *  code by Ravneet
       */

        [Test]
        public void ValidIsoscelesTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 70;
            int secondAngle = 70;
            int thirdAngle = 40;
            // Act
            string result = Triangle.ValidIsocelesTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is Isosceles", result);
        }

        /* This Test will verify whether it a valid Isosceles triangle or not
        * Isosceles Triangle must have same two angles and sum of the angles still must be 180.
        * Below Test is a Invalid Isosceles as it has each different angle
        *  code by Ravneet
       */


        [Test]
        public void InvalidIsoscelesTriangle_InvalidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 70;
            int thirdAngle = 50;
            // Act
            string result = Triangle.ValidIsocelesTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is not Isosceles", result);
        }


        /* This Test will verify whether it a valid Isosceles triangle or not
        * Isosceles Triangle must have same two angles and sum of the angles still must be 180.
        * Below Test is a Invalid Isosceles as the sum of all angles is greater than 180.
        *  code by Ravneet
       */

        [Test]
        public void ValidIsoscelesTriangle_InvalidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 80;
            int secondAngle = 80;
            int thirdAngle = 50;
            // Act
            string result = Triangle.ValidIsocelesTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is not Isosceles", result);
        }

        /* This Test will verify whether it a valid Equilateral triangle or not
        * Equilateral Triangle must have all angles  as same and sum of the angles still must be 180.
        * Below Test is a valid Equilateral as the three angles have same value
        *  code by Ravneet
       */

        [Test]
        public void ValidEquilateralTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidEquilateralTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is Equilateral", result);
        }

        /* This Test will verify whether it a valid Equilateral triangle or not
        * Equilateral Triangle must have all angles  as same and sum of the angles still must be 180.
        * Below Test is a Invalid Equilateral as the three angles have sum greater than 180.
        *  code by Ravneet
       */

        [Test]
        public void ValidEquilateralTriangle_InValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 40;
            int secondAngle = 40;
            int thirdAngle = 40;
            // Act
            string result = Triangle.ValidEquilateralTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is not Equilateral", result);
        }

        /* This Test will verify whether it a valid Equilateral triangle or not
        * Equilateral Triangle must have all angles  as same and sum of the angles still must be 180.
        * Below Test is a Invalid Equilateral as the three angles have each different value.
        *  code by Ravneet
       */


        [Test]
        public void InValidEquilateralTriangle_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 70;
            int thirdAngle = 50;
            // Act
            string result = Triangle.ValidEquilateralTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is not Equilateral", result);
        }

        /* This Test will verify whether it a valid Right triangle or not
        * Right Triangle must have atleast one angle as 90 and sum of the angles still must be 180.
        * Below Test is a Right Equilateral as the one of the angle has 90 value
        *  code by Ravneet
       */

        [Test]
        public void ValidRightTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 45;
            int thirdAngle = 45;
            // Act
            string result = Triangle.ValidRightTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is Right Triangle", result);
        }

        /* This Test will verify whether it a valid Right triangle or not
        * Right Triangle must have atleast one angle as 90 and sum of the angles still must be 180.
        * Below Test is a Invalid Right Equilateral as the no angle has a value of 90.
        *  code by Ravneet
       */

        [Test]
        public void InValidRightTriangle_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 55;
            int secondAngle = 80;
            int thirdAngle = 45;
            // Act
            string result = Triangle.ValidRightTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is not Right Triangle", result);
        }


        /* This Test will verify whether it a valid Right triangle or not
        * Right Triangle must have atleast one angle as 90 and sum of the angles still must be 180.
        * Below Test is a Invalid Right Equilateral as the sum of the angle is not equal to 180.
        *  code by Ravneet
       */
        [Test]
        public void ValidRightTriangle_InValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 80;
            int thirdAngle = 80;
            // Act
            string result = Triangle.ValidRightTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("Triangle is not Right Triangle", result);
        }

    }
    }

