namespace PozitifSayilardaCarpmaIsleminiToplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pozitif sayilarda carpma islemini toplama kullanarak bulan uygulamayi yaziniz ?

            // Cozum - 1:

            Console.Write("Lutfen birinci sayiyi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen ikinci sayiyi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int carpmaSonucu = 0;
            for (int i = 0; i < sayi1; i++)
            {
                carpmaSonucu += sayi2;
            }

            Console.WriteLine($"{sayi1} x {sayi2} = {carpmaSonucu}");

            // Cozum - 2:

            Console.Write("Lutfen birinci sayiyi giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen ikinci sayiyi giriniz: ");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            int sayac = sayi4;
            int sonuc = 0;

            while (sayac > 0)
            {
                sonuc += sayi3;
                sayac--;
            }
            Console.WriteLine($"{sayi3} x {sayi4} = {sonuc}");

            // Cozum - 3:

            Console.Write("Lutfen birinci sayiyi giriniz: ");
            int sayi5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen ikinci sayiyi giriniz: ");
            int sayi6 = Convert.ToInt32(Console.ReadLine());

            int sayac2 = sayi5;
            int sonuc2 = 0;

            do
            {
                sonuc2 += sayi6;
                sayac2--;

            } while (sayac2 > 0);

            Console.WriteLine($"{sayi5} x {sayi6} = {sonuc2}");

            // Cozum - 4:
            // Eger ki bir fonksiyon kendi icerisinde kendini cagiriyorsa ona recursive fonksiyon denir.
            // Recursive fonksiyonlar dongusel islemler yapmamizi saglayan manevralar olustururlar.

            Console.Write("Lutfen birinci sayiyi giriniz: ");
            int sayi7 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen ikinci sayiyi giriniz: ");
            int sayi8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{sayi7} x {sayi8} = {Topla(sayi7, sayi8)}");
        }

        static int Topla(int sayi1, int sayi2)
        {
            if (sayi2 > 1)
            {
                return sayi1 + Topla(sayi1, --sayi2);
            }
            return sayi1;
        }
    }
}
