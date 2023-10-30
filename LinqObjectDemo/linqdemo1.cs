using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjectDemo
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
    }
    public class linqdemo1
    { 


        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1,Name="Alisha",City="nagar",Salary=8000},
                new Employee { Id = 2,Name="Tanuja",City="pune",Salary=9000},
                new Employee { Id = 3,Name="Tanu",City="nashik",Salary=8700},
                new Employee { Id = 4,Name="Arti",City="satara",Salary=8778},
                new Employee { Id = 5,Name="Nikita",City="mumbai",Salary=9008},
                new Employee { Id = 6,Name="Renuka",City="goa",Salary=4878},
                new Employee { Id = 7,Name="Bhakti",City="benglore",Salary=7878},
                new Employee { Id = 8,Name="Payal",City="rahuru",Salary=9078},
                new Employee { Id = 9,Name="Riya",City="kolhapur",Salary=8978},
                new Employee { Id = 10,Name="Sandesh",City="nagar",Salary=1088},
                new Employee { Id = 11,Name="Chinmay",City="nagar",Salary=8981},
                new Employee { Id = 12,Name="Prasad",City="pune",Salary=6678},
                new Employee { Id = 13,Name="Alisha",City="nagar",Salary=8898}
            };
            var result = from e in employees
                         where e.City == "pune"
                         select e;

           /* foreach(Employee item in result)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }
         */

            ///
            var result2 = from e in employees
                          where e.Name.StartsWith("S")
                          select e;

            /*foreach (Employee item in result2)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/





            //

            var result3 = from e in employees
                          where e.Salary > 4000 && e.City == "pune"
                          select e;


           /* foreach (Employee item in result3)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/

            //

            var result4 = employees.Where(X=> X.City == "mumbai").ToList();
           /* foreach (Employee item in result4)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/

            //
            var result5 = employees.Where(X => X.City == "pune").OrderBy(x => x.Salary).ToList();
            foreach (Employee item in result5)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }


            Console.ReadLine();
        }

    }
}
