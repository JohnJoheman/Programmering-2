using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello Stranger!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            bool inputForName = true;

            while (inputForName)
            {
                if (name != "")
                {
                    inputForName = false;
                }
                else
                {
                    Console.WriteLine("Please enter your name");
                    name = Console.ReadLine();
                }
            }

            Console.WriteLine("Please enter your age;");
            var age = Console.ReadLine();

            

            bool deadOrNot = true;
            Console.WriteLine("Are you dead or alive? enter 1 for yes and 2 for no");

            

            var yeet = Convert.ToInt32(Console.ReadLine());


            switch (yeet)

            {
                case 1:
                    deadOrNot = true;
                    break;

                case 2:
                    deadOrNot = false;
                    break;
            }

            if (deadOrNot == true) 
            {
                Console.WriteLine("You won't be for too long tho >:)");
            }
            else
            {
                Console.WriteLine("Well that's just highly unfortunate :("); 
            }



            Console.WriteLine();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);

            if(deadOrNot == true)
            {
                Console.WriteLine("Life-Status: Alive");
            }
            else
            {
                Console.WriteLine("Life-Status: Dead");
            }

            Console.WriteLine();
            Console.WriteLine("Type in 5 words");

            var words = new String[5];
            for (int i = 0; i < 5; i++)
            {
                words[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Your 5 words: ");
            foreach (string word in words)

   
            Console.WriteLine(word);

            
            



        }

    }
}