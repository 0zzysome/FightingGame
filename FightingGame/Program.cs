// See https://aka.ms/new-console-template for more information

Fighter f1 = new Fighter();
Fighter f2 = new Fighter();
f1.name = "soldier";
f2.name = "bandit";
f1.weapon = new Weapon();
f2.weapon = new Weapon();
f1.weapon.name = "sword";
f2.weapon.name = "dagger";
Console.WriteLine("Hello, World!");



while(f1.hp > 0 && f2.hp > 0)
{
    Console.WriteLine($"Hello, World!");
    Console.WriteLine($"Hello, World!");
    f1.Hit(f2);
    f2.Hit(f1);


    Console.WriteLine("Tryck på enter för att fortsätta.");
    Console.ReadLine();

}
if(f1.hp == 0 && f2.hp == 0)
{
    Console.WriteLine("Oavgort!");
}
else if(f1.hp == 0)
{
    Console.WriteLine($"{f2.name} wins!"); 
}
else
{
    Console.WriteLine($"{f1.name} wins!"); 
}

Console.WriteLine("Tryck på enter för att fortsätta.");
Console.ReadLine();