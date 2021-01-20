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
            var number = 300;
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

            //CONTROL+K SONRA CONTROL+D KOD BLOKLARINI VE BOŞLUKLARI OLMASI GEREKTİĞİ GİBİ YAPAR

            //ARALIKLI ŞART BLOĞU

            if (number >= 0 && number <= 100) // && : VE
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0) // || : YA DA 
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            
            //IF İÇİNDE IF YAZMA
            
            if (number < 100)
            {
                if (number >= 90 && number < 100)
                {

                }
            }

            Console.ReadLine();
        }
    }
}
