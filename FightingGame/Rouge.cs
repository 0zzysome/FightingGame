using System;



public class Rouge : Fighter
{
    public Rouge()
    {
        ClassName = "Rouge";
        Hp = 80;
        MaxHp = 80;
        Str = 7;
        Def = 0.1;
        Dodge = 0.2;
        CritChance = 0.25;
        CritDmg = 2;
        HealMult = 2;
        weapon.name = "knife";
        HasHealed = false;
    }
    
}
