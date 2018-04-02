using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlotsMachineBL;
using SlotsMachineBL.Interfaces;
using NUnit;
using NUnit.Framework;

namespace SlotsMachineBLTests
{
    [TestClass]
    public class IRandomGeneratorTests
    {
        private BasicRandomGenerator _Generator;
        public IRandomGeneratorTests()
        {
            _Generator = new BasicRandomGenerator();
        }

        [TestMethod]
        public void GetNextReturnsLessThanMaxValue()
        {
            //Arrange
            var maxValue = 20;

            //Act
            var result = _Generator.GetNext(maxValue);

            //Assert
            Assert.That(maxValue, Is.GreaterThan(result));
        }
    }
}
