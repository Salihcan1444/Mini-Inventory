public class Character
{
    public int Hp;
    public string Name;
    public inventory Backpack;

    public Character()
    {
        Backpack = new();

        Weapon w = new() { Name = "Axe", weight = 10f };
        Consumable p = new() { Name = "Health potion", weight = 2f };

        Backpack.Items.Add(w);
        Backpack.Items.Add(p);

        Hp = 100;
        Name = "";
    }
}