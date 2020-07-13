using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //count numbers divisible by 3 between 1 to 100.
            int countOfNumber = Count(1, 100);
            Console.WriteLine("Total count="+countOfNumber);

            //Find the factorial of a number entered by user.
            Console.WriteLine("Enter the number to find its factorial");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = Factorial(number);
            Console.WriteLine($"Factorial of {number} is " + factorial);


            //Find maximum of the series of numbers provided by user.
            Console.WriteLine("Enter the Series of numbers seperated by comma ro find the maximum among them.");
            string seriesOfNumber = Console.ReadLine();
            int[] arrayOfNumber = Array.ConvertAll((seriesOfNumber.Split(",")),int.Parse);
            Console.WriteLine("Maximum is " + FindMaximum(arrayOfNumber));


            //Write a program to accept input from user (Enter number). Suppose if user Enter Number 10  print “This is Number 1 “ ,”this is number 2” so on like that based on input number from user
            Console.WriteLine("Enter the number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"This is number {userNumber}");


            //Write a console program to accept input from user(“Enter your Name”) and perform below Tasks using C#
            //If user enters “Prathap” return “you have entered Prathap. which has length of 7 characters.”
            //If user enters “Welcome to my Session” return “Hello your sentence contains 4 words.your third word is “my““

            Console.WriteLine("Enter the Name");
            string nameString = Console.ReadLine();
            string[] stringArrayOfNameString = nameString.Split(" ");
            if (stringArrayOfNameString.Length == 1)
            {
                Console.WriteLine($"You have entered {nameString}. which has length of {nameString.Length} characters.");
            }
            else {
                if (stringArrayOfNameString.Length < 3)
                {
                    Console.WriteLine($"Hello your sentence contains {stringArrayOfNameString.Length} words.");
                }
                else
                {
                    Console.WriteLine($"Hello your sentence contains {stringArrayOfNameString.Length} words. Your third word is {stringArrayOfNameString[2]}");
                }
            }
        }

        static int Count(int number1, int number2)
        {
            Console.WriteLine("Numbers divisible by 3 are ");
            int counter = 0;
            for (int i = number1; i < number2;i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                    Console.WriteLine(i);
                }
            }
            return counter;
        }


        static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }


        static int FindMaximum(int[] numberArray)
        {
            int maximum = -9999;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > maximum)
                {
                    maximum = numberArray[i];
                }
            }
            return maximum;
        }
    }
}
