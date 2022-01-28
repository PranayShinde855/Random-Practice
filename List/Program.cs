using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        //List :  A List is a sequence of elements, which can be accessed by indexing operation with[]. Elements of a list can be traversed with e.g.a foreach keyword.
        static void Main(string[] args)
        {
            var list1 = new List<String> { "hey", "Pranay","Shinde" };
            Console.WriteLine(list1[2]);
        }
    }
}
