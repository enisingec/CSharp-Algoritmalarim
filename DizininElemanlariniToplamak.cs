namespace DizininElemanlariniToplamak
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            /*
                Soru:
                Verilen bir dizideki sayıların toplamını hesaplayan bir C# programı yazın.

                Kurallar:
                Kullanıcıdan bir dizi uzunluğu ve ardından dizinin elemanlarını girmesi istenmelidir.
                Program, kullanıcının girdiği sayıların toplamını hesaplamalı ve ekrana yazdırmalıdır.
             */

            DiziToplamak(DiziOlusturma());
        }

        static int[] DiziOlusturma()
        {
            try
            {
                Console.WriteLine("...::: Bir dizinin elemanlarini toplayan uygulama :::... \n");
                Console.Write("Dizinin uzunlugunu sayi olarak giriniz: ");
                int dizi_uzunlugu = Convert.ToInt32(Console.ReadLine());
                int[] dizim = new int[dizi_uzunlugu];

                Console.WriteLine("Dizinin elemanlarini tek tek girin:");
                for (int i = 0; i < dizim.Length; i++)
                {
                    Console.Write(i + 1 + ".sayi giriniz: ");
                    dizim[i] = Convert.ToInt32(Console.ReadLine());
                }

                return dizim;
            }
            catch (FormatException)
            {
                Console.WriteLine("HATA: Girilen format hatali Lutfen sayi giriniz!");
                return new int[0];
            }
        }

        static void DiziToplamak(int[] dizi)
        {
            if (dizi.Length != 0)
            {
                int sonuc = 0;
                foreach (var VARIABLE in dizi)
                {
                    sonuc += VARIABLE;
                }

                Console.WriteLine("Sonucu: " + sonuc);
            }
        }
    }
}
