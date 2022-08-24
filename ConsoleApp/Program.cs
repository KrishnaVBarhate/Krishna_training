// See https://aka.ms/new-console-template for more information
using MathsLib;

Console.WriteLine("Hello, World!");
int a = 0;
int b = 0;
int c=0;

Console.WriteLine("Enter 1st number");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2nd number");
b = int.Parse(Console.ReadLine());
Basic basic = new Basic();
c = basic.Add(a, b);
Console.WriteLine(c);