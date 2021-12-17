using System;
using System.Linq;
using System.Collections.Generic;

namespace douzyuzdohsansekiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sonuc = Bol(1, 998001);
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
                if (sonuc.Length >= 2997)
                    break;
            }

            List<string> a = new List<string>();
            if (kaci < kaca)
                a.Add("0.");

            for (int i = 0; i < sonuc.Length; i += 3)
            {
                if ((i + 3) < sonuc.Length)
                    a.Add(sonuc.Substring(i, 3));
                else
                    a.Add(sonuc.Substring(i));
            }
            return string.Join(" ", a);
        }
    }
}
