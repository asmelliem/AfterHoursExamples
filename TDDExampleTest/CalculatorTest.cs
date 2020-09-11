using System;
using TDDExample;
using Xunit;

namespace TDDExampleTest
{
    public class CalculatorTest
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            //Arrange
            var numberOne = 1;
            var numberTwo = 3;
            var calculator = new Calculator();
            var expected = 4;

            //Act
            var actual = calculator.Addition(numberOne, numberTwo);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldSubtractTwoNumbers()
        {
            //Arrange
            var numberOne = 5;
            var numberTwo = 2;
            var calculator = new Calculator();
            var expected = 3;

            //Act
            var actual = calculator.Subtraction(numberOne, numberTwo);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldDivideTwoNumber()
        {
            //Arrange
            var numberOne = 10;
            var numberTwo = 2;
            var calculator = new Calculator();
            var expected = 5;

            //Act
            var actual = calculator.Divide(numberOne, numberTwo);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            //Arrange
            var numberOne = 5;
            var numberTwo = 2;
            var calculator = new Calculator();
            var expected = 10;

            //Act
            var actual = calculator.Multiply(numberOne, numberTwo);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldThrowExceptionError()
        {
            //Arrange
            var numberOne = 5;
            var numberTwo = 0;
            var calculator = new Calculator();      

            //Assert
            Assert.Throws<Exception>(() => calculator.Divide(numberOne, numberTwo));
        }
    }
}
