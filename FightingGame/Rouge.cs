using System;



public class Rouge : Fighter
{
    public Rouge()
    {
        ClassName = "Rouge";
        hp = 80;
        MaxHp = 80;
        Str = 8;
        Dodge = 0.3;
        Def = 0.1;
        CritChance = 0.25;
        CritDmg = 2;
        HealMult = 2;
        weapon.name = "knife";
    }
    
}
