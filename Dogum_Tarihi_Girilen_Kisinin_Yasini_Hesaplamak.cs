namespace DogumTarihiGirilenKisininYasiniHesaplamak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dogum tarihi girilen kisinin yasini hesaplayan uygulamayi yaziniz.


            // Cozum - 1:

            Console.Write("Lutfen dogum tarihini giriniz(GG.AA.YYYY): ");
            DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());

            TimeSpan sonuc = DateTime.Now - dogumTarihi;
            Console.WriteLine(sonuc.Days / 365);

            // Cozum - 2:

            Console.Write("Lutfen dogum tarihinizi giriniz(GG.AA.YY): ");
            DateTime dogumTarihi2 = DateTime.Parse(Console.ReadLine());
            DateTime bugun = DateTime.Now;

            int yas = bugun.Year - dogumTarihi2.Year;

            if (dogumTarihi2 > bugun.AddYears(-yas))
            {
                yas--;
            }

            Console.WriteLine(yas);

            // Cozum - 3:

            Console.Write("Lutfen dogum tarihi giriniz(GG.AA.YYYY): ");
            DateTime dogumTarihi3 = DateTime.Parse(Console.ReadLine());

            int gun = (DateTime.Now - dogumTarihi3).Days;

            int yas2 = gun / 365;
            int kalan = gun % 365;

            Console.WriteLine($"Yas: {yas2} | {yas2 + 1} yasiniza kalan gun sayisi: {365 + (yas2 * 1 / 4) - kalan}");          // (yas * 1 / 4) -> şubat ayı 4 yılda bir 29 gün cektigi icin gerekli bu islem.



        }
    }
}
