using System;

namespace arageek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteTextToCMD("Hello from void function");

            

        }

        public static void WriteTextToCMD(string text)
        {
            Console.WriteLine(text);
        }
    }

    
}
