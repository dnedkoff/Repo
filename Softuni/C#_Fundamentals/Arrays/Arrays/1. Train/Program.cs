namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            /*
             * A train has n number of wagons (integer, received as input). 
             * On the next n lines, you will receive the number of people that are going to 
             * get on each wagon. Print out the number of passengers in each wagon followed
             * by the total number of passengers on the train.
             */

            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peopleInWagon = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                int peopleInCurrentWagon = int.Parse(Console.ReadLine());
                sum += peopleInCurrentWagon;
                peopleInWagon[i] = peopleInCurrentWagon;
            }
            Console.WriteLine(string.Join(' ', peopleInWagon));
            Console.WriteLine(sum);

        }
    }
}