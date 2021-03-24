using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2boyutludizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int ogrencısay, a, vize, final;
            string ad, soyad;
            double sonuc;

            Console.WriteLine("Kaç Öğrencinin Notları Girilecek");
            ogrencısay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam " + ogrencısay + " öğreninin notu girilecek");

            for (a = 1; a <= ogrencısay; a++)
            {
                Console.WriteLine("Ad:");
                ad = Console.ReadLine();
                Console.WriteLine("Soyadınızı girin:");
                soyad = Console.ReadLine();

                Console.WriteLine(a + ". Öğrencinin Vize Notunu Gİrin");
                vize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + ". Final Notunu Girin");
                final = Convert.ToInt32(Console.ReadLine());
                sonuc = (vize * 0.4) + (final * 0.6);
                if (sonuc > 0 && sonuc <= 49)
                    Console.WriteLine(a + ad + soyad + "- Not Ortalaması= " + sonuc + " Harf Notu=FF");
                if (sonuc >= 50 && sonuc < 59)
                    Console.WriteLine(a + ad + soyad + "- Not Ortalaması= " + sonuc + " Harf Notu=CC");
                if (sonuc > 60 && sonuc < 69)
                    Console.WriteLine(a + ad + soyad + "- Not Ortalaması= " + sonuc + " Harf Notu=CB");
                if (sonuc > 70 && sonuc < 79)
                    Console.WriteLine(a + ad + soyad + "- Not Ortalaması= " + sonuc + " Harf Notu=BB");
                if (sonuc > 80 && sonuc < 89)
                    Console.WriteLine(a + ad + soyad + "- Not Ortalaması= " + sonuc + " Harf Notu=BA");
                if (sonuc > 90 && sonuc <= 100)
                    Console.WriteLine(a + ad + soyad + "- Not Ortalaması= " + sonuc + " Harf Notu=AA");
                if (sonuc > 100)
                    Console.WriteLine(a + ad + soyad + "Yanlış not girdiniz.");

            }

        }
    }
}
