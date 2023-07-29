using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int charactersCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= charactersCount - 1; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
