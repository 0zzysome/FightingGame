using System;

public class Weapon
{
    
    public string name {get; set;}
    
    private Random Generator;
    public Weapon()
    {
        Generator = new Random();
        
    }
    // ser om slaget träffar (inte klar)
    public bool DoesHit(double DodgeChance)
    {
        double roll = Generator.NextDouble();
        if(roll >= DodgeChance)
        {
            return true;
        }
        else
        {
            return false;   
        }
    }

    // genererad skadan
    public int GetDamage()
    {
        return Generator.Next(5, 10);
    }
    // kalkulation för när slaget är en crit
    public bool DoesCrit(double CritChance)
    {
        double roll = Generator.NextDouble();
        if(roll <= CritChance)
        {
            return true;
        }
        else
        {
            return false;   
        }
    }
}

