using System;


public class Fighter
{
    public int Class;
    public string ClassName = "no class";
    public string name;
    public double hp = 100;
    public int Str;
    public int Int;
    public double Def;
    public double CritChance;
    public double CritDmg;
    private bool MadeChoice = false;
    public Weapon weapon;

    public Fighter()
    {
        //spelaren väljer namn på karatär
        Console.WriteLine("Choose a name for your fighter."); 
        name = Console.ReadLine();
        while (MadeChoice==false)
        {
            // skriv ner alla klaser och stats
            // spelaren väljer klass
            Console.WriteLine("Choose a class your fighter."); 
            MadeChoice =int.TryParse(Console.ReadLine(), out Class);
            // Ändrar på alla variabler så de matchar klassen
            //
            switch(Class)
            {
                case 1:
                    ClassName = "Rouge";
                    Class = 1;
                    hp = 100;
                    Str = 10;
                    Int = 8;
                    Def = 0.1;
                    CritChance = 0.05;
                    CritDmg = 2;
                    break;
                case 2: 
                    ClassName = "fighter";
                    Class = 2;
                    hp = 100;
                    Str = 10;
                    Int = 8;
                    Def = 0.1;
                    CritChance = 0.05;
                    CritDmg = 2;
                    break;
                default:
                    MadeChoice = false;
                    break;

            }
        }
        

    }
    public void Hit(Fighter target)
    {
        // formel för att reducera skada
        // dmg = dmg * (1-defence) 
        double damage = weapon.GetDamage();
        // tittar om atacken är en crit
        if (weapon.DoesCrit(CritChance))
        {
             Console.WriteLine("Critical Hit");
             damage = damage*Str*(1-Def)*CritDmg;
        }
        else
        {
            damage = damage*Str*(1-Def);
        }

        target.hp -= damage;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"{name} did {damage} damage to {target.name}.");
    }
}
