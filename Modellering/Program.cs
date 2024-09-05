Random r = new Random();
string scene = "game";


Hero hero = new Hero() {
Name = "Hero",
Hitpoints = 100,
};

Villain evil = new Villain() {
Name = "Nemesis",
Hitpoints = 70,
};



while (scene == "game")
{
Console.WriteLine($"{hero.Name} has {hero.Hitpoints} hp");
Console.WriteLine($"{evil.Name} has {evil.Hitpoints} hp");
Console.WriteLine("Pesss 'Q' to Attack.");
string action = "fight";

// do
// {
//     while(! Console.KeyAvailable) {

//     }
// } while (Console.ReadKey(true).Key != ConsoleKey.Q);

while (action == "fight"){
if (Console.ReadKey(true).Key == ConsoleKey.Q)
{
    // hero.Speed = r.Next(5, 8);
    // evil.Speed = r.Next(4, 7);
    hero.Attack = r.Next(10, 20);
    evil.Attack = r.Next(10, 15);
if (hero.Speed >= evil.Speed)
{


     //work in progress micke bry dig ej!
    evil.Hitpoints = evil.Hitpoints - hero.Attack;
    Console.WriteLine($"The Hero has moved first and struck the enemy for {hero.Attack}");
    Console.WriteLine($"Nemesis now has {evil.Hitpoints} HP");
    Console.WriteLine("...[enter]");
    if (Console.ReadKey(true).Key != ConsoleKey.Enter)
    {
        Console.WriteLine("Press enter to continue");
    }
}
}
if (evil.Hitpoints <= 0)
{
    action = "won";
}
if (hero.Hitpoints <= 0)
{
    action = "lost";
}
}

if (action == "won")
{
    Console.WriteLine("yippie hes dead! muderer!");
}





Console.WriteLine(hero.Name);
Console.WriteLine(hero.Speed);
Console.ReadLine();
}


