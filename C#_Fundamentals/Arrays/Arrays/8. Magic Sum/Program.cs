namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i; j < inputArray.Length - 1; j++)
                {
                    int sum = inputArray[i] + inputArray[j + 1];

                    if (sum == givenNumber)
                    {
                        Console.WriteLine(inputArray[i] + " " + inputArray[j + 1]);
                    }
                }
               
            }
        }
    }
}