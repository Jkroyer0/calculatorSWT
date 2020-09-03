using System;
using calculatorSWT;
using NUnit.Framework;

namespace calculatorSWTtest
{
    [TestFixture]
    public class calculatorTest
    {
        [Test]
        public void AddItems()
        {
            Calculator uut = new Calculator();

            Assert.That(uut.Add(4,5), Is.EqualTo(9));
        }
    }
}
