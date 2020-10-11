using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration_1_OOP
{
    class Products
    {
        public List<String> _ListOfProducts = new List<string>();
        public int _products;

        public void productsOrder()
        {
          

            

            Console.WriteLine("Here are the things you can buy:");
            Console.WriteLine("1. 1kg Pasta");
            Console.WriteLine("2. 1kg Rice");
            Console.WriteLine("3. 1kg Potatoes");
            Console.WriteLine("0. Finish your shopping");
            Console.WriteLine("");
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
                        _ListOfProducts.Add("1kg potato");
                        continue;

                    case 2:
                        _ListOfProducts.Add("1kg Rice");
                        continue;

                    case 3:
                        _ListOfProducts.Add("1kg potatoes");
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
