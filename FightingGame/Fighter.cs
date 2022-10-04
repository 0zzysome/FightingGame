using System;


public class Fighter
{
    public int Class;
    public string ClassName = "no class";
    public string name;
    public double MaxHp;
    public double hp;
    public int Str;
    public double Dodge;
    public double Def;
    public double CritChance;
    public double CritDmg;
    public double HealMult;
    public bool HasHealed= false;
    private bool MadeChar = false;
    public Weapon weapon;

    public Fighter()
    {
        //spelaren väljer namn på karatär
        Console.WriteLine("Choose a name for your fighter."); 
        name = Console.ReadLine();
        // ser om skapandet av karaktären gick igenom
        while (MadeChar==false)
        {
            // skriv ner alla klaser och stats
            // spelaren väljer klass
            Console.WriteLine("Choose a class your fighter."); 
            MadeChar =int.TryParse(Console.ReadLine(), out Class);
            // Ändrar på alla variabler så de matchar klassen
            //
            switch(Class)
            {
                case 1:
                    // class = 1 från parse
                    ClassName = "Rouge";
                    hp = 80;
                    MaxHp = 80;
                    Str = 8;
                    Dodge = 0.3;
                    Def = 0.1;
                    CritChance = 0.25;
                    CritDmg = 2;
                    weapon.name = "knife";
                    break;
                case 2: 
                    // class = 2 från parse
                    ClassName = "fighter";
                    hp = 110;
                    MaxHp = 110;
                    Str = 10;
                    Dodge = 0.1;
                    Def = 0.3;
                    CritChance = 0.05;
                    CritDmg = 2;
                    break;
                default:
                    MadeChar = false;
                    break;

            }
        }
        


    }

    public void Action()
    {
        bool ChoseAction = false;
        while (ChoseAction==false)
        {
            Console.WriteLine($"What will {name} do?");
            Console.WriteLine($"1. attack with {weapon.name}.");
            Console.WriteLine("2. Dodge.");
            Console.WriteLine("3. Block.");
            if(HasHealed==false)
            {
                Console.WriteLine("4.Heal.");
            }
            else
            {
                Console.WriteLine($"4.{name} cant heal any more.");          
            }
            ChoseAction =int.TryParse(Console.ReadLine(), out Class);

        }
         
        
    }
    //healing
    public bool Heal()
    {
        if(HasHealed==false)
        {   
            hp = hp+(10*HealMult);
            hp = Math.Min(MaxHp, hp);
            HasHealed = true;
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public void Hit(Fighter target)
    {
        /*
        jobbar på senare
        if(weapon.DoesHit(target.Dodge))
        {
            
        }
        */
        // formel för att reducera skada
        // dmg = dmg * (1-defence) 
        double damage = weapon.GetDamage();
        // tittar om atacken är en crit
        if (weapon.DoesCrit(CritChance))
        {
             Console.WriteLine("Critical Hit!");
             damage = damage*Str*(1-Def)*CritDmg;
        }
        else
        {
            damage = damage*Str*(1-Def);
        }

        target.hp -= damage;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"{name} hit {target.name} and did {damage} damage.");
    }
}
