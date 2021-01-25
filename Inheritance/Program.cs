using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance // KALITIM / MİRAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] //inheritance yapısı sayesinde firstname'i hepsinde kullandım.
            {
                new Customer
                {
                    FirstName = "Doğan"
                },
                new Student()
                {
                    FirstName = "Yasin"
                },
                new Person()
                {
                    FirstName = "Alper"
                }

            };
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person // customer, person'daki özellikleri de barındırsın diye, inheritance yaptık.
    {
        public string City { get; set; } //bu özellik ise sadece customer'a özeldir.
    }

    class Student : Person //Bir class 2 farklı yapıyı inheritance EDEMEZ!, bu yönüyle interface'den farklıdır..
    {
        public string Department { get; set; }
    }

    //BURADA BU KULLANIM SENARYOSUNDA, İNHERİTANCE YERİNE İNTERFACE'DE KULLANILABİLİRDİ.
}
