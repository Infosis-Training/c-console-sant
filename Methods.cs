using System;
using System.Linq;

class Methods
{
    //This is simplest possibile methond : Not return type, no parameters
    internal void Print(){
        Console.WriteLine("Hello there!");
    }

    //No retrun type, take arguments
    //2 class have save name which is called method overloading
    internal void Print(string name)
    {
        Console.WriteLine($"Hello! {name}");
    }

    //one return type, multiple arguments
    public string Print(string name, byte age){
        
        string details = $"Name: {name}, age : {age}";
        
        return details;
    }

    //one return type, multiple arguments with default/optinal value of arguments
    public string Greet(string name, string salutation = "Mr"){

        return $"Hello! {salutation}. {name}";
    }

    //Function expression: "goes to"
    //We can return in shorthand as below if return value is single line, below is same as above Greet method
    public string GreetTwo(string name, string salutation = "Mr") => $"Hello! {salutation}. {name}";

    //find odd or even
    public void OddEven(decimal num){
        
        decimal check = num / 2;
        
        switch(check){

            case 0:
                Console.WriteLine("Even");
            break;

            default:
                Console.WriteLine("Even");
            break;

        }
    }

    public bool IsEven(int num) => num % 2 == 0;

}