namespace GirilenPozitifSayininKacBasamakli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen pozitif sayinin kac basamakli oldugunu soyleyen uygulamayi yaziniz ?

            // Cozum - 1:

            Console.Write("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz: ");
            float sayi = float.Parse(Console.ReadLine());

            float _sayi = sayi;
            int sayac = 0;
            for (; sayi >= 10;)
            {
                sayi /= 10;
                sayac++;
            }

            Console.WriteLine($"{_sayi} sayisinin basamak degeri {sayac + 1}");

            // Cozum - 2:

            Console.Write("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc2 = 0;
            int sayac2 = sayi2;
            for (; ; )     // Sonsuz, Kisir dongudur.
            {
                sayac2 /= 10;
                sonuc2++;
                if (sayac2 < 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{sayi2} sayisi {sonuc2 + 1} basamaklidir.");

            // Cozum - 3:

            Console.Write("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());

            int sonuc3 = 1;              // en son kod da sonuc + 1 demeye gerek kalmadi sonuc 1 dedik
            int sayac3 = sayi3;
            while (sayac3 >= 10)         // donguyu sonsuz true yazip dongu icinde if ile break komutunu da kullanabilirdik!
            {
                sayac3 /= 10;
                sonuc3++;
            }


            Console.WriteLine($"{sayi3} sayisinin basamak sayisi: {sonuc3}");

            // Cozum - 4:

            Console.Write("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz: ");
            int sayi4 = int.Parse(Console.ReadLine());

            int sonuc4 = 0;
            int sayac4 = sayi4;
            do
            {
                sayac4 /= 10;
                sonuc4++;

            } while (sayac4 >= 10);

            Console.WriteLine($"{sayi4} sayisinin basamak sayisi {++sonuc4}");                // ++sonuc demek ilk once degeri artir sonra yazdirir.

            // Cozum - 5:

            Console.Write("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz:");
            int sayi5 = int.Parse(Console.ReadLine());

            int sonuc5 = BasamakSayisi(sayi5);

            Console.WriteLine($"{sayi5} sayisinin basamak sayisini {sonuc5}");

            // Cozum - 6:

            Console.Write("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz: ");
            int sayi6 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{sayi6} sayinin basamak sayisi: {sayi6.ToString().Length}");
            
        }

        static int BasamakSayisi(int sayi)
        {
            sayi /= 10;
            if (sayi >= 10)
            {
                return 1 + BasamakSayisi(sayi);

            }
            return 2;                                   // normal de return 1; iken neden return 2; yaptik yapmamizin sebebi basamak 1 eksik soyluyorda onun diger cozumu
        }
    }
}
