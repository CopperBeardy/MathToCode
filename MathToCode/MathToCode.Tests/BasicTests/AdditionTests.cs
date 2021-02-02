using System;
using System.Collections.Generic;
using System.Text;
using MathToCode.Tests.Basic;
using Xunit;

namespace MathToCode.Tests.BasicTests
{
    public class AdditionTests
    {
        [Theory]
        [InlineData(2,5,7)]
        [InlineData(3, 2, 5)]
        [InlineData(234, 235, 469)]
        [InlineData(10235, 23235, 33470)]
        public void IntAdditionThatReturnsCorrectResults(int valueA,int valueB, int expected) 
        {
            var result = Addition.IntegerAdd(valueA, valueB);
            Assert.Equal(expected, result);
        }

    }
}
