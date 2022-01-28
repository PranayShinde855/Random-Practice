using System;

namespace Discard
{
    class Program
    {
        //Discards are special, write-only variables which are used to trash the values that are not interesting to the programmer.The _ (underscore character) is used for a discard.
        static void Main(string[] args)
        {
            var values = ( 1, 2, 3, 4, 5 );

            (int x, int y, _, _, int z) = values;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
