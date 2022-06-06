using System;
using System.Linq;

class Linq{
    int[] number = {2,5,6,8,9,10,11,12,13,14,15,16,20};

    public void LearnInq(){

        //Get oddNumbers
        var oddNumbers = number.Where(n => n % 2 == 0);

        //Get all multiples of 4
        var multiplesof4 = number.Where(n => n % 4 == 0);

        // Get squares of all elements
        var squares = number.Select(x => x * x);

        // Get quares of all odd numbers
        var oddSquares = number.Where(n => n % 2 ==0).Select(n => n*n);

        foreach(var item in oddSquares){
            Console.WriteLine(item);
        }
    }
}