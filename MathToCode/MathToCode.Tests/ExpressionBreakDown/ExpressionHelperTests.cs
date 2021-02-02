using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MathToCode.Core.ExpressionBreakDown;

namespace MathToCode.Tests.ExpressionBreakDown
{
    public class ExpressionHelperTests
    {
        [Theory]        
        [InlineData("2a+2a", new object []{"2a", "2a", '+'})]
        [InlineData("4a - -4a", new object[] { "4a", "-4a", '-' })]
        [InlineData("6a * 6a", new object[] { "6a", "6a", '*' })]
        [InlineData("8a / 8a", new object[] { "8a", "8a", '/' })]
      
        public void ShouldReturnParsePositiveInputsTuple(string input, object[] expected)
        {
            (string v1, string v2, char operand) result = ExpressionHelper.ParseExpression(input);
            
            Assert.Equal(expected[0], result.v1);
            Assert.Equal(expected[1], result.v2);
            Assert.Equal(expected[2], result.operand); 

        }

    }
}
