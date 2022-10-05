Random generator = new Random();

int hitChance = generator.Next(100);

string nameOne;

string nameTwo;

int p1Hp = 10;

int p2Hp = 10;




Console.WriteLine("Welcome fighter. What is your name?");

nameOne = Console.ReadLine();

Console.WriteLine($"Welcome {nameOne}. What is your enemy called?");

nameTwo = Console.ReadLine();

Console.WriteLine($"Alright. {nameOne} is fighting {nameTwo}. BEGIN!");

while (p1Hp > 0 || p2Hp > 0)
{
    
}





Console.ReadLine();
