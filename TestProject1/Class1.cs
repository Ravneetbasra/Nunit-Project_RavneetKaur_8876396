using System.Xml.Linq;

namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if (((firstAngle + secondAngle + thirdAngle) == 180) && (firstAngle > 0 && secondAngle > 0 && thirdAngle > 0))
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }

   
        public static string ValidScaleneTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if((firstAngle != secondAngle && thirdAngle != secondAngle && thirdAngle != firstAngle) && ((firstAngle + secondAngle + thirdAngle) == 180))
            {
                result = "Triangle is Scalene";
            }
            else
            {
                result = "Triangle is not Scalene";
            }
            return result;
        }

        public static string ValidIsocelesTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if ((firstAngle == secondAngle || secondAngle == thirdAngle || thirdAngle == firstAngle) && ((firstAngle + secondAngle + thirdAngle) == 180))
            {
                result = "Triangle is Isosceles";
            }
            else
            {
                result = "Triangle is not Isosceles";
            }
            return result;
        }

        public static string ValidEquilateralTriangle(int firstAngle, int secondAngle, int
       thirdAngle)
        {
            string result;
            if ((firstAngle == secondAngle && secondAngle == thirdAngle && thirdAngle == firstAngle) && (firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "Triangle is Equilateral";
            }

            else
            {
                result = "Triangle is not Equilateral";
            }
            return result;
        }

        public static string ValidRightTriangle(int firstAngle, int secondAngle, int
      thirdAngle)
        {
            string result;
            if ((firstAngle == 90 || secondAngle == 90 || thirdAngle == 90) && ((firstAngle + secondAngle + thirdAngle) == 180))
            {
                result = "Triangle is Right Triangle";
            }

            else
            {
                result = "Triangle is not Right Triangle";
            }
            return result;
        }

    }
}

