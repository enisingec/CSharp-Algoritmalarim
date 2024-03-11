namespace Girilen_Uc_Basamakli_Bir_Sayinin_Basamaklarinin_Kupleri_Toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen 3 basamakli bir sayinin basamaklarinin kupleri toplami sayinin kendine esit olup olmadigi bulan uygulamayi yaziniz ?


            // Cozum - 1:

            Console.Write("Lutfen 3 basamakli bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());



            if (Basamak(sayi))
            {
                int _sayi = sayi;
                double kupToplam = 0;
                while (true)
                {
                    int basamak = _sayi % 10;
                    _sayi /= 10;

                    kupToplam += Math.Pow(basamak, 3);

                    if (_sayi < 10)
                    {
                        basamak = _sayi;
                        kupToplam += Math.Pow(basamak, 3);
                        break;
                    }
                }
                if (kupToplam == sayi)
                {
                    Console.WriteLine("Esittir.");
                }
                else
                {
                    Console.WriteLine("Esit degildir.");
                }
            }
            else
            {
                Console.WriteLine("Lutfen sadece 3 basamakli bir sayi giriniz.");
            }

        }
        static bool Basamak(int sayi)
        {
            int basamaksayisi = 1;

            while (true)
            {
                basamaksayisi++;
                sayi /= 10;

                if (sayi < 10)
                {
                    break;
                }
            }

            return basamaksayisi == 3 ? true : false;               // Ternary operatoru!

        }
    }
}
