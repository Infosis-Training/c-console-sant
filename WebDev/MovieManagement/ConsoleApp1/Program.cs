//To play with images
using System.Drawing;

// Parallel Programming --> distribute the function pressure/process to all available Core of physical cpu for quicker output
//threading:Thread
//TPL: Task parallel library, task 
using System.Diagnostics;

int[] numbers = { 2, 3, 4, 6, 7, 8, 9, 12, 34, 56 };
void compute(int n)
{
    //take some time
    Thread.Sleep(1000);
}

Stopwatch sp = new();
sp.Start();

foreach(var n in numbers)
{
    compute(n);
    Console.WriteLine(n);
}

Console.WriteLine(sp);

sp.Restart();

Parallel.ForEach(numbers, n =>
{
    compute(n);
    Console.WriteLine(n);
});

Console.WriteLine(sp);

//Asynchronous programing: async, await
//HttpClient client = new HttpClient();
//var googleContenet = await client.GetStringAsync("www.google.com");
//var bingContenet = await client.GetStringAsync("www.hotmail.com");

