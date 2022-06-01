using System;

namespace Pattern;
class Patterns
{

    internal void hash()
    {

        int i;
        int j;

        Console.WriteLine("\nPattern 1 Start --------------------------->");

        for (i = 1; i < 7; i++)
        {
            for (j = 1; j < i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPattern 2 Start --------------------------->");

        for (i = 1; i < 8; i++)
        {
            for (j = 1; j < i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPattern 3 Start --------------------------->");

        for (i = 0; i < 9; i++)
        {

            for (j = i; j < 9; j++)
            {
                Console.Write(" ");
            }

            for (j = 0; j < i; j++)
            {
                Console.Write("# ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nPattern 4 Start --------------------------->");

        for (i = 0; i < 11; i+=2)
        {

            for (j = i; j < 11; j++)
            {
                Console.Write(" ");
            }

            for (j = 0; j < i+1; j++)
            {
                Console.Write("# ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}