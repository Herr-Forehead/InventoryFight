namespace InventoryFight;

public class Inventory
{
    public List<Item> items = new();

    public void Add(Item item)
    {
        items.Add(item);
    }
}
