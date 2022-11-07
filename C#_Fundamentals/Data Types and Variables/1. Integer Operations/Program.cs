using System;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int sum = 0;

            sum = number1 + number2;
            sum /= number3;
            sum *= number4;

            Console.WriteLine(sum);
        }
    }
}
