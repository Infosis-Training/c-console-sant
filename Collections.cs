using System;

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
}

