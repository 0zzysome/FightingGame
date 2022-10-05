using System;



public class Soldier: Fighter
{
    public Soldier()
    {
        ClassName = "Soldier";
        hp = 110;
        MaxHp = 110;
        Str = 10;
        Dodge = 0.1;
        Def = 0.3;
        CritChance = 0.05;
        CritDmg = 2;
        HealMult = 2;
        weapon.name = "Sword";
    }
    
}
