namespace FaktoriyelHesaplamak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayinin faktoriyelini hesaplayan uygulamayi yaziniz ?

            // Cozum - 1:

            Console.Write("Faktoriyelini hesaplamak icin lutfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = 1;

            for (int i = sayi; i > 0; i--)
            {
                sonuc *= i;
            }

            Console.WriteLine(sonuc);

            // Cozum - 2:

            Console.Write("Faktoriyelini hesaplamak icin lutfen bir sayi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc2 = 1;
            while (sayi2 > 0)
            {
                sonuc2 *= sayi2--;
            }

            Console.WriteLine(sonuc2);

            // Cozum - 3:

            Console.Write("Faktoriyelini hesaplamak icin lutfen bir sayi giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());

            int sonuc3 = 1;
            do
            {

                sonuc3 *= sayi3--;
                if (sayi3 == 0) break;

            } while (true);
            Console.WriteLine(sonuc3);

            // Cozum - 4:
            // Ornek: 5 x 4 x 3 x 2 x 1 = 120

            Console.Write("Faktoriyelini hesaplamak icin lutfen bir sayi giriniz: ");
            int sayi4 = int.Parse(Console.ReadLine());

            int faktoriyel = 1;
            string sonuc4 = "";

            while (sayi4 > 0)
            {
                faktoriyel *= sayi4;
                if (sayi4 != 1)
                {
                    sonuc4 += $"{sayi4} x ";
                }
                else
                {
                    sonuc4 += $"{sayi4} = {faktoriyel}";
                }
                sayi4--;
            }

            Console.WriteLine(sonuc4);


            // Cozum - 5:
            // Eger ki bir fonksiyon kendi icerisinde kendini cagiriyorsa ona recursive fonksiyon denir.

            Console.Write("Faktoriyelini hesaplamak icin lutfen bir sayi giriniz: ");
            int sayi5 = int.Parse(Console.ReadLine());

            Console.WriteLine(Faktoriyel(sayi5));


        }

        static int Faktoriyel(int sayi)
        {
            if (sayi > 1)
            {
                return sayi * Faktoriyel(--sayi);
            }
            return sayi;
        }
    }
}
