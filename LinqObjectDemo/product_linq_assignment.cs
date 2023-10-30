using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjectDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }
    }
    
    public class product_linq_assignment
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Product{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Product{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Product{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Product{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };

            //linq
            //1.Display all products using LINQ query
            var res =from p in products
                    select p;


            /*foreach (Product item in res)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
              */



            //2.Display products whose price is greater than 1500
            var res1 = from p in products
                       where p.Price > 1500
                       select p;


          /*  foreach (Product item in res)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }*/



            //3.Display products whose price is in between 10000 to 40000
            var res2 = from p in products
                       where p.Price > 10000 && p.Price < 40000
                       select p;


            /* foreach (Product item in res2)
             {
                 Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
             }*/


            //4.Display products of Dell company

            var res3 = from p in products
                       where p.CompanyName == "Dell"
                       select p;

            /*foreach (Product item in res3)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
*/


            //5.Display all company laptops

            var res5 = from p in products
                       where p.Name == "Laptop"
                       select p;
            /*foreach (Product item in res5)
             {
               Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
             }*/


            //6.Display products whose company name start with ‘M’

            var res6 = from p in products
                       where p.CompanyName.StartsWith("M")
                       select p;
            

           /* foreach (Product item in res6)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
           */

            //7. Display all company mouse whose price is less than 1000
            var res7 = from p in products
                       where p.Name == "Mouse" && p.Price < 1000
                       select p; 
            /*foreach (Product item in res7)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
             */


            //8. Display all products descending order by their price
            var res8= from p in products
                      
                       orderby  (p.Price)  descending
                      select p;

           /* foreach (Product item in res8)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }*/



            //9Display all products accessing order by their company name
            var res9 = from p in products
                       orderby (p.CompanyName)
                       select p;

            /*foreach (Product item in res9)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }*/


            //10.  Display all keyboards accessing order by their price

            var res10 = from p in products
                        where p.Name == "Keyboard"
                        orderby  (p.Price)
                        select p;

            /*foreach (Product item in res10)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }*/



            ////////////////////////////////////////////////////////////////////////////////////

            //using lambda query


            //1.Display all products descending order by their price
               var res11= products.OrderBy(p => p.Price);
            /* foreach (Product item in res11)
             {
                 Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
             }*/



            //2.Display product whose Id is 
            var res12 = products.Where(p => p.Id == 2).Single();

           /*if(res12 != null)
            {
                Console.WriteLine($"{res12.Id},{res12.Name},{res12.Price},{res12.CompanyName}");
            }
           else
            {
                Console.WriteLine("not product found");
            }
             */


            //3.Display all products whose price less than 5000
            var res13 = products.Where(p => p.Price <5000).ToList();
            /*foreach (Product item in res13)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }*/

            //4 Display 3 products which have maximum price
            var res14 = products.OrderByDescending(p => p.Price).Take(3)  ;

            foreach (Product item in res14)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }


            Console.WriteLine("           ");
            //5Display 5 products which have minimum price
            var res15 = products.OrderBy(p => p.Price).Take(5) ;

            foreach (Product item in res15)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }







            Console.ReadLine();






        }
    }
}
