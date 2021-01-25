using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops // DÖNGÜLER
{
    class Program
    {
        static void Main(string[] args)
        {
            // DÖNGÜLER - LOOPS

            //FOR DÖNGÜSÜ
            for (int i = 1; i <= 100; i++) //1 den başlayıp 100 dahil'e kadar sayıları yazdırmış olduk.
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
            // Döngüde; ilk noktalı virgüle kadarki kısım sayacımızdır, döngü o değerden başlar.
            // ikinci kısım: .... olduğu sürece anlamına gelir. Yukarıdaki anlamı: i 100 dahil 'den küçük olduğu sürece
            // üçüncü kısım: Bu kısma bir dönüş bittiğinde, ne yapılmasını istediğimizi yazarız.
            // i++ : birer birer arttır. i+=2 / i=i+2 : ikişer ikişer artır

            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            //yukarıdaki döngüde ise 100den başlayarak, 2şer 2şer azaltarak (i=i-2) 0'a kadar saydırmış olduk.
            Console.WriteLine("Finished!");

            //WHİLE DÖNGÜSÜ
            int number = 100;
            while (number >= 0) //döngü içerideki şart sağlandığı sürece dönüp durur. 
            {
                Console.WriteLine(number);
                number--; //sayıyı bir bir azalt demektir.
            }
            //döngü sonsuz döngüye girmesin diye number--; yazdık.
            Console.WriteLine("Now number is {0}", number);
            Console.WriteLine("Finished!");

            //DO WHİLE DÖNGÜSÜ
            //bu döngüde şart sağlanmasa bile do'dan dolayı döngü 1 kez çalışacaktır.
            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;
            } while (number >= 11);
            // şart sağlanmamasına rağmen ekrana 10'u bir kez verdi.
            // mutlaka yapmak zorunda olduğumuz bir şeyi programlama çerçevesinde kontrol etmek amacıyla kullanılabilir.

            Console.WriteLine("Finished!");

            //FOREACH DÖNGÜSÜ
            string[] students = { "Yasin", "Doğan", "Yusuf" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            //foreach READ ONLY bir döngüdür. İçerisinde değişiklik vs yapılamaz.
            Console.WriteLine("Finished!");
            Console.WriteLine("Finished!");
            Console.WriteLine("Finished!");

            if (IsPrimeNumber(6)) 
            {
                Console.WriteLine("This is a prime number.");
            }
            else 
            {
                Console.WriteLine("This is not a prime number.");
            }

            //bu sayede aşağıdaki programımızı kullanmış olduk.
            
            Console.ReadLine();
        }

        //ASAL MI DEĞİL Mİ?
        private static bool IsPrimeNumber(int number) //asal sayı mı?
        {
            bool result = true; //sonuç varsayılan olarak asal olsun, aşağıdaki şartı sağlayanları false yaparak listeden çıakrtacağız.
            for (int i = 2; i < number - 1; i++)

                if (number % i == 0) // sayının i'ye olan modu (%) 0 ise Yani; sayının i'ye bölümünden kalan 0 ise 
                {
                    result = false;
                    i = number; //bu kod sayesinde örneğin i 6 olduğunda, asal olmayacağı için alttan devam edecek
                }
            return result; //bu sayede asal olmayanlar false olacağı için elenecek, elimizde asal olanlar result olarak gelecek.
            
        }



    }
}
