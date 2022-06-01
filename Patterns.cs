using System;

namespace Pattern;
class Patterns{

    internal void hash(){

        int i;
        int j;

        Console.WriteLine("\nPattern 1 Start --------------------------->");

        for(i = 1; i < 7; i++){
            for(j = 1; j < i; j++){
                Console.Write("#");
            }
            Console.Write("\n");
        }

        Console.WriteLine("\nPattern 2 Start --------------------------->");

        for(i = 1; i < 8; i++){
            for(j = 1; j < i; j++){
                Console.Write(j);
            }
            Console.Write("\n");
        }

        Console.WriteLine("\nPattern 3 Start --------------------------->");

        int space = 8;
        int MAX = space;

        for (i = 1; i < MAX; i++)
        {

            for (j = 1; j < space; j++)
            {
                Console.Write(" ");
            }

            for (j = 1; j < i; j++)
            {
                Console.Write(" #");
            }

            Console.Write("\n");
            space--;   
        }

        Console.WriteLine();

    }
}