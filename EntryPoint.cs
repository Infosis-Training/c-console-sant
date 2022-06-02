using Oop;
using Basic;
using Pattern;
//Oop namespace has been defined in ClassAndMembers.cs and Inheritance.cs
//same Namespace can be used if we want to group two classes in single one so we can use at once in other classes

class Landing
{

    //Void Main is entry point for c#, application use this to run for first time. And this can be only used once in whole project.
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

        Patterns pattern = new();
        pattern.hash();
    }

}