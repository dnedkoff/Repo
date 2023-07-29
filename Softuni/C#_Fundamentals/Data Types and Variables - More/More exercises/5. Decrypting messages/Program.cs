using System;

namespace _5._Decrypting_messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());

            string word = "";

            for (int i = 0; i < numberOfLines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int inputToInt = (int)input + key;
                char word1 = (char)inputToInt;
                word += word1;
            }
            Console.WriteLine(word);
        }
    }
}
