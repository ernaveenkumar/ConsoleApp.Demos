// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");

string? firstName = string.Empty;
string? lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;


Console.WriteLine("Please enter your name");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please eneter your salary");
salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Please enter your gender");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you working ?! Please enter tru of false");
working = Convert.ToBoolean(Console.ReadLine());

int workingYearsLeft = retirementAge - age;

Console.WriteLine($"Full name {firstName} {lastName}");
Console.WriteLine($"Current age {age}");
Console.WriteLine($"Your salary is {salary}");
Console.WriteLine($"Your working status is {working}");
Console.WriteLine($" Your gender is {gender}");
Console.WriteLine($"Retirement years left {workingYearsLeft}");



