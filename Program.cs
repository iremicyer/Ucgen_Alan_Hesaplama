using System;

namespace Ucgen_Alan_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ucgenin yuksekligini giriniz:");
            double yukseklik = Convert.ToDouble(Console.ReadLine());

            Console.Write("ucgenin taban uzunlugunu giriniz:");
            double taban = Convert.ToDouble(Console.ReadLine());

            double sonuc = (taban * yukseklik) / 2;
            Console.Write("ücgenin alani:" + sonuc);
        }
    }
}
