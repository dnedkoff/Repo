namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = PrintSmallestNumber();
            Console.WriteLine(smallestNumber);
        }

        static int PrintSmallestNumber()
        {
            int[] numbers = new int[3];
            int number = 0;
            for (int i = 0; i < 3; i++)
            {
                number = int.Parse(Console.ReadLine());
                numbers[i] = number;   
            }
            int smallestNumber = int.MaxValue;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] <= smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
            }
            
            return smallestNumber;
        }
    }
}