using System;
using Xunit;
using UtilsLibrary;
using Xunit.Abstractions;

namespace UtilsLibrary.Tests
{
    public class RandomNumberGeneratorTests
    {
        [Fact]
        public void RandomNumberGeneratorHasCorrectName()
        {
            Assert.Equal("RandomNumberGenerator", RandomNumberGenerator.GetClassName());
        }

        [Fact]
        public void GeneratedNumberIsInRangeMinus10ToPlus10()
        {
            var name = RandomNumberGenerator.GetClassName();
            for (int i = 0; i < 1000; i++)
            {
                var magicNumber = RandomNumberGenerator.Next();
                Assert.InRange(magicNumber, -10, 10);
            }
        }
    }
}