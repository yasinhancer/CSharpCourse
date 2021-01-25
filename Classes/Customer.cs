using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //properties
        //Id değeri verdiğimizde set bloğu,
        //Id değerini yazdırmak gibi işlemler için istediğimizde ise, 'get' bloğu çalışır
        public int Id { get; set; }
        public string _firstName;
        public string FirstName
        {
            get { return "Mr." + _firstName; } //bu kod sayesinde set ettiğim değerleri okurken, başına mr. gelecek.

            set { _firstName = value; }
 
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
