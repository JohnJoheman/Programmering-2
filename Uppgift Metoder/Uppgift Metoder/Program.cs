using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Uppgift_Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            sum();
            Console.WriteLine();
            wordsBackwards();
            Console.WriteLine();
            minMaxNumber();
        }

        private static int sum()
        {
            Console.WriteLine("Write five numbers that you want to add up together: ");

            var num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int numbers = 0;
            for (int i = 0; i < num.Length; i++)
            {
                numbers = numbers + num[i];
            }
            Console.WriteLine("Here are the sum of your numbers: ");
            Console.WriteLine(numbers);
            return numbers;
        }

        private static void wordsBackwards()
        {
            Console.WriteLine("Type in 5 words, they are later going to be printed out backwards: ");
            var words = new string[5];
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Here are your words but printed backwards: ");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }



        }


        private static int minMaxNumber()
        {
            Console.WriteLine("type in 5 different numbers: ");
            var integers = new int[5];
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int lowestNumber = integers.Min();
            int highestNumber = integers.Max();

            Console.WriteLine("Here is the lowest number: " + integers.Min());
            Console.WriteLine("Here is the highest number: " + integers.Max());
            return lowestNumber & highestNumber;
        }


    }
}
