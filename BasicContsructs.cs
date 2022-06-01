using System;
using Collect;

namespace Basic;  //Creating new namespace

class BasicContsructs
{
    static void LearnConditionals(byte x, byte y)
    {

        if(x < y){
            Console.Write($"{x} is less than {y}");
        }
        else if(x == y){
            Console.Write($"{x} is equals to {y}");
        }
        else{
            Console.Write($"{x} is less than {y}");
        }
    }

    static void LearnSwitch()
    {
        
        string name = "ram";

        switch(name){

            case "ram":
                Console.WriteLine(name);
            break;

            case "sant":
                Console.WriteLine(name);
            break;  

            default:
                Console.WriteLine(name);
            break;
        }
    }

    internal void LearnLoops()
    {
        // for(byte i = 1; i < 10; i++){

        //     // Console.WriteLine($"{i} .Net Training");   
        // }

        // byte j = 1;
        // while(j < 4)
        // {
        //     // Console.WriteLine($"{j} .Net Training");
        //     // j++;
        // }

        string[] names = {"Abc", "def", "ghi","jkl"};

        foreach(string test in names){
            
            Console.WriteLine(test);
        }
    }
}