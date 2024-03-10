namespace Dizi_Algoritma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
                Soru:
                    Bir dizideki tüm çift sayıları bir listeye, tek sayıları ise başka bir listeye kopyalayan bir C# programı yazın.

                    İpuçları:
                    Dizideki her sayıyı kontrol etmek için bir döngü kullanın.
                    Sayının çift olup olmadığını kontrol etmek için % operatörünü kullanın.
                    Çift sayıları bir List<int>'e, tek sayıları ise başka bir List<int>'e ekleyin.

                Beklenen Çıktı:
                                Çift Sayılar: [2, 4, 6, 8, 10]
                                Tek Sayılar:  [1, 3, 5, 7, 9]
             
             */


            List<int> Numbers = new List<int>();
            List<int> Tek = new List<int>();
            List<int> Cift = new List<int>();

            TekCiftAyirma(Numbers, Tek, Cift);
        }

        static void TekCiftAyirma(List<int> Numbers, List<int> Tek, List<int> Cift)
        {
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                Numbers.Add(rand.Next(100));
            }

            foreach (int number in Numbers)
            {
                if (number % 2 == 0)
                {
                    Cift.Add(number);
                }
                else
                {
                    Tek.Add(number);
                }
            }

            Console.Write("Cift dizisi: [");
            foreach(int number in Cift)
            {
                Console.Write(number + ", ");
            }
            Console.Write("]\n\n");

            Console.Write("Tek dizisi: [");
            foreach (int number in Tek)
            {
                Console.Write(number + ", ");
            }
            Console.Write("]\n");

        }
    }
}