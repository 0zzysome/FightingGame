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
    public Weapon weapon;
    
    public Fighter()
    {
        
        


    }
    //healing
    public void Heal()
    {
        if(HasHealed==false)
        {   
            hp = hp+(10*HealMult);
            hp = Math.Min(MaxHp, hp);
            HasHealed = true;
            
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
