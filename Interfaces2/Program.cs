using System;

namespace Interfaces2
{
    class Program
    {
        //interface new'lenemez !!!
        static void Main(string[] args)
        {
            //interface ikisini de içerdiği için bu şekilde miras alabiliyorum.
            IPersonManager customerManager = new CustomerManager(); 
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager); //interface sayesinde istediğim tipte class gönderebileceğim
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());
            //en son eklediğim yeni stajyer sınıfını, hiçbir koduma kodunmadan hızlıca algoritmaya dahil edebildim.
        }
    }

    interface IPersonManager //interface bir nevi şablon oluşturmak gibidir
    {
        void Add();
        void Update();
    }

    class CustomerManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi."); ; 
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi."); ;
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

    
}
