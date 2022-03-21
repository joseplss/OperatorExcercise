using System;

namespace OperatorExercise
{
    internal class Program
    {
        public static double AreaOfCircle(double radius) //takes variable that was sent from main and converts to double
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;

        }
        static void Main(string[] args)
        {
            //EXCERCISE 1//
            int a = 17;
            int b = 4;
            Console.WriteLine($"Hey! If you gave me the number {a} and {b}...");

            int divAnswer = a / b;
            int modAnswer = a % b;
            if(a == 17 && b== 4)
            {
                Console.WriteLine($"{a}/{b} is {divAnswer} remainder {modAnswer}");
            }else
            {
                Console.WriteLine("a does not equal to 17 and/or b does not equal to 4");
            }
            //moves to excercise 2
            Console.WriteLine("\nEnd of excercise 1. Enter any key to continue to excercise 2...");
            Console.ReadLine();

            //EXCERCISE 2//
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");
            /*line 36 can combine the output of method that was sent and returned to without giving an error sent has to have (radius) in parenthesis
             * */

        }
    }
}
