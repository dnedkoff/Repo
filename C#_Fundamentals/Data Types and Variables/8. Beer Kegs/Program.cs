using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());

            string biggestKeg = "";
            double biggestVolume = double.MinValue;
            for (int i = 0; i < kegsCount; i++)
            {
               
                    string model = Console.ReadLine();
                    double radius = double.Parse(Console.ReadLine());
                    int height = int.Parse(Console.ReadLine());
                    double volume = Math.PI * Math.Pow(radius,2) * height;
                    if (volume > biggestVolume)
                    {
                        biggestVolume = volume;
                        biggestKeg = model;
                    }
                
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
