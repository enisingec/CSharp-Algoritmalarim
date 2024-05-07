namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lower_letters = "abcdefghijklmnopqrstuvwxyz";
            string upper_letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()_-+=?><[]";

            string all_chars = lower_letters + upper_letters + numbers + symbols;
            Console.Write("Enter a lenght: ");
            int length = Convert.ToInt32(Console.ReadLine());

            string password = "";

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int number = random.Next(0, 80);
                password += all_chars[number];
            }

            Console.WriteLine("Password: " + password);
        }
    }
}
