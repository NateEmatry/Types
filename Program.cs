/*
    Content from the book:
    Programming C# 8.0
    Build Cloud, Web, and Desktop Applications
    Ian Griffiths
    O'Reilly 2020
    AND Microsoft Docs
*/

using Types;

// Using statement for a static class.
// Lets you invoke methods without the class name (explicit qualification)
using static Types.DumbMath;


Console.WriteLine();

var myClass = new FirstClass();
int result = myClass.GetNextValue();
Console.WriteLine($"Next value: {result}");
myClass.PrintPhrase();


// Don't need the DumbMath class name here because of our above using statement
int value = 6;
Console.WriteLine($"{value} times 2 is {TimesTwo(value)}");

var myGreen = new ColorRGB(50, 200, 50);

Console.WriteLine($"My green in hex: {myGreen}");


int q = 12, d = 5, r;
Console.WriteLine($"\n\nUsing an out parameter: ");
Console.WriteLine($"{q} / {d} = {MethodsDemo.Divide(q, d, out r)}, remainder = {r}");

// Putting the out parameter's result into a new variable
int q2 = MethodsDemo.Divide(20, 7, out int r2);
Console.WriteLine($"20 divided by 7 is {q2} mod {r2}");