using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Library.Test
{
    [TestClass]
    public class Tests
    {
        

        [TestInitialize]
        public void Initializer()
        {
            Console.WriteLine("Before Test method");
        }

        [TestCleanup]
        public void CleanUp()
        {

            Console.WriteLine("After Test Method");

        }
        
        [TestMethod]
        public void Devide_PositiveNumbers_ReturnPositiveQuotient()
        { 
            //Arrange
            double expected = 2;
            double numerator = 10;
            double denominator = 5;

            //Act
            double actual = Calculator.Devide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Devide_NegativeNumeratorPositiveDenominator_ReturnNegativeQuotient()
        {
            //Arrange
            double expected = -2;
            double numerator = -10;
            double denominator = 5;

            //Act
            double actual = Calculator.Devide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Devide_NegativeNumbers_ReturnPositiveQuotient()
        {
            //Arrange
            double expected = 2;
            double numerator = -10;
            double denominator = -5;

            //Act
            double actual = Calculator.Devide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
