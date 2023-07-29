using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;

            int linesCount = int.Parse(Console.ReadLine());
            int littersIn = 0;
            for (int i = 0; i < linesCount; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());
                capacity -= litersOfWater;
                if (capacity < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity += litersOfWater;
                }
                else
                {
                    littersIn += litersOfWater;
                }
            }
            Console.WriteLine(littersIn);
        }
    }
}
