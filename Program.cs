/*
    Content from the book:
    Programming C# 8.0
    Build Cloud, Web, and Desktop Applications
    Ian Griffiths
    O'Reilly 2020
    AND Microsoft Docs
*/

using Types;

Console.WriteLine();

var myClass = new FirstClass();
int result = myClass.GetNextValue();
Console.WriteLine($"Next value: {result}");
myClass.PrintPhrase();
