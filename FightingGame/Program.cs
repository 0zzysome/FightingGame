// See https://aka.ms/new-console-template for more information



Fighter f1 = Fighter.MakeCharacter();



Fighter f2 = Fighter.MakeCharacter();





while(f1.Hp > 0 && f2.Hp > 0)
{
    Console.WriteLine($"Hello, World!");
    turn(f1, f2);
    
    Console.WriteLine($"Hello, World!");
    
    


    Console.WriteLine("Tryck på enter för att fortsätta.");
    Console.ReadLine();

}
if(f1.Hp == 0 && f2.Hp == 0)
{
    Console.WriteLine("Oavgort!");
}
else if(f1.Hp == 0)
{
    Console.WriteLine($"{f2.name} wins!"); 
}
else
{
    Console.WriteLine($"{f1.name} wins!"); 
}

Console.WriteLine("Tryck på enter för att fortsätta.");
Console.ReadLine();


void turn(Fighter Player, Fighter target)
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
            switch(ActionNumber)
            {
                case 1:
                    Player.Hit(target);
                    break;
                case 2:
                    
                    break;
                case 3:

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
                        ChoseAction = false;         
                    }
                    break;
                default:
                    ChoseAction = false;
                    break;


            }


        }
    }
