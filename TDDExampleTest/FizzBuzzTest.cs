using System;
using System.Collections.Generic;
using System.Text;
using TDDExample;
using Xunit;

namespace TDDExampleTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ShouldReturnFizzForMultipleOfThree()
        {
            //Arrange
            var input = 3;
            var expected = "Fizz";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var actual = fizzBuzz.DetermineFizzBuzzOutput(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnBuzzForMultipleOfFive()
        {
            //Arrange
            var input = 5;
            var expected = "Buzz";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            var actual = fizzBuzz.DetermineFizzBuzzOutput(input);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
