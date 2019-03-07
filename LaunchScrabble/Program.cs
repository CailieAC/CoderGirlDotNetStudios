using System;

namespace LaunchScrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 6, 33 };
            string output = String.Join(',', numbers);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
