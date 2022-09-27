using System;

public class Weapon
{
    public string name;
    private Random Generator;
    public Weapon()
    {
        Generator = new Random();
    }

    public int GetDamage()
    {
        return Generator.Next(5, 20);
    }
}
