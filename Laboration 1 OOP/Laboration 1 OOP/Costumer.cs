using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Laboration_1_OOP
{
    class Costumer
    {
        public int _products;
        string yesOrNo;
        Products products = new Products();


        public void WelcomeCostumer()
        {
            Console.WriteLine("Hello Costumer, would you like to shop things today?");
            shoppingInstructions();

            void shoppingInstructions()
            {
                
                Console.WriteLine("Type 1 for yes and 2 for no");
                yesOrNo = Console.ReadLine();

                if (yesOrNo == "1")
                {
                    Console.WriteLine("Great!");
                    Console.WriteLine();
                    products.productsOrder();
                }
                else if (yesOrNo == "2")
                {
                    Console.WriteLine("Alright bye!");
                }

                else
                {
                    Console.WriteLine("Please enter a given number...");
                    shoppingInstructions();
                }

            }


            




        }
    }
}
