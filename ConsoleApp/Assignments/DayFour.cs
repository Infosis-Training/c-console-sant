
using System;
using System.Collections.Generic;
using System.Linq;

public class DayFour
{
    public void ListFilter(){

        List<float> bills = new() {23.5f, 56.2f, 45.1f, 90.34f, 12.23f, 78.65f};

        //Select all bills higher or equal to 50$
        var higherEq50 = bills.Where(x => x >= 50);

        //Round all bills to nereast integer
        var roundAmount = bills.Select(x => Math.Round(x));

        PrintCollection<float>(higherEq50);
        PrintCollection<double>(roundAmount);
    }

    void PrintCollection<T>(IEnumerable<T> items){

        foreach(var item in items){
            Console.Write(item);
        }

        Console.WriteLine();
    }
}
