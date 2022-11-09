using System;

namespace Data_Types_and_Variables___More
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string dataType; 

            while (input != "END")
            {
                if (Int32.TryParse(input, out _))
                {
                    dataType = "integer";
                }
                else if (double.TryParse(input, out _))
                {
                    dataType = "floating point";
                }
                else if (bool.TryParse(input, out _))
                {
                    dataType = "boolean";
                }
                else if (char.TryParse(input, out _))
                {
                    dataType = "character";
                }
                else // since you cannot parse to string ... if the previous statements came up false -> IT's STRING Type.
                {
                    dataType = "string";
                    
                }
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();

            }
        }
    }
}
