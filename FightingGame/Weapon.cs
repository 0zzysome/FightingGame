using System;

public class Weapon
{
    
    public string name = "none";
    public int HitChance;
    private Random Generator;
    public Weapon()
    {
        Generator = new Random();

    }
    // ser om slaget träffar (inte klar)
    public bool DoesHit(double HitChance)
    {
        double roll = Generator.NextDouble();
        if(roll >= HitChance)
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
        return Generator.Next(5, 20);
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

