using System;

namespace Random_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
             DateTime now = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(now.ToString("dddd"));
                now = now.AddDays(1);
            };
        }
    }
}
