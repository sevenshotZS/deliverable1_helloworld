// See https://aka.ms/new-console-template for more information

Console.WriteLine("Solution (1): Hello, World!");

string stg = "Hello, World!";
Console.WriteLine("solution (2): " + stg);
Console.WriteLine(" ");

Console.WriteLine("Enter a user's name: ");
string userName = Console.ReadLine();
Console.WriteLine("The user's name is: " + userName);
Console.WriteLine(" ");

Console.WriteLine("Enter the user's age: ")
//int age = Convert.ToInt32(Console.Readline());
int age = int.Parse(Console.ReadLine());
Console.WriteLine("The user's age is: " + age)