using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Laboration_1_OOP
{
    class Shopping
    {
        Products products = new Products();

        public List<String> _ListOfProducts = new List<string>();
        public int _products;

        
        public void productsOrder()
        {


            

            Console.WriteLine("Here are the things you can buy:");
            Console.WriteLine("\n 1. 1kg Pasta" +
                "\n 2. 1kg Rice" +
                "\n 3. 1kg Potatoes"  +
                "\n 4. 1 Snickers bar" +
                "\n 5. 1 Twix bar" +
                "\n 6. 1 Lion bar" +
                "\n 0. Finish your shopping" +
                "\n"
                );
            
            Console.WriteLine("Now choose your products by entering the number connected to the product:");


            while (true)
            {
                try
                {
                    _products = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter one of the given options, try again!");
                    continue;
                }

                switch (_products)
                {
                    case 1:
                        Console.WriteLine("1kg pasta have been added to your shoppingcart");
                        _ListOfProducts.Add(products.Item1);
                        continue;

                    case 2:
                        Console.WriteLine("1kg rice have been added to your shoppingcart");
                        _ListOfProducts.Add(products.Item2);
                        continue;

                    case 3:
                        Console.WriteLine("1kg potatos have been added to your shoppingcart");
                        _ListOfProducts.Add(products.Item3);
                        continue;

                    case 4:
                        Console.WriteLine("1 Snickers bar have been added to you shoppingcart");
                        _ListOfProducts.Add(products.Item4);
                        continue;

                    case 5:
                        Console.WriteLine("1 Twix bar have been added to you shoppingcart");
                        _ListOfProducts.Add(products.Item5);
                        continue;

                    case 6:
                        Console.WriteLine("1 Lion bar have been added to you shoppingcart");
                        _ListOfProducts.Add(products.Item6);
                        continue;


                    default:
                        continue;


                    case 0:
                        break;
                }
                break;
            }


            _ListOfProducts.ToArray();

            Console.WriteLine("You ordered the following products:");
            foreach (var ProductList in _ListOfProducts)
            {
                Console.WriteLine(ProductList);
            }
            Console.WriteLine();
            Console.WriteLine("bye!");
        }
         

        
            
            
        
    }
}
