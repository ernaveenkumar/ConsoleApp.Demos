// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Different Datatypes
/*
 * text - String
 * integers - Int
 * decimal - double, float, decimal
 * logical - bool
 */

String name = "Naveen Kumar";
Console.WriteLine("I am "+ name);// String concatenation
Console.WriteLine($"I am {name}");// String interpolation

int age = 90;
Console.WriteLine(age);
int retirementAgeLeft = 11;
int retirementAge = age + retirementAgeLeft; 
Console.WriteLine($" Retirement age is { age + retirementAgeLeft}");

bool isRetired = false;
Console.WriteLine($"Am i retired? {isRetired}");