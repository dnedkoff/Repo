using System;
using System.Numerics;

namespace _2._From_Left_to_the_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfLines; i++)
            {
                string input = Console.ReadLine();
                string[] inputSplit = input.Split(' ');

                string leftSide = inputSplit[0];
                string rightSide = inputSplit[1];

                long leftSideInt;
                long rightSideInt;

                long.TryParse(leftSide, out leftSideInt);
                long.TryParse(rightSide, out rightSideInt);

                long sum = 0;

                if (leftSideInt >= rightSideInt)
                {
                    for (int j = 0; j < leftSide.Length; j++)
                    {
                        sum += Math.Abs(leftSideInt % 10);
                        leftSideInt /= 10;
                    }
                }
                else 
                {
                    for (int j = 0; j < rightSide.Length; j++)
                    {
                        sum += Math.Abs(rightSideInt % 10);
                        rightSideInt /= 10;
                    }

                } 
                Console.WriteLine(sum);
               
            }
        }
    }
}
