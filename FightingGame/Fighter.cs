using System;


public class Fighter
{
    
    public string name;
    public int hp = 100;
    public Weapon weapon;
    public void Hit(Fighter target)
    {
        int damage = weapon.GetDamage();
        target.hp -= damage;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"{name} did {damage} damag to {target.name}.");
    }
}
