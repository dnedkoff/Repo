global using global::System;
global using global::System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] fields = new int[fieldSize];


            int[] initialIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] >= 0 && initialIndexes[i] < fields.Length)
                {
                    fields[initialIndexes[i]] = 1;  
                }
            }
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandToArray = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int ladyBugIndex = int.Parse(commandToArray[0]);
                string direction = commandToArray[1];
                int flyLength = int.Parse(commandToArray[2]);

                if (ladyBugIndex >= 0 && ladyBugIndex < fields.Length && fields[ladyBugIndex] == 1)
                {
                    fields[ladyBugIndex] = 0;

                    if (direction == "left")
                    {
                        flyLength = -flyLength;
                    }
                    while (true)
                    {
                        if (ladyBugIndex + flyLength >= fields.Length || ladyBugIndex + flyLength < 0)
                        {
                            break;
                        }

                        if (fields[ladyBugIndex + flyLength] == 0)
                        {
                            fields[ladyBugIndex + flyLength] = 1;
                            break;
                        }

                        flyLength += flyLength;
                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(String.Join(' ', fields));
        }
    }
}


