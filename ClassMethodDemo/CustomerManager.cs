using System;
using System.Collections;

using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        ArrayList customerList = new ArrayList();

        public void Add(Customer customer)
        {
            customerList.Add(customer);
            Console.WriteLine(customer.Name + " " + customer.Surname + " Müşteri Listesine Eklendi. ");
        }

        public void List()
        {
            Console.WriteLine("--------------Müşteri Listesi------------");
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer.Name +" "+customer.Surname);
            }
        }
        public void Delete(Customer customer)
        {
            customerList.Remove(customer);
            Console.WriteLine(customer.Name + " " + customer.Surname + " Müşteri Listesinden Silindi. ");
        }
    }
}
