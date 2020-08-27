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

            Console.WriteLine("Please enter your age;");
            var age = Console.ReadLine();


            Console.WriteLine("Are you dead or alive? enter 1 for yes and 2 for no");

            bool deadOrNot = true;
            var yeet = Console.ReadLine();


            if (yeet == "1"){
                deadOrNot = true;

            }
            else
            {
                deadOrNot = false;
            }

            if (deadOrNot == true) 
            {
                Console.WriteLine("You won't be for too long tho >:)");
                
            }
            else
            {
                Console.WriteLine("Well that's just highly unfortunate :(");
                
            }

            


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
            
           
            

            
            



        }

    }
}