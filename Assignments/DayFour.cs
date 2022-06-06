
using System;
using System.Collections.Generic;
using System.Linq;

public class DayFour
{
    public void ListFilter(){

        List<float> bills = new() {23.5f, 56.2f, 45.1f, 90.34f, 12.23f, 78.65f};

        var higherEq50 = bills.Where(x => x >= 50);

        // var roundAmount = bills.Select(x => x);

        foreach(var item in bills){
            Console.WriteLine(Convert.ToInt32(item));
        }
    }
}
