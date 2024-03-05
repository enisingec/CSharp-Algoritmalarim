namespace AsalSayiBulma
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
                Soru:
                    Girilen bir sayının asal olup olmadığını kontrol eden bir C# programı yazın.

                Kurallar:
                        Kullanıcıdan bir sayı girmesi istenmelidir.
                        Program girilen sayının asal olup olmadığını kontrol etmeli ve sonucu ekrana yazdırmalıdır.
             */

            AsalSayiKontrol();
        }

        static void AsalSayiKontrol()
        {
            try
            {
                Console.Write("Bir sayı girin ve size bu sayının asal sayı olup olmadığını kontrol eder: ");
                int pNumber = Convert.ToInt32(Console.ReadLine());

                if (pNumber > 0)
                {
                    bool control = false;
                    for (int i = 2; i < pNumber; i++)
                    {
                        if (pNumber % i == 0)
                        {
                            control = true;
                            break;
                        }
                    }

                    if (control == true)
                    {
                        Console.WriteLine(pNumber + " asal sayi degildir!");
                    }
                    else
                    {
                        Console.WriteLine(pNumber + " asal sayidir!");
                    }
                }
                else
                {
                    Console.WriteLine("Lutfen pozitif bir sayi degeri giriniz!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("HATA: Girilen format hatali Lutfen sayi giriniz!");
            }
        }
    }
}
