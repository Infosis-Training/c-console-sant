using System;
using System.Collections.Generic;

namespace Collect; //Create a new Namespace so we can use in EntryPoint

class Collections
{
    internal void LearnArray()
    {

        //Single Dimension Array ------------>

        //style 1
        byte[] age = new byte[20];
        age[0] = 10;
        age[1] = 15;
        age[2] = 12;

        //Another style
        float[] numbers = { 10, 25, 60, 75, 90 };

        //Multidimenson Array ----------------------->

        //Style 1 for 2D
        decimal[,] box = new decimal[3, 4]; //2D array with 3 row and 4 column. "," segerate about 2D or 3D array etc...
        box[0, 0] = 35;  //Assigning value to 1st palce on 1st row

        //Another style of 2D
        double[,] table = { { 1, 2 }, { 2, 3 } };

        //Jaged Array
        string[][] SemName = new string[3][];  //Array with 3 row but undefined col

        //define col seperatly, which can have different size
        string[] firstName = { "Hari", "Ram" };
        string[] secondName = { "Bishnu", "Laxman", "Shiva", "Sant" };
        string[] thirdName = { "Rita", "Sita", "Gita" };

        //Assign col value to row 
        SemName[0] = firstName;
        SemName[1] = secondName;
        SemName[2] = thirdName;

        //Get values back from 2nd row 4th col 
        Console.WriteLine(SemName[1][3]);
    }

    internal void LearnBuiltInCollections(){

        //List
        List<int> numbers = new();
        numbers.Add(12);
        numbers.Add(15);
        numbers.Add(16);
        numbers.Remove(16);

        //Stack
        Stack<string> stack = new();
        stack.Push("Sa");
        stack.Push("nt");
        stack.Push("osh");
        stack.Pop(); //pop remove the last entry of stack / LIFO

        //Queue
        Queue<float> queue = new();
        queue.Enqueue(45);
        queue.Enqueue(50);
        queue.Enqueue(10);
        queue.Dequeue(); //remove first value of queue

        // Dictionary ------------------------>
        // add some key and its value for any further use.
        Dictionary<string, int> data = new();

        try{
            data.Add("A",1);
            data.Add("A",11);  //Duplicate key is not allowed, this will throw error while build
            data.Add("B",11);
            data.Add("C",11);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }

        Dictionary<string, int> data2 = new(){
            ["D"] = 1,
            ["E"] = 2,
            ["F"] = 2
        };

        foreach (var item in data2)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }
}

