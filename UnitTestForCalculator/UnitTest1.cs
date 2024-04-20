using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Practice1;

namespace UnitTestForCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Plus_10and3_returned13()
        {
            // Arrange
            double a = 10;
            double b = 3;
            double result = 13;

            // Act
            Calculator calculator = new Calculator();
            double actual = calculator.Plus(a, b);

            // Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Subtract_10and4_returned6()
        {
            // Arrange
            double a = 10;
            double b = 4;
            double result = 6;

            // Act
            Calculator calculator = new Calculator();
            double actual = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Multiply_6and7_returned42()
        {
            // Arrange
            double a = 6;
            double b = 7;
            double result = 42;

            // Act
            Calculator calculator = new Calculator();
            double actual = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Divide_15and3_returned5()
        {
            // Arrange
            double a = 15;
            double b = 3;
            double result = 5;

            // Act
            Calculator calculator = new Calculator();
            double actual = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(result, actual);
        }
    }
}
