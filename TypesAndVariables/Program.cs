using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! (12.01.2020)");
            // VALUE TYPES - VERİ TİPLERİ
            //KOD BİTTİĞİNDE ; KOYARAK SATIRI TAMAMLAMAYI UNUTMA!!!
            // veri tipi , değişken adı = değeri şeklinde yazılır.

            //BYTE VERİ TİPİ / 8 BİT YER TUTAR

            byte number1 = 250;
            Console.WriteLine("number1 is {0}",number1);
            // 0/255 (dahil/dahil) = BYTE veri tipinin limitleri
            
            
            //SHORT VERİ TİPİ / 16 BİT YER TUTAR

            short number2 = 245;
            Console.WriteLine("number2 is {0}", number2);
            // -32768 / +32767 SHORT veri tipinin limitleri

            //INT VERİ TİPİ / 32 BİT YER TUTAR

            int number3 = 10;
            Console.WriteLine("number3 is {0}",number3); // number 1 is {0} - number1 sayısının ilk değeri
            // -2147483648/+2147483647 = INT veri tipinin limitleri 
            
            //LONG VERİ TİPİ / 64 BİT YER TUTAR
            
            // int limitlerinden daha büyük/küçük sayıları LONG veri tipiyle yazabiliyoruz
            long number4 = 2147483647;
            Console.WriteLine("number4 is {0}", number4);
            // ANCAK, LONG BELLEKTE DAHA FAZLA YER KAPLAR, GEREKSİZ YERE KULLANILMASI ÖNERİLMEZ!
            // -9223372036854775808/+9223372036854775807 = LONG veri tipinin limitleri

            //DOUBLE VERİ TİPİ / TAM - ONDALIKLI SAYILAR ATANABİLİR, VİRGÜLDEN SONRA 16-17 KARAKTER - 64 BİT YER TUTAR
            double number5 = 10.5;
            Console.WriteLine("number5 is {0}",number5);

            //DECİMAL VERİ TİPİ / DAHA UZUN/HASSAS ONDALIKLAR İÇİN KULLANILIR, VİRGÜLDEN SONRA 28-29 KARAKTER
            decimal number6 = 10.4m; //ONDALIKLI KISMIN SONUNA 'm' KOY
            Console.WriteLine("number 6 is {0}",number6);
            
            
            
            // BOOL VERİ TİPİ / TRUE VEYA FALSE
            bool condition = false;
            bool condition2 = true;

            //CHAR VERİ TİPİ / KARAKTER / TEK TIRNAK İÇİNDE YAZILIR
            Char character = 'A'; // tek harf olamlı
            Console.WriteLine("Character is : {0}",character);

            



            // VAR KEYWORD'Ü VE KULLANIMI
            //veri tipini yazdığımız yere 'var' yazarsak, tanımladığımız İLK değişkenin tipi ne ise ona dönüşür.
            //sanki başına veri tipi yazılmış gibi olur. ilk tanımlamadan sonra veri tipi DEĞİŞTİRİLEMEZ!
            var number7 = 57;
            Console.WriteLine("number 7 is {0}", number7);


            Console.ReadLine();



















        }
    }



    //ENUM VERİ TİPİ / ENUM SABİTLERİ
    //BU VERİLER BAŞKA HERHANGİ BİR YERDEN 'Days.' KOYULARAK KULLANILABİLİR/ERİŞİLEBİLİR.
    enum Days
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    //enum içindeki her veri için default olarak bir sayı tanımlanır, varsayılanda bu 0 ile başlar.
    //yani Monday=0, int dönüşümü yapıldığında görülebilir.
    //varsayılan sayı karşılıklarını değiştirebiliriz. Monday=! yaptığımızda artık sırasıyla 1,2,3,4,5,6,7 oldu.
}
