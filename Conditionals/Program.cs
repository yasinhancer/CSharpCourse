using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            // SINGLE LINE IF TEKNİĞİ
            //Şart bloğu oluşturmanın diğer bir yolu ise;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            //Burada sayı 10 ise ilk kod, değilse : dan sonraki, yani ikinci kod çalışacaktır.

            // SWITCH KOD BLOĞU
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break; //her şarttan sonra break yazarak bloğu durdur.
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }




            Console.ReadLine();
        }
    }
}
