namespace FaktoriyelHesaplama
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
                Soru:
                    Verilen bir sayının faktöriyelini hesaplayan bir C# programı yazın.

                Kurallar:
                        Kullanıcıdan bir sayı girmesi istenmelidir.
                        Program, kullanıcının girdiği sayının faktöriyelini hesaplamalı ic ice fonksiyonu kullan ve ekrana yazdırmalıdır.

             */

           
            Faktoriyel();
        }

        static void Faktoriyel()
        {
            try
            {
                Console.Write("Bir sayinin faktoriyelini hesaplamak icin lutfen sayi giriniz: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0)
                {
                    int sonuc = 1;
                    while (num > 0)
                    {
                        sonuc *= num;
                        num--;
                    }
                    Console.WriteLine("Sonuc: " + sonuc);
                }
                else
                {
                    Console.WriteLine("Lutfen negatif sayi girmeyiniz!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("HATA: Girilen format hatali Lutfen sayi giriniz!");
            }
        }
    }
}
