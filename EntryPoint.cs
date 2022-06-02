﻿using System;
using Oop;
using Basic;
using Assignment;
//Oop namespace has been defined in ClassAndMembers.cs and Inheritance.cs
//same Namespace can be used if we want to group two classes in single one so we can use at once in other classes

class Landing
{

    //Void Main is entry point for c#, application use this to run for first time. And this can be only used once in whole project.
    public static void Main()
    {
        //Creating Objects/Instance
        //Accessing Instance members
        // Person user = new();
        
        // user.name = "Sant";
        // user.heightInFt = 5.5f;
        // user.weightInKg = 50;
        // user.age = 16;
        // user.gender = "Male";
        // Person.institute = "Braodway Infosis"; //Institue is static feild in Person Class

        // string details = user.GetFullDetails();
        // Console.WriteLine(details);

        // BasicContsructs test = new();

        // Collections coll = new();
        // coll.LearnArray();

        // BasicContsructs basic = new();
        // LearnConditionals(40,50);
        // LearnSwitch();
        // LearnLoops();
        // basic.LearnLoops();

        // Methods m = new();
        // m.Print();
        // m.Print("Sant");
        //assign to vairable if method return any values instead of consolewrite
        // Console.WriteLine(m.Print("Sant",20));
        // Console.WriteLine(m.Greet("Gita","Mrs"));
        // Console.WriteLine(m.GreetTwo("Harry","Dr"));
        // m.OddEven(4);
        // m.IsEven(7);
        
        Assignments homework = new();
        // homework.Patterns();

        Console.WriteLine(homework.MaxNumber(95,2,53));
        Console.WriteLine(homework.Floatings(2,5));
        Console.WriteLine(homework.Initials("Sant","Bohara"));
        homework.InitialsSplit("Sant Bohara");
    }

}