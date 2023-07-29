using System;
namespace _4._Array_Rotation
{
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] inputToInt = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputToInt[i] = int.Parse(input[i]);
            }

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int firstDigit = inputToInt[0];
                for (int j = 0; j < inputToInt.Length - 1; j++)
                {
                    inputToInt[j] = inputToInt[j + 1];

                }
                inputToInt[input.Length - 1] = firstDigit;
            }

            Console.WriteLine(string.Join(' ', inputToInt));
        }
    }
}