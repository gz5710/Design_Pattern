using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Composite design pattern is for composing the tree structure.
            // Test Employee
            Employee boss = new Employee()
            {
                Position = "Boss",
                Age = 60,
                Department = "Commite"
            };
            Employee cto = new Employee()
            {
                Position = "CTO",
                Age = 55,
                Department = "IT"
            };
            Employee ceo = new Employee()
            {
                Position = "CEO",
                Age = 57,
                Department = "Commerce"
            };
            Employee productManager = new Employee()
            {
                Position = "Product Manager",
                Age = 40,
                Department = "IT"
            };
            Employee techLeader = new Employee()
            {
                Position = "Technical Leader",
                Age = 35,
                Department = "IT"
            };
            Employee support = new Employee()
            {
                Position = "Technical Support",
                Age = 30,
                Department = "IT"
            };
            Employee developer1 = new Employee()
            {
                Position = "C# Developer",
                Age = 26,
                Department = "IT"
            };
            Employee developer2 = new Employee()
            {
                Position = "Java Developer",
                Age = 25,
                Department = "IT"
            };
            Employee developer3 = new Employee()
            {
                Position = "PHP Developer",
                Age = 26,
                Department = "IT"
            };
            Employee seller1 = new Employee()
            {
                Position = "Seller",
                Age = 23,
                Department = "Commerce"
            };
            Employee commerceManager = new Employee()
            {
                Position = "Commerce Manager",
                Age = 43,
                Department = "Commerce"
            };
            Employee seller2 = new Employee()
            {
                Position = "Seller",
                Age = 25,
                Department = "Commerce"
            };
            Employee clientService = new Employee()
            {
                Position = "Client Service",
                Age = 26,
                Department = "Commerce"
            };

            // Construct the tree relation
            boss.Add(ceo);
            boss.Add(cto);
                ceo.Add(commerceManager);
                    commerceManager.Add(clientService);
                    commerceManager.Add(seller1);
                    commerceManager.Add(seller2);

                cto.Add(productManager);
                cto.Add(techLeader);
                    productManager.Add(support);
                    techLeader.Add(developer1);
                    techLeader.Add(developer2);
                    techLeader.Add(developer3);

            Console.WriteLine(boss.ToString(1));
            Console.ReadKey();
        }
    }
}
