using System.Runtime.InteropServices;

namespace Variables_Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ramde degiskenlerin tutuldugu adresi gormek ve test icin!
            StringDisplayMemoryAddress("Hello, World!");
            StringDisplayMemoryAddress("Hello, World!");

            Console.WriteLine();

            object x = 5;

            ObjectDisplayMemoryAddress(x);
            ObjectDisplayMemoryAddress(x);
        }

        static unsafe void StringDisplayMemoryAddress(string value)   // Project/Properties/Build - > Allow code that uses the 'unsafe' keyword to compile. (Click)
        {
            string text = value;

            fixed (char* p1 = text)
            {
                Console.WriteLine("String Memory address: {0:X}", (IntPtr)p1);
            }
        }

        static void ObjectDisplayMemoryAddress(object value)
        {
            object myObject = value; 

            GCHandle handle = GCHandle.Alloc(myObject, GCHandleType.Pinned);
            IntPtr address = handle.AddrOfPinnedObject();

            Console.WriteLine($"Object bellek adresi: {address}");

            handle.Free(); 
        }
    }
}
