using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays // DİZİLER
{
    class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Engin";
            //string student2 = "Derin";
            //string student3 = "Salih";

            //böyle yapmak yerinde bunları bir dizi içerisinde yazarsak, sonrasındaki işlemler kolay olur.

            string[] students = new string[3]; //string tipinde, students adında, 3 elemanlı (0,1,2) bir dizi oluştur.
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            //bu sayede foreach döngüsü kullanarak öğrencileri listeleyebileceğiz

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[] students2 = { "Yasin", "Doğan", "Yusuf" }; //bu şekilde de oluşturulabilir.

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            //ÇOK BOYUTLU DİZİLER
            //bir dizi içinde birden fazla veriyi listeleyebiliriz örneğin; türkiyenin bölgeleri ve o bölgelerdeki şehirler

            //2 boyutlu bir dizi tanımlayalım

            //2 boyutlu, regions adında, 5 satır 3 sütunlu bir dizi oluşturduk.
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Sinop" },
                {"İzmir","Muğla","Manisa" },
            };
            //5 satır 3 sütun oluşturduk.

            for (int i = 0; i <= regions.GetUpperBound(0); i++) // satır = 0. dimention, sütun = 1. dimention , satırları gezmiş olduk.
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*");
            }



            Console.ReadLine();
        }

    }
}
