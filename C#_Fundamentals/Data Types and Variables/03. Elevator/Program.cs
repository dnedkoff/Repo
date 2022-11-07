using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;
            while (persons > 0)
            {
                if (capacity <= persons)
                {
                    ++courses;
                    persons -= capacity;
                }
                else
                {
                    ++courses;
                    persons = 0;
                }
            }
            Console.WriteLine(courses);
        }
    }
}
