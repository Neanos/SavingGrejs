Goose g = new();

Console.WriteLine("Write your goose's name.");
g.Name = Console.ReadLine();
Console.WriteLine($"Your goose's name is now {g.Name}");

Console.WriteLine("Write your goose's age.");
string tal = Console.ReadLine();
bool lyckad = int.TryParse(tal, out g.Age);
Console.WriteLine($"Your goose's age is now {g.Age}");



Console.ReadLine();
