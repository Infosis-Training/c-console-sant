using System;
using System.Linq;

namespace Assignment;
class Assignments{
    
    //Start Assignment 1  : Loop (2022.06.01) ----------------->
    internal void Patterns()
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

        for (i = 0; i < 10; i+=2)
        {

            for (j = i; j < 10; j++)
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

        
        Console.WriteLine("\nPattern 5 Start --------------------------->");

        //using 2d array
        string[,] box = new string[5,5];

    }
    
    /*#########################################################*/

    //Start Assignment 2 : Method (2022.06.02) ---------------->
    public int MaxNumber(int one, int two, int three){
        
        int[] num = {one, two, three};

        return num.Max(); 
    }

    public string Floatings(float arg, float arg2) => $"{arg*arg2}";
    
    public string Floatings(float arg, float arg2, float arg3) => $"{arg*arg2*arg3}";

    public string Initials(string firstName, string secondName) => $"{firstName[0]}{secondName[0]}";
    
    public void InitialsSplit(string name) {
        
        string[] splits = name.Split();

        foreach(string split in splits){
            Console.Write(split[0]);
        }
    }

}