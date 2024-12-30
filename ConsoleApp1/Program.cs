using System;
using System.IO;
using System.Text;


namespace fuck
{
    public class Program
    {
        public static void Main()
        {
            string test="test";
                
            Console.WriteLine("test \n");
            string? verify = Console.ReadLine();
            int yay = String.Compare(test, verify);
            if (yay == 0)
            {
                Console.WriteLine("\n :D \n");
            }
                
            else
            {
                Console.WriteLine("\n :c \n");
            }
        }
    }
}
