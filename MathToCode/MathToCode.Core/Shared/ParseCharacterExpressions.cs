using System;
using System.Collections.Generic;
using System.Text;

namespace MathToCode.Core.Shared
{
    public static class ParseCharacterExpressions
    {
        public static (int, char, bool) SplitString(string value)
        {
            if(value == "0")
            {
                return (0, ' ', false);
            }
            var l = value.Length;
            var letter = value[l - 1];
            value = value.Remove(l - 1);

            bool negative = false;
            if (value.Length != 0 && value[0].Equals('-'))
            {
                negative = true;
                value = value.Remove(0, 1);
            }

            var number = 1;
            
            if (value.Length != 0)
            {
                number = int.Parse(value);
            }

            return (number, letter, negative);
        }
    }
}
