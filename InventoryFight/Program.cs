using InventoryFight;

string restart = "yes";
string mainMenuChoice;
string quitChoice;
string shopChoice;
Character Character = new();
Item potion = new();
Item peasant = new();
Item talisman = new();
Item superUltraNuke = new();

potion.cost = 10;
peasant.cost = 2;
talisman.cost = 25;
superUltraNuke.cost = 50;

Console.WriteLine("What is your name??");
Character.name = Console.ReadLine();
Character.money = 50;

// Console.WriteLine($"Okay, {Character.name} do you want to start the game?");

while (restart == "yes")
{
    Console.Clear();
    Console.WriteLine("Welcome to Inventory fight!!! Now that you've made the stupid mistake off starting this stupid game, what do you wish to do? Do you wish to prepare for battle, like a coward? Or do you want to jump right into the fray and win glory in the Wastelands!!!");
    Console.WriteLine("a) view Inventory");
    Console.WriteLine("b) view shop");
    Console.WriteLine("c) enter the Arena");
    Console.WriteLine("d) Quit");
    mainMenuChoice = Console.ReadLine();
    if (mainMenuChoice == "a)" || mainMenuChoice == "a" || mainMenuChoice == "inventory")
    {
        Console.Clear();
        Console.WriteLine($"{Character.name}             {Character.money}");
        Console.WriteLine("");
        Console.WriteLine(Character.Inventory.items);
    }
    else if (mainMenuChoice == "b)" || mainMenuChoice == "b" || mainMenuChoice == "shop")
    {
        Console.Clear();
        Console.WriteLine($"{Character.name}             {Character.money}");
        Console.WriteLine("");
        Console.WriteLine("1. Peasant                         2g");
        Console.WriteLine("2. Potion                          10g");
        Console.WriteLine("3. Talisman                        25g");
        Console.WriteLine("4. Super Ultra Nuke                50g");
        Console.WriteLine("What do you want to buy??");
        shopChoice = Console.ReadLine();
        if (shopChoice == "Peasant" || shopChoice == "peasant" || shopChoice == "1")
        {
            Character.Inventory.Add(peasant);
            Character.money -= peasant.cost;
        }
        else if (shopChoice == "Potion" || shopChoice == "potion" || shopChoice == "2")
        {
            Character.Inventory.Add(potion);
            Character.money -= potion.cost;
        }
        else if (shopChoice == "Talisman" || shopChoice == "talisman" || shopChoice == "3")
        {
            Character.Inventory.Add(talisman);
            Character.money -= talisman.cost;
        }
        else if (shopChoice == "Nuke" || shopChoice == "nuke" || shopChoice == "4")
        {
            Character.Inventory.Add(superUltraNuke);
            Character.money -= superUltraNuke.cost;
        }
        else if (shopChoice == "no")
        {

        }

    }
    else if (mainMenuChoice == "c)" || mainMenuChoice == "c" || mainMenuChoice == "fight")
    {
        Console.Clear();
    }
    else if (mainMenuChoice == "d)" || mainMenuChoice == "d" || mainMenuChoice == "quit")
    {
        Console.Clear();
        Console.WriteLine("Well thats sad");
        Console.WriteLine("Are you sure?");
        quitChoice = Console.ReadLine();
        if (quitChoice == "yes")
        {
              
        }
        else if (quitChoice == "no")
        {
            Console.Clear();
            restart = "yes";
        }
        else if(quitChoice != "yes" || quitChoice != "no")
        {
            Console.WriteLine("You imbecile! You foolishly foolih fool!!");
            Console.WriteLine("How do you not understand a simple yes no question??!!!");
        }
        else
        {
            // nah
        }
    }
}

Console.ReadLine();