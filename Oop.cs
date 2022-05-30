//Object oriented programing concept


//1. Classes and Objects

class Person
{
    //Member: as a Feilds
    public static string institute; //Static feild which is common to all object within this class.

    public byte age;
    public string name;
    public float heightInFt;
    public byte weightInKg;
    internal string gender; //internal is accessed within this project only

    //Member : as a method
    public void GetPersonDetails(){
        Console.WriteLine($"\nName: {name}.");
        Console.WriteLine($"Height: {heightInFt} feet.");
        Console.WriteLine($"Weight: {weightInKg} Kg.");
        Console.WriteLine($"Gender: {gender}.");
        Console.WriteLine($"Age: {age} year.\n");
        Console.WriteLine($"Learning in Institute: {institute}.\n.");
    }

    public string GetFullDetails(){
        string details = $"\n My name is {name}. \n my height is {heightInFt}. \n my weight is {weightInKg}. \n Learning in Institute: {institute}.\n.";
        return details;
    }
}