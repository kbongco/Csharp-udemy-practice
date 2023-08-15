// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input of first number");
var num1 = Console.ReadLine();
int num1Int = int.Parse(num1);
Console.WriteLine("Input of second number");
var num2 = Console.ReadLine();
int num2Int = int.Parse(num2);
Console.WriteLine("Choose what operation you want to do");
Console.WriteLine("[A] for addition");
Console.WriteLine("[S] for subtraction");
Console.WriteLine("[M] for multiplication");
var selectedChoice = Console.ReadLine();
Console.WriteLine(selectedChoice);
if(selectedChoice == "a" || selectedChoice == "A")
{
    var sum = num1Int + num2Int;
    Console.WriteLine($"The sum of {num1Int} + {num2Int} = {sum}");
}
else if(selectedChoice == "S" || selectedChoice == "s")
{
    var diff = num1Int - num2Int;
    Console.WriteLine($"The difference of {num1Int} - {num2Int} = {diff}");
}
else if(selectedChoice == "M" || selectedChoice == "m")
{
    var product = num1Int * num2Int;
    Console.WriteLine($"The product of {num1Int} * {num2Int} = {product}");
} else
{
    Console.WriteLine("Not a valid option");
}

Console.ReadKey();
