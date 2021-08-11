using System;

System.Console.WriteLine("Enter your name!");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name},what is your last name?");
string name2 = Console.ReadLine();
Console.WriteLine("The last question, were you born?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{name2} {name} to you now {DateTime.Now.Year - age} year");