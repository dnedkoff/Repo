using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            for (int i = 0; i < integer; i++)
            {
                for (int j = 0; j < integer; j++)
                {
                    for (int k = 0; k < integer; k++)
                    {
                        Console.Write(Convert.ToChar(97+i));
                        Console.Write(Convert.ToChar(97+j));
                        Console.Write(Convert.ToChar(97+k));
                        Console.WriteLine();
                    }
                }

            }
            
        }
    }
}
