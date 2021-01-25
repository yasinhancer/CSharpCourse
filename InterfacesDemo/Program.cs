using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] //çalışmasını istediğim çalışanlarımı ekledim 
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers) //foreach döngüsü sayesinde eklediğim çalışanlarıma tek tek çalış emri verdim.
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
    //INTERFACE'LERİN DOĞRU PLANLANMASI / SOL(I)D >>> I: INTERFACE SEGREGATION
    //Robotlar yemek ve maaş almadığından, tek interface içinde 3 metodu da tutmak yerine,
    //her metot için ayrı interface oluşturuyorum. NOT: classda birden fazla interface kullanılabilir.
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    //bir class birden fazla interface'i implemente edebilir.
    class Manager : IWorker, IEat, ISalary //yönetici çalışan
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat,ISalary //çalışan
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker //robot
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
