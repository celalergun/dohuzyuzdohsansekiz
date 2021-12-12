using System;

namespace douzyuzdohsansekiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string sonuc = Bol(1, 998001);
            Console.WriteLine(sonuc);
        }

        static string Bol(int kaci, int kaca)
        {
            var sonuc = "";
            int sayi = kaci;

            while (sayi > 0)
            {
                while (sayi < kaca)
                {
                    sayi = sayi * 10;
                    if (sayi < kaca)
                        sonuc = sonuc + "0";
                }
                int bolum = sayi / kaca;
                int kalan = sayi % kaca;
                sayi = kalan;
                sonuc = sonuc + bolum;
                if (sonuc.EndsWith("999"))
                    break;
            }
            return sonuc;
        }
    }
}
