using System;
using TDDExample;
using Xunit;

namespace TDDExampleTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddOnePlusThree()
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

        
    }
}
