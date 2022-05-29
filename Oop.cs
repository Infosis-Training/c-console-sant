//Object oriented programing concept


//1. Classes and Objects

class Person
{
    byte age;
    public string name;
    public float heightInFt;
    public byte weightInKg;
    public char gender;

    public void Speak()
    {
        name = "Sant";

        Console.WriteLine($"{name} is speaking...");
    }

    public void Walk()
    {
        Console.WriteLine(name+ " is walking...");
    }

    public void Eat()
    {
        Console.WriteLine(name + " is eating...");
    }
}