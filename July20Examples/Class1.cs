using NUnit.Framework;
using System;

namespace July20Examples
{ 
    public class Class1
    {
        [Test]
        public void OneEqualsOne()
        {
            var expected = 1;
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneNotEqualTwo()
        {
            var expected = 1;
            var actual = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
