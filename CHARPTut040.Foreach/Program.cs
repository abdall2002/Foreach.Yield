// See https://aka.ms/new-console-template for more information

var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("\n \n Using For: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($" {numbers[i]}");
}

Console.WriteLine("\n\n Using Foreach");

foreach (var n in numbers)
{
    Console.Write($" {n}");
}
