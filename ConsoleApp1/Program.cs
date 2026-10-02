Character myChar = new();

myChar.Backpack.Display();

Armor helmet = new Armor() { Name = "bronze helmet", weight = 3f };

Console.WriteLine($"You've found a {helmet.Name}. pick it up? [yes|no]");

string choice = "";
while (choice != "yes" && choice != "no")
{
    choice = Console.ReadLine().ToLower();
}

if (choice == "yes")
{
    Console.WriteLine("Adding it to your inventory");
    myChar.Backpack.Items.Add(helmet);
}
else
{
    Console.WriteLine("skipping it");
}

Console.WriteLine("Your inventory is now:");
myChar.Backpack.Display();

Console.ReadLine();
