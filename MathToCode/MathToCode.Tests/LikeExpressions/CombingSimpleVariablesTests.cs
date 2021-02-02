using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MathToCode.Tests.LikeExpressions;

namespace MathToCode.Tests.LikeExpressions
{
    public class CombingSimpleVariablesTests
    {
        [Theory]
        [InlineData("p","p","2p")]
        [InlineData("2x", "x", "3x")]
        [InlineData("4s", "s", "5s")]
        [InlineData("6s", "s", "7s")]
        public void Should_Return_Summed_Values(string a, string b, string expected)
        {

            var result = CombingSimpleVariablesAdditionAndSubtraction.Simplify(a,b,'+');
            Assert.Equal(expected, result);
        }

        [Theory]        
        [InlineData("2x", "x", "x")]
        [InlineData("4s", "s", "3s")]
        [InlineData("6s", "s", "5s")]
        [InlineData("-8s", "-s", "-7s")]
        public void Should_Return_NegativeSummed_Values(string a, string b, string expected)
        {

            var result = CombingSimpleVariablesAdditionAndSubtraction.Simplify(a, b, '-');
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2p", "-p", "p")]
        [InlineData("3x", "-x", "2x")]
        [InlineData("4s", "-s", "3s")]
        [InlineData("26s", "-6s", "20s")]
        [InlineData("20s", "-10s", "10s")]
        [InlineData("20s", "-9s", "11s")]
        [InlineData("110s", "-10s", "100s")]
        public void Should_Return_SummedNegative_Values(string a, string b, string expected)
        {

            var result = CombingSimpleVariablesAdditionAndSubtraction.Simplify(a, b, '+');
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("2p", "-p", "-2p")]
        [InlineData("3x", "-x", "-3x")]
        [InlineData("-4s", "-s", "4s")]
        [InlineData("26s", "-6s", "-156s")]
        [InlineData("20s", "-10s", "-200s")]
        [InlineData("-20s", "-9s", "180s")]
        [InlineData("100s", "-10s", "-1000s")]
        public void Should_Return_Valid_Multiplied_Values(string a, string b, string expected)
        {

            var result = CombingSimpleVariablesAdditionAndSubtraction.Simplify(a, b, '*');
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("2x", "x", "2x")]
        [InlineData("4s", "2s", "2s")]
        [InlineData("6s", "-2s", "-3s")]
        [InlineData("-8s", "-2s", "4s")]
        public void Should_Return_Valid_divided_Values(string a, string b, string expected)
        {

            var result = CombingSimpleVariablesAdditionAndSubtraction.Simplify(a, b, '/');
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("-8s", "0")]
        [InlineData("6s", "0")]
        [InlineData("234234s", "0")]
        public void Should_throw_divdebyzeroException(string a, string b)
        {
             Assert.Throws<DivideByZeroException>(() 
                 => CombingSimpleVariablesAdditionAndSubtraction.Simplify(a, b, '/'));
           
        }
    }
}
