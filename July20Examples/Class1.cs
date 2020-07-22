
using System;
using Xunit;

namespace July20Examples
{ 
    public class Class1
    {
        [Fact]
        public void OneEqualsOne()
        {
            //arrange
            int  actual;
            var expected = 1;
            
            //act
            actual = 1;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneNotEqualTwo()
        {
            var expected = 1;
            var actual = 2;
            Assert.NotEqual(expected, actual);
        }
    }
}
