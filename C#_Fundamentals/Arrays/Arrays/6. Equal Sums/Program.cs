namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            //int elementIndex;
            bool equalSums = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == 0)
                {
                    leftSum = 0;
                }
                else
                {
                    for (int n = 0; n < i; n++)
                    {
                        leftSum += inputArray[n];
                    }
                }
                if (i == inputArray.Length - 1)
                {
                    rightSum = 0;
                }
                else
                {
                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        rightSum += inputArray[j];
                    }
                }
                if (leftSum == rightSum)
                {
                    //elementIndex= i;
                    equalSums = true;
                    Console.WriteLine(i);
                }
                leftSum= 0;
                rightSum= 0;
            }
            if (equalSums == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}