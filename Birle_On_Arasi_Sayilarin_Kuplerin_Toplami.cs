namespace BirleOnArasiSayilarinKuplerinToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10,a kadar olan sayilarin kuplerinin toplamini bulan uygulamayi yaziniz ?


            // Cozum - 1:

            double toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam += Math.Pow(i, 3);
            }

            Console.WriteLine(toplam);

            // Cozum - 2:

            double toplam2 = 0;
            int sayac = 1;

            while (true)                // true yerinede sayac <= 10 da diyebilirdik.
            {
                toplam2 += Math.Pow(sayac, 3);

                if (sayac == 10) break;

                sayac++;
            }
            Console.WriteLine(toplam2);

            // Cozum - 3:

            int sayac2 = 1;
            double toplam3 = 0;

            do
            {
                toplam3 += Math.Pow(sayac2, 3);

                if (sayac2 == 10) break;

                sayac2++;

            }
            while (true);                    // true yerinede sayac <= 10 da diyebilirdik.

            Console.WriteLine(toplam3);

            // Cozum - 4:

            int sayac3 = 1;
            double toplam4 = 0;
            string sonuc = "";

            while (sayac3 <= 10)
            {
                toplam4 += Math.Pow(sayac3, 3);

                if (sayac3 != 10)
                {
                    sonuc += $"{sayac3}³ + ";
                }
                else
                {
                    sonuc += $"{sayac3}³ = {toplam4}";
                }
                sayac3++;
            }

            Console.WriteLine(sonuc);
        }
    }
}
