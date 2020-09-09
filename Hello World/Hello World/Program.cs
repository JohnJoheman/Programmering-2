using System;

namespace Hello_World
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Type in 5 words");

            var words = new String[5];
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Your 5 words: ");
            foreach (string word in words)
            Console.WriteLine(word);

            Console.WriteLine();
            Console.WriteLine("Here are your words but printed backwards: ");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
            
            




        }

    }
}