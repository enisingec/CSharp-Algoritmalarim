using System.Runtime;

namespace UsluSayi_Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Uslu sayi hesaplamak icin lutfen taban sayiyi giriniz: ");
                int taban = Convert.ToInt32(Console.ReadLine());

                Console.Write("lutfen kuvvet sayiyi giriniz: ");
                int kuvvet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------\n");

                if (taban != 0 && kuvvet >= 0)
                {
                    Console.WriteLine("Sonuc: " + UsluSayi(taban, kuvvet));
                }
                else if (kuvvet < 0)
                {
                    Console.WriteLine("Lutfen kuvvet degeri pozitif sayi giriniz!");
                }
                else
                {
                    Console.WriteLine("tanimsizdir!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("HATA: Girilen format hatali!");
            }
           
        }

        static int UsluSayi(int taban, int kuvvet)
        {
            if (kuvvet == 0)
            {
                return 1;
            }
            else
            {
                return taban * UsluSayi(taban, kuvvet - 1);
            }
        }
    }
}
