using System.Text.Json;
using System.IO;

Goose g = new();

Console.WriteLine("Write your goose's name.");
g.Name = Console.ReadLine();
Console.WriteLine($"Your goose's name is now {g.Name}");

Console.WriteLine($"Write {g.Name}'s age.");
string tal = Console.ReadLine();
int temp;
bool lyckad = int.TryParse(tal, out temp);
g.Age = temp;
Console.WriteLine($"{g.Name}'s age is now {g.Age}");

Console.WriteLine($"Write {g.Name}'s favourit food.");
g.Food = Console.ReadLine();
Console.WriteLine($"{g.Name}'s favourit is now {g.Food}");

string json = JsonSerializer.Serialize<Goose>(g);
File.WriteAllText("save.json", json);

Console.ReadLine();
