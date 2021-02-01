using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Gürkan";
            customer1.Surname = "Yakar";
            customer1.Age = 22;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "John";
            customer2.Surname = "Doe";
            customer2.Age = 30;



            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            
            customerManager.List();
            Console.WriteLine("---------------------------------");
            customerManager.Delete(customer2);
            customerManager.List();





        }
    }
}
