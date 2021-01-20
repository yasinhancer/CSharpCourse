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
        static int Add3(int number1, int number2=30) // EĞER NUMBER 2 VERİLMEZSE, ONU 30 OLARAK AL DEMEKTİR.
        {
            var result = number1 + number2;
            return result;
        }
        //NOT: ATANAN DEFAULT DEĞERLER, HER ZAMAN METODUN EN SONUNDAKİ DEĞERİN OLMASI GEREKİYOR.
    }
}
