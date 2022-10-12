using System;



public class Rouge : Fighter
{
    public Rouge()
    {
        ClassName = "Rouge";
        Hp = 80;
        MaxHp = 80;
        Str = 8;
        Def = 0.1;
        Dodge = 0.3;
        CritChance = 0.25;
        CritDmg = 2.5;
        HealMult = 2;
        weapon.name = "knife";
        HasHealed = false;
    }
    
}
