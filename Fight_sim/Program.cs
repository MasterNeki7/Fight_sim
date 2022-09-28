string name;

string name2;

Console.WriteLine("welcome fighter. What is your name (you can't say cum)");
name = Console.ReadLine();

if (name == "cum")
{
 Console.WriteLine("No! you can't have that");
}

else
{
    Console.WriteLine($"Welcome {name}");
    Console.WriteLine("What is your opponents name? (You can't say cum)");
    name2 = Console.ReadLine();
    
    if (name2 == "hitler")
    {
        Console.WriteLine("You are stupid and stop please");
    }
}

Console.ReadLine();
