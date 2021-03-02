using System;
using Xunit;
using UtilsLibrary;

namespace UtilsLibrary.Tests
{
    public class NumberFlowTest
    {

       
        
        [Fact]
        public void IncrementMaxValueThrowOverflowException()
        {
          Assert.Throws<OverflowException>(() => OverflowNumberSamples.IncrementValue(UInt32.MaxValue));


        }
        
        [Fact]
        public void DecrementMinValueThrowOverflowException()
        {
           Assert.Throws<OverflowException>(() => OverflowNumberSamples.DecrementValue(UInt32.MinValue));
        }
    }
}