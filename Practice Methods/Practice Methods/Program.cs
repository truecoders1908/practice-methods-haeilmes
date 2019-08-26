using System;
using System.Collections.Generic;

namespace Week2_Methods_Practice_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the int method in the main method
            Console.WriteLine("Please enter number to be multiplied:");
            int numberToBeMultipled = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            int numberToBeMultipled2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The answer is: " + MultipliedNumbers(numberToBeMultipled, numberToBeMultipled2));

            //Calling a bool method in the main method
            Console.WriteLine("7 - 3 = ?");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(SevenMinusThree(userInput));

            //Calling a string method in the main method
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine(HelloUserName(userName));
        }

        //This is the int method
        static int MultipliedNumbers(int num1, int num2)
        {
            int result = num1 * num2;
            return result;

        }

        //This is the bool method
        static bool SevenMinusThree(int userInput)
        {
            if( userInput != 4)
            {
                return false;
            }
            return true;
        }
        
        //This is the string method
        static string HelloUserName(string userName)
        {
            return "Hello, " + userName;
        }
    }
}
