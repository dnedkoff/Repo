using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());

            BigInteger highestValue = 0;

            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                if (snowballTime > 0)
                {
                    BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                    if (highestValue <= snowballValue)
                    {
                        highestValue = snowballValue;
                        bestSnowballSnow = snowballSnow;
                        bestSnowballTime = snowballTime;
                        bestSnowballQuality = snowballQuality;
                    }
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {highestValue} ({bestSnowballQuality})");
        }
    }
}
