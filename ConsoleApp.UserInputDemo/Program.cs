﻿// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");

string firstName = string.Empty;
string lastName = string.Empty;

int age = 0;
int retirementAge = 65;
Console.WriteLine("Please enter your name");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());   

int workingYearsLeft = retirementAge - age;

Console.WriteLine($"Full name {name}");
Console.WriteLine($"Current age {age}");
Console.WriteLine($"Retirement years left {workingYearsLeft}");

