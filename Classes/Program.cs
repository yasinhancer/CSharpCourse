using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //inheritance'nin adını her zaman camelCase yapıyorum!
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Yasin"; //her değer verdiğimde property'deki 'set' bloğu çalışıyor.
            customer1.LastName = "Hançer";
            customer1.City = "Sinop";

            Console.WriteLine(customer1.FirstName); //burada çalışan ise 'get' bloğudur.

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Sinop",
                FirstName = "Doğan",
                LastName = "Hançer"
            };
            Console.ReadLine();
        }
    }
}
