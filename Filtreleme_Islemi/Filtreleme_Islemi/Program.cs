using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace Filtreleme_Islemi;

class Program
{
    static void Main(string[] args)
    {
        List<string> raw = new List<string>();

        DosyaOkumak(raw);
        DosyaYazdirmak(raw);
    }
    
    static void DosyaOkumak(List<string> raw)
    {
        using (StreamReader reader = new StreamReader("Raw.txt", encoding: Encoding.UTF8))              // Raw.txt dosyanin konumu Project\bin\Debug\net8.0
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                raw.Add(line);
                line = reader.ReadLine();
            }
        }
    }
    
    static void DosyaYazdirmak(List<string> raw)
    {
        File.WriteAllText("Filter.txt", "");                // ilk once dosya icerigi dolu ise temizler.
        using (StreamWriter writer = new StreamWriter("Filter.txt", true))                        // Filter.txt dosyanin konumu Project\bin\Debug\net8.0
        {
            for (int i = 0; i < raw.Count; i++)
            {
                foreach (var character in raw[i])
                {
                    if (!Char.IsDigit(character) && Char.IsLetter(character))               // Filtreleme islemi
                    {
                        writer.Write(character);
                    }
                }
                writer.WriteLine();
            }
        }
        Console.Write("Dosyaya yazildi.");
    }
}