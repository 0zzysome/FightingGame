// See https://aka.ms/new-console-template for more information



Fighter f1 = Fighter.MakeCharacter();



Fighter f2 = Fighter.MakeCharacter();





while(f1.Hp > 0 && f2.Hp > 0)
{
    int orderF1 = turn(f1, f2);
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();

    

    int orderF2 = turn(f2, f1);
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("COMBAT BEGINS");
    if(orderF1>orderF2)
    {
        combat(orderF1,f1,f2);
        combat(orderF2,f2,f1);
    }
    else
    {
        combat(orderF2,f2,f1);
        combat(orderF1,f1,f2);
    }
    PrintHp(f1);
    PrintHp(f2);
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
    ResetStats(orderF1, f1);
    ResetStats(orderF2, f2);

}
if(f1.Hp == 0 && f2.Hp == 0)
{
    Console.WriteLine("Tie!");
    Console.ReadLine();
}
else if(f1.Hp == 0)
{
    Console.WriteLine($"{f2.name} wins!"); 
    Console.ReadLine();
}
else
{
    Console.WriteLine($"{f1.name} wins!"); 
    Console.ReadLine();
}

Console.WriteLine("Press enter to continue.");
Console.ReadLine();

//Här så gör splaren ett val som skrivs ut  så det kan användas senare
int turn(Fighter Player, Fighter target)
    {
        bool ChoseAction = false;
        int ActionNumber = 0;
        while (ChoseAction==false)
        {
            Console.Clear();
            Console.WriteLine($"What will {Player.name} do?");
            Console.WriteLine($"1. attack with {Player.weapon.name}.");
            Console.WriteLine("2. Dodge.");
            Console.WriteLine("3. Block.");
            if(Player.HasHealed==false)
            {
                Console.WriteLine("4.Heal.");
            }
            else
            {
                Console.WriteLine($"4.{Player.name} cant heal any more.");          
            }
            ChoseAction = int.TryParse(Console.ReadLine(), out ActionNumber);
            // hanterar vad karaktären gör
            if(Player.HasHealed || ActionNumber<1 ||ActionNumber>4)
            {
                ChoseAction = false;
                Console.WriteLine("No choice was made, Press enter to go back and make a choice.");
                Console.ReadLine();
            }
        }
        return ActionNumber;
    }
//metod för vad som händer först så man kan blokera inan motstondaren slår.
void combat(int Event,Fighter Player,Fighter target )
{
    switch(Event)
    {
            case 1:
                Player.Hit(target);
                break;
            case 2:
                Player.Dodge =+ 0.3;
                Console.WriteLine($"{Player.name} tried to dodge");
                break;
            case 3:
                Player.Def =+ 0.3;
                Console.WriteLine($"{Player.name} whent to block the next attack");
                break;
            case 4:
                if(Player.HasHealed==false)
                {
                    Player.Heal();
                    Console.WriteLine($"{Player.name} Healed a total of {Player.HealMult*10} Hp.");
                }
                else
                {
                    Console.WriteLine($"4.{Player.name} cant heal any more.");               
                }
                break;
            default:
                Console.WriteLine($"ERROR: NO CHOICE WAS MADE");
                break;
    }        
}
// säter tilbaks alla variabler så att de inte stanar
void ResetStats(int Event,Fighter Player)
{
    if(Event==2)
    {
        Player.Dodge =- 0.3;
    }
    else if(Event==3)
    {
        Player.Def =- 0.3;
    }
    
}   
void PrintHp(Fighter Player)
{
    Console.WriteLine($"{Player.name} HP: {Player.Hp}/{Player.MaxHp}");
    Console.WriteLine($"{Player.Hp}/{Player.MaxHp}");
}