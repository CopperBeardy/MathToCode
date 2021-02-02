using System;
using System.Collections.Generic;
using System.Text;
using MathToCode.Core.Shared;

namespace MathToCode.Tests.LikeExpressions
{
    public static class CombingSimpleVariablesAdditionAndSubtraction
    {
        public static string Simplify(string a, string b,char _operator)
        {
            var result = string.Empty;
            (int number, char letter,bool negative) valuesA = ParseCharacterExpressions.SplitString(a);
            (int number, char letter,bool negative) valuesB = ParseCharacterExpressions.SplitString(b);

            //positive values
            if(!valuesA.negative && !valuesB.negative)
            {
             
                result += $"{Calculate(valuesA.number, valuesB.number, _operator)}" + $"{valuesA.letter}";
                
            }
            //negative values
            else if(valuesA.negative && valuesB.negative)
            {
                result += $"{Calculate(-valuesA.number, -valuesB.number, _operator)}" + $"{valuesA.letter}";


            }
           
            else if(!valuesA.negative && valuesB.negative)
            {
                result += $"{Calculate(valuesA.number, -valuesB.number, _operator)}" + $"{valuesA.letter}";


            }
            else if(valuesA.negative && !valuesB.negative)
            {
                result += $"{Calculate(-valuesA.number, valuesB.number, _operator)}" + $"{valuesA.letter}";
            }

            if(result[0]== '1' && result.Length >= 2  && char.IsNumber(result[1]) == false)
            {
                result = result.Remove(0,1);
            }
            return result; 
        }

        public static int Calculate(int a ,int b, char _operator)
        {
            var result = 0;
            switch (_operator)
            {
                case '-':
                    result = a - b;
                    break;
                case '+':
                    result = a + b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = a / b;
                    break;              
            }

            return result;

        }
       
    }
}
