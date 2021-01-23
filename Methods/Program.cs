using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(25, 30);
            Console.WriteLine(result);

            //CHALLENGE - ADD4


            int sayi1 = 20;
            int sayi2 = 100;

            var result2 = Add4(sayi1, sayi2);

            Console.WriteLine(result2);
            Console.WriteLine(sayi1);

            //BURADA SAYI1 20 OLARAK KALACAKTIR. ÇÜNKÜ DEĞER TİPTİR. KARŞISINDAKİ DEĞERİ GÖNDERDİKTEN SONRA,
            //METOTLA İŞİ BİTER. METOTUN İÇİNDEKİ DEĞİŞME ONU ETKİLEMEZ. BİR NEVİ KOPYASINI ÇIKARMAK GİBİDİR.

            //EĞER DEĞİŞMESİNİ İSTİYOSAK HER İKİ TARAFIN BAŞINA DA 'REF' EKLEMELİYİZ. 
            //ADD5 METODUNDA GÖRELİM

            int rakam1 = 5;
            int rakam2 = 8;
            var result3 = Add5(ref rakam1, rakam2); //buraya da aşağısı gibi ref ekledik.
            Console.WriteLine(rakam1);
            //rakam1 başındaki reften dolayı artık referans tip oldu ve değeri 30 olarak değişti.

            //YANİ REF KEYWORDÜ DEĞER TİPLERİNİ REFERANS TİP OLARAK KULLANMAMIZI SAĞLAR

            //REF MANTIĞIYLA ÇALIŞAN BİR DİĞER KEYWORD >> 'out' 
            //bunun ref ten farkı ise, ref koyduğumuzda, metottan önce rakam1'in bir değeri olması gerekir.
            //yani elimizdeki bir değeri metotla değiştiririz. ANCAK out'ta elimizde bir değer olmasına gerek yok.
            //out taki diğer bir zorunluluk ise, değişkenin metotun içinde kullanılmadan önce, mutlaka değişmesi gerekir.
            //yani metot içinde o sayıyı değiştiricek bir kod yoksa out patlar. ilk değerin bir önemi yoktur out için.





            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        // STATİC'DEN SONRA NE TİPTE BİR VERİ DÖNDÜRMEK İSTİYORSAK O TİPİ YAZIYORUZ
        static int Add2(int number1, int number2) //ADI NUMBER1 VE NUMBER 2 OLAN 2 ADET İNT TİPİ VERİ İSTEDİK
        {
            var result = number1 + number2;
            return result;
        }

        //DEFAULT ATAMA 
        static int Add3(int number1, int number2 = 30) // EĞER NUMBER 2 VERİLMEZSE, ONU 30 OLARAK AL DEMEKTİR.
        {
            return number1 + number2;
        }

        //NOT: ATANAN DEFAULT DEĞERLER, HER ZAMAN METODUN EN SONUNDAKİ DEĞERİN OLMASI GEREKİYOR.

        //CHALLENGE 
        static int Add4(int sayi1, int sayi2)
        {
            sayi1 = 30;
            return sayi1 + sayi2;
        }

        //REF KEYWORDÜNÜ KULLANARAK YAPALIM
        static int Add5(ref int rakam1, int rakam2) // int önüne 'ref' yazıyoruz. BURADA YAZDIĞIMIZ İÇİN YUKARIDAKİNE DE YAZMAMIZ GEREKİYOR.

        {
            rakam1 = 3;
            return rakam1 + rakam2;
        }

        //METHOD OVERLOADİNG - METOTLARIN AŞIRI YÜKLENMESİ
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //üstteki metodun ADINI DEĞİŞTİRMEDEN, üç sayılı halini yapabiliriz. 
        //Çünkü multiply kısmından itibaren yazılanlar, o metodun imzası gibidir.
        //dolayısıyla aşağıdaki gibi bir metod yazdığımızda, yukarıdakiyle KARIŞMAYACAKTIR.
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //PARAMS KEYWORDÜ
        // bu şekilde fazla adette değişkenleri toplayabiliyoruz, istediğimiz kadar değişken verebiliyoruz.
        static int Add6(params int[] numbers) 
        {
            return numbers.Sum(); //sum = toplama 
        }
        //NOT: burada params dan önce bir değişken istenip, sonra params yazılabilir.
        //eğer öyle kullanılırsa, verilen ilk değer, paramsdan önceki değişkene atanır. 

    }
}
