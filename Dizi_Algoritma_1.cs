namespace Dizi_Algoritma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    Soru: Bir dizideki her elemanın sağında bulunan elemanlardan kaç tanesinin o elemandan büyük olduğunu bulan bir C# programı yazınız. 
                          Dizi boyutu ve elemanları kullanıcıdan alınacaktır. Örneğin, [3, 4, 9, 6, 1] dizisi için sonuç [3, 2, 0, 0, 0] olmalıdır.
             */


            DiziElemanlariKontrol();
        }

        static void DiziElemanlariKontrol()
        {
            Console.Write("Dizinin uzunlugunu sayi olarak giriniz: ");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            int[] dizim = new int[diziUzunlugu];
            Console.WriteLine("Dizinin elemanlarini tek tek giriniz:");

            for (int i = 0; i < dizim.Length; i++)
            {
                Console.Write($"{i + 1}.Elemani giriniz: ");
                int result = Convert.ToInt32(Console.ReadLine());
                dizim[i] = result;
            }

            for (int i = 0; i < dizim.Length; i++)
            {
                int buyukElemanSayisi = 0;

                for (int j = i+ 1; j < dizim.Length; j++)
                {
                    if (dizim[i] < dizim[j])
                    {
                        buyukElemanSayisi++;
                    }
                }
                Console.WriteLine($"{i + 1}. elemanin saginda {buyukElemanSayisi} tane daha buyuk eleman var.");
            }
        }
    }
}
