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

            var answer = 4;
            double userNumber;
            Console.WriteLine($"Please give me a number to evaluate");
            var response = Console.ReadLine();

            bool isParsable = double.TryParse(response, out userNumber);

            //do
            //{
            //    Console.WriteLine($"Please input a number");
            //    response = Console.ReadLine();

            //} while (isParsable == false);



            var output = (userNumber < 9) ? $"Your number is less than nine" : $"Your number is greater than nine";
            Console.WriteLine(output);
        }
    }
}
