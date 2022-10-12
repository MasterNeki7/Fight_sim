

string nameOne;

string nameTwo;

int p1Hp = 10;

int p2Hp = 10;




Console.WriteLine("Welcome fighter. What is your name?");

nameOne = Console.ReadLine();

Console.WriteLine($"Welcome {nameOne}. What is your enemy called?");

nameTwo = Console.ReadLine();

Console.WriteLine($"Alright. {nameOne} is fighting {nameTwo}. BEGIN!");

Console.ReadLine();








while (p1Hp > 0 && p2Hp > 0)
{

    Console.Clear();
    Console.WriteLine($"{nameOne} har {p1Hp} HP");
    Console.WriteLine($"{nameTwo} har {p2Hp} HP");


    Random generator = new Random();

    int hitChance = generator.Next(1000);

    Console.ReadLine();

    if (hitChance > 50)

    {
        p2Hp -= 1;
        Console.WriteLine("P1 hits P2");

    }
    else
    {
        Console.WriteLine("P1 misses P2");

    }

    Console.ReadLine();

    hitChance = generator.Next(100);

    if (hitChance > 50)
    {
        p1Hp -= 1;
        Console.WriteLine("P2 hits P1");


    }
    else
    {
        Console.WriteLine("P2 misses");

    }
    Console.ReadLine();
}

if (p1Hp <= 0 && p2Hp <= 0)
{
    Console.WriteLine("BOTH LOST");
}

else if (p1Hp <= 0)
{
    Console.WriteLine($"{nameTwo} Won!");

}

else if (p2Hp <= 0)
{
    Console.WriteLine($"{nameOne} Won!");
}

Thread.Sleep(5000);
Console.ReadLine();
