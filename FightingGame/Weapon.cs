using System;

public class Weapon
{
    public string name;
    private Random Generator;
    public Weapon()
    {
        Generator = new Random();
        



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

