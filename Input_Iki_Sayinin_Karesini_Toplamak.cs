namespace InputIkiSayininKaresiniToplamak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanicinin girdigi iki sayinin karelerinin toplamini veren uygulamayi yaziniz ?

            // Cozum - 1:

            Console.Write("Lutfen birinci sayiyi giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Lutfen ikinci sayiyi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());


            int sonuc = (sayi1 * sayi1) + (sayi2 * sayi2);
            Console.WriteLine(sonuc);

            // Cozum - 2:

            Console.Write("Lutfen birinci sayiyi giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen ikinci sayiyi giriniz: ");
            int sayi4 = Convert.ToInt32(Console.ReadLine());


            double sonuc2 = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);               //Ornek: Math.Pow(2, 3)  2 nin 3.kuvveti
            Console.WriteLine(sonuc2);

            // Cozum - 3:

            Console.WriteLine("Lutfen birinci ve ikinci sayilari giriniz: ");
            Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2));

        }
    }
}
