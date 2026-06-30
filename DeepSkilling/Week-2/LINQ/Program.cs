using System.Linq;


List<int> numbers = new List<int>()
{
    10,20,30,40,50
};


// Filtering using LINQ

var evenNumbers =
    numbers.Where(n => n % 20 == 0);



Console.WriteLine("Numbers divisible by 20:");

foreach(var num in evenNumbers)
{
    Console.WriteLine(num);
}



// Sorting

var sortedNumbers =
    numbers.OrderByDescending(n => n);



Console.WriteLine("Sorted numbers:");

foreach(var num in sortedNumbers)
{
    Console.WriteLine(num);
}