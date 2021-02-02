using System;
using MathToCode.Tests.Basic;

namespace MathToCode
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 5;
            var b = 3;

            var resutl = Addition.IntegerAdd(a,b);

            decimal r = 2.3343M;
            double xd = 2.4234;

            var result = (double)r + xd;

            var x = 2 + 2.0;

            Console.WriteLine("Hello World!");
        }
    }
}
