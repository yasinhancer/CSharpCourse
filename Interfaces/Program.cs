using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //CustomerManagerDBDemo();

            ICustomerDal[] customerDals = new ICustomerDal[3] //3 elemanlı array tanımladım.
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal() //yeni eklediğim veri tabanını da hiçbir koda dokunmadan rahatça kullanabiliyorum.
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add(); //bu kod sayesinde bir veriyi birden fazla veritabanına atabiliyorum.
            }


            Console.ReadLine();
        }

        //NOT: INTERFACE'LER NEW'LENEMEZ!!!

        private static void CustomerManagerDBDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal()); //bu sayede birden fazla databasede kullanabiliyorum.
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            IPerson customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Yasin",
                LastName = "Hançer",
                Address = "İstanbul"
            };

            IPerson student1 = new Student() { Id = 1, FirstName = "Doğan", LastName = "Hançer", Derpartmant = "X" };
            // student kullanmak için de tek satırda bir öğrenci oluşturdum.

            manager.Add(customer1);
            manager.Add(student1);

            Console.ReadLine();
        }
    }
    //interface isimlerinin başına I getirilir. 
    //interfaceler içinde class gibi yapılara ev sahipliği yapar, interface içindeki birşey, onun içindeki classlarda da olmak zorundadır.
    interface IPerson
    {
        int Id { get; set; } //interface'de public yazılmaz. 
        string FirstName { get; set; } //Bu veriler iki tip classda da olacağı için interace içine yazıyorum.
        string LastName { get; set; }
    }

    class Customer : IPerson //interface'i implemente ettim
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; } //sadece müşteriye ait ayrı bir özellik tanımladım.
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Derpartmant { get; set; } //sadece öğrenciye ait ayrı bir özellik tanımladım.
    }
    class Worker : IPerson //kolayca yeni bir sınıf ekleyebiliyorum.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Derpartmant { get; set; }
    }
    class PersonManager
    {
        //hem customer hem de student için bu kodları kullanabilmek için, 
        //ikisinin de implemente etmiş olduğu IPerson tipinde istedim.
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " eklendi.");
        }
    }
}         
