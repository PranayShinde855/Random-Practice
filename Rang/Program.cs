using System;
using System.Linq;

namespace Rang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var start =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End");
            var end = Convert.ToInt32(Console.ReadLine());
            foreach(var i in Enumerable.Range(start,end))
            {
                Console.WriteLine(i);
            }
        }
    }
}
