using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal // DAL >>> DATA ACCES LAIR
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated"); ;
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
            ;
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
            ;
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");

        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
            ;
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
            ;
        }
    }

    //oluşturduğum interface sayesinde, aşağıdaki metodu iki farklı veritabanında da kullanabiliyorum.
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) 
        {
            customerDal.Add();
        }
    }

}
