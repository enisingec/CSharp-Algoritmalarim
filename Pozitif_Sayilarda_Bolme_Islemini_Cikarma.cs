namespace PozitifSayilardaBolmeIsleminiCikarmaKullanarak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pozitif sayilarda bolme islemini cikarma kullanarak yapan uygulamayi yaziniz ?

            // Cozum - 1:

            Console.Write("Lutfen bolmek istediginiz sayiyi giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Lutfen boleceginiz sayiyi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int DonguAdedi = sayi1;

            int sonuc = 0;
            int kalan = 0;
            for (int i = 0; i < DonguAdedi; i++)
            {
                sayi1 -= sayi2;
                sonuc++;

                if (sayi1 < sayi2)
                {
                    kalan = sayi1;
                    break;
                }
            }

            Console.WriteLine($"{DonguAdedi} / {sayi2} = {sonuc} | kalan = {kalan}");

            // Cozum - 2:

            Console.Write("Lutfen bolmek istediginiz sayiyi giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());

            Console.Write("Lutfen boleceginiz sayiyi giriniz: ");
            int sayi4 = int.Parse(Console.ReadLine());


            int _sayi2 = sayi3;
            int sonuc2 = 0;
            int kalan2;
            while (true)
            {

                sonuc2++;
                sayi3 -= sayi4;

                if (sayi3 < sayi4)
                {
                    kalan2 = sayi3;
                    break;
                }

            }

            Console.WriteLine($"{_sayi2} / {sayi4} = {sonuc2} | Kalan: {kalan2}");

            // Cozum - 3:

            Console.Write("Lutfen bolmek istediginiz sayiyi giriniz: ");
            int sayi5 = int.Parse(Console.ReadLine());

            Console.Write("Lutfen boleceginiz sayiyi giriniz: ");
            int sayi6 = int.Parse(Console.ReadLine());

            int _sayi3 = sayi5;
            int sonuc3 = 0;
            int kalan3 = 0;

            do
            {
                sonuc3++;
                sayi5 -= sayi6;

                if (sayi5 < sayi6)
                {
                    kalan3 = sayi5;
                    break;
                }
            } while (true);

            Console.WriteLine($"{_sayi3} / {sayi6} = {sonuc3} | {kalan3}");

            // Cozum - 4:

            Console.Write("Lutfen bolmek istediginiz sayiyi giriniz: ");
            int sayi7 = int.Parse(Console.ReadLine());

            Console.Write("Lutfen boleceginiz sayiyi giriniz: ");
            int sayi8 = int.Parse(Console.ReadLine());


            Console.WriteLine($"{sayi7} / {sayi8} = {Bol(sayi7, sayi8)} | Kalan = {Kalan(sayi7, sayi8)}");

        }

        static int Bol(int sayi1, int sayi2)
        {
            sayi1 -= sayi2;
            if (sayi1 >= sayi2)
            {
                return 1 + Bol(sayi1, sayi2);
            }
            return 1;
        }

        static int Kalan(int sayi1, int sayi2)
        {
            sayi1 -= sayi2;
            if (sayi1 >= sayi2)
            {
                return Kalan(sayi1, sayi2);
            }
            return sayi1;
        }
    }
}
