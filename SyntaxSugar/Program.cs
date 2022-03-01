using System;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code Started as:
            //int answer = 4;
            //string response;

            //if(answer<9)
            //{
            //    response = answer + "is less than nine";
            //}
            //else
            //{
            //    response = answer + "is greater than nine";
            //}

            //inferred typing
            var answer = 4;
            //string interpolation & ternary operator
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);
        }
    }
}
