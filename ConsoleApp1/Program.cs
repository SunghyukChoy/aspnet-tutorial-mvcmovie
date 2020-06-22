using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i = 2; i <= 9; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(i + "단\n");
                for(int j = 1; j <=9; j++)
                {
                    Console.WriteLine(i + "*" + j + " = " + (i*j));
                }
            }
        }

        public static bool SameCase(string str)
        {
            return false;
        }
    }
}
