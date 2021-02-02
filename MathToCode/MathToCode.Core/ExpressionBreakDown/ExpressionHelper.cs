using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MathToCode.Core.ExpressionBreakDown
{
    public static class ExpressionHelper
    {
        public static (string v1, string v2, char operand) ParseExpression(string input)
        {
           
            //passed in example  "2a + 2a"
            string[] exp = input.Split(" ");

            var ind = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if(input[i].Equals('+') ||
                    input[i].Equals('-')||
                    input[i].Equals('*')||
                    input[i].Equals('/'))
                {
                    ind = i-1;
                    break;
                }
            }
            input = input.Replace(" ", "");
          
            List<string> exps = new List<string>();
            exps.Add(input.Substring(0, ind ));
            exps.Add(input.Substring(ind+1));
            exps.Add(input[ind].ToString());



            (string v1, string v2, char operand) output =
                (
                    exps[0],exps[1],char.Parse(exps[2])
                ) ;

            return output;
            //return example (2a,2a,+)
        }
    }
}
