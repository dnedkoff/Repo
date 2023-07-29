namespace _2._Vowels_Count
{
    using System.Diagnostics.Metrics;

    internal class Program
    {
        static void Main(string[] args)
        {
            VowelCounter();
        }

        static void VowelCounter()
        {
            string input = Console.ReadLine();
            int vowelCounter = 0;
            char[] inputToCharArray = input.ToCharArray();
            foreach (char letter in inputToCharArray) {
                if (letter == 97 || letter == 65 || letter == 69 || letter == 101 || letter == 73 || letter == 105 ||
                    letter == 79 || letter == 111 || letter == 85 || letter == 117)
                {
                    vowelCounter++;
                }
            }
            Console.WriteLine(vowelCounter);
        }
    }
}