using System;

namespace _10._Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int halfPower = pokePower * 50 / 100;
            int pokeCounter = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCounter++;

                if (pokePower == halfPower && exhaustionFactor != 00)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);
        }
    }
}
