// See https://aka.ms/new-console-template for more information



Fighter f1 = new Fighter();
f1.weapon = new Weapon();
CreateChar(f1);
Fighter f2 = new Fighter();
f2.weapon = new Weapon();





while(f1.hp > 0 && f2.hp > 0)
{
    Console.WriteLine($"Hello, World!");
    turn(f1, f2);
    
    Console.WriteLine($"Hello, World!");
    
    


    Console.WriteLine("Tryck på enter för att fortsätta.");
    Console.ReadLine();

}
if(f1.hp == 0 && f2.hp == 0)
{
    Console.WriteLine("Oavgort!");
}
else if(f1.hp == 0)
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
void CreateChar(Fighter Player)
    {
        bool MadeChar = false;
        int Choice = 0;
        //spelaren väljer namn på karatär
        Console.WriteLine("Choose a name for your fighter."); 
        Player.name = Console.ReadLine();
        // ser om skapandet av karaktären gick igenom
        while (MadeChar==false)
        {
            Console.Clear();
            // spelaren väljer klass
            Console.WriteLine("Choose a class for your fighter.");
            Console.WriteLine("1. Rouge");
            Console.WriteLine("2. Soldier");
            Console.WriteLine("3. Class info");
            
            MadeChar =int.TryParse(Console.ReadLine(), out Choice);
            // Ändrar på alla variabler så de matchar klassen
            //
            switch(Choice)
            {
                case 1:
                    
                    Player = new Rouge(); 
                    break;
                case 2: 
                    
                    Player = new Soldier();
                    break;
                case 3:
                    ClassInfo();
                    MadeChar = false;
                    break;
                default:
                    MadeChar = false;
                    break;

            }
        }
    }
void ClassInfo()
{   
    bool IsDone = false; 
    int Choice = 0;
    while(IsDone==false)
    {
        Console.Clear();
        Console.WriteLine("What class do you whant info about.");
        Console.WriteLine("1. Rouge");
        Console.WriteLine("2. Soldier");
        //läser in vad splarens skriver in 
        IsDone =int.TryParse(Console.ReadLine(), out Choice);
        //Isdone = true
        switch(Choice)
        {
            case 1:
                Console.WriteLine("Class: Rouge");
                Console.WriteLine("Max HP: ");
                Console.WriteLine("Strength : ");
                Console.WriteLine("Defence: ");
                Console.WriteLine("Dodge Chance: ");
                Console.WriteLine("Crit chance: ");
                Console.WriteLine("Crit damage multiplier: ");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                
                break;
            case 2:
                Console.WriteLine("Class: Rouge");
                Console.WriteLine("Max HP: ");
                Console.WriteLine("Strength : ");
                Console.WriteLine("Defence: ");
                Console.WriteLine("Dodge Chance: ");
                Console.WriteLine("Crit chance: ");
                Console.WriteLine("Crit damage multiplier: ");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                
                break;
            default:
                IsDone = false;

                break;
        }
        
    }
        

}
