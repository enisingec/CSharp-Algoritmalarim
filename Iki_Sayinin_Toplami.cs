namespace IkiSayininToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iki sayinin toplamini veren uygulamayi yaziniz ?

            // Cozum - 1:

            int sayi1 = 10;
            int sayi2 = 20;
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);



            int sayi_1 = 10, sayi_2 = 20;
            Console.WriteLine(sayi_1 + sayi_2);


            // Cozum - 2:
            // Kullanicidan veri ister!

            Console.Write("Lutfen sayi1 degerini giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());                      // Convert.ToInt32() ile donusturduk.

            Console.Write("Lutfen sayi2 degerini giriniz: ");
            int sayi4 = int.Parse(Console.ReadLine());                            // int.Parse() ile donusturduk.

            Console.WriteLine(sayi3 + sayi4);

            // Cozum - 3:
            // Kullanici sayisal veri disinda veri girerse hata verir hatayi kontrol altina almazsak program patlar!

            try
            {
                Console.Write("Lutfen sayi1 degerini giriniz: ");
                int sayi5 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lutfen sayi2 degerini giriniz: ");
                int sayi6 = int.Parse(Console.ReadLine());

                Console.WriteLine(sayi5 + sayi6);
            }
            catch
            {
                Console.WriteLine("hata: Lutfen sadece sayi giriniz!");
            }


        }
    }
}
