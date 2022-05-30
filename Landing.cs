using System.Runtime.CompilerServices;
class Landing
{
    public static void Main()
    {
        //Creating Objects/Instance
        //Accessing Instance members
        Person user = new();
        
        user.name = "Sant";
        user.heightInFt = 5.5f;
        user.weightInKg = 50;
        user.age = 16;
        user.gender = "Male";

        Person.institute = "Braodway Infosis"; //Institue is static feild in Person Class

        string details = user.GetFullDetails();

        Console.WriteLine(details);
    }

}