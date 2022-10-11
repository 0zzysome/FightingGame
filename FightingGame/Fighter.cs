using System;


public class Fighter
{
    
    public string ClassName {get; set;}
    public string name {get; set;}
    public double MaxHp{get; set;}
    public double Hp
    {
        get => Hp;
        set => Math.Max(value, 0);
    }
    public int Str{get; set;}
    public double Dodge{get; set;}
    public double Def{get; set;}
    public double CritChance{get; set;}
    public double CritDmg{get; set;}
    public double HealMult{get; set;}
    public bool HasHealed {get; set;}
    public Weapon weapon = new Weapon();
    
    public static Fighter MakeCharacter()
    {
        bool MadeChar = false;
        int Choice = 0;
        //spelaren väljer namn på karatär
        Console.WriteLine("Choose a name for your fighter.");
        string name = Console.ReadLine();
        // ser om skapandet av karaktären gick igenom
        while (MadeChar == false)
        {
            Console.Clear();
            // spelaren väljer klass
            Console.WriteLine("Choose a class for your fighter.");
            Console.WriteLine("1. Rouge");
            Console.WriteLine("2. Soldier");
            Console.WriteLine("3. Class info");

            MadeChar = int.TryParse(Console.ReadLine(), out Choice);
            // Ändrar på alla variabler så de matchar klassen
            Fighter f = new Fighter();
            switch (Choice)
            {
                case 1:

                    f  = new Rouge();
                    f.name = name;
                    return f;

                 case 2:

                    f = new Soldier();
                    f.name = name;
                    break;
                 case 3:
                     ClassInfo();
                     MadeChar = false;
                     break;
                 default:
                     MadeChar = false;
                     break;

            }
        }
        return null;
    }


    public Fighter()
    {




    }
    //healing
    public void Heal()
    {
        if (HasHealed == false)
        {
            Hp = Hp + (10 * HealMult);
            Hp = Math.Min(MaxHp, Hp);
            HasHealed = true;

        }


    }
    public void Hit(Fighter target)
    {
        
        
        if(weapon.DoesHit(target.Dodge))
        {
            
        
        
            // formel för att reducera skada
            // dmg = dmg * (1-defence) 
            double damage = weapon.GetDamage();
            // tittar om atacken är en crit
            if (weapon.DoesCrit(CritChance))
            {
                Console.WriteLine("Critical Hit!");
                damage = damage * Str * (1 - Def) * CritDmg;
            }
            else
            {
                damage = damage * Str * (1 - Def);
            }

            target.Hp -= damage;
        
            Console.WriteLine($"{name} hit {target.name} and did {damage} damage.");
        }
        else
        {
            
        }
    }

    static void ClassInfo()
{   
    bool IsDone = false; 
    int Choice = 0;
    while(IsDone==false)
    {
        Console.Clear();
        Console.WriteLine("What class do you whant info about.");
        Console.WriteLine("1. Rouge");
        Console.WriteLine("2. Soldier");
        //läser in vad splarens skriver in 
        IsDone =int.TryParse(Console.ReadLine(), out Choice);
        //Isdone = true
        switch(Choice)
        {
            case 1:
                Console.WriteLine("Class: Rouge");
                Console.WriteLine("Max HP: 80");
                Console.WriteLine("Strength : 8");
                Console.WriteLine("Defence: 10%");
                Console.WriteLine("Dodge Chance: 30%");
                Console.WriteLine("Crit chance: 25%");
                Console.WriteLine("Crit damage multiplier: ");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                
                break;
            case 2:
                Console.WriteLine("Class: soldier");
                Console.WriteLine("Max HP: 110");
                Console.WriteLine("Strength : 10");
                Console.WriteLine("Defence: 30%");
                Console.WriteLine("Dodge Chance: 10%");
                Console.WriteLine("Crit chance: 5%");
                Console.WriteLine("Crit damage multiplier: ");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                
                break;
            default:
                IsDone = false;

                break;
        }
        
    }
        

}


}
