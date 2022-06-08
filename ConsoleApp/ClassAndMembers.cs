using System;
namespace Oop;

//1. Classes and Objects


//Note: 'abstract' class can be inheritance but cant be defined as method in another classes.

class Person
{
    //Member: as a Feilds
    public static string institute = null; //Static feild which is common to all object within this class.
    public byte age = 0;
    public string name = null;
    public float heightInFt = 0;
    public byte weightInKg = 0;
    internal string gender = null; //internal is accessed within this project only
    protected string salary = null; //Inheritance class cant access this but this can be used within this own calls 

    //Member : as a method
    public void GetPersonDetails()
    {
        Console.WriteLine($"\nName: {name}.");
        Console.WriteLine($"Height: {heightInFt} feet.");
        Console.WriteLine($"Weight: {weightInKg} Kg.");
        Console.WriteLine($"Gender: {gender}.");
        Console.WriteLine($"Age: {age} year.\n");
        Console.WriteLine($"Learning in Institute: {institute}.\n.");
    }

    public string GetFullDetails()
    {
        string details = $"\n My name is {name}. \n my height is {heightInFt}. \n my weight is {weightInKg}. \n Learning in Institute: {institute}.\n.";
        return details;
    }
}
