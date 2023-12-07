namespace InventoryFight;

public class Inventory
{
    public List<Item> items;
    public string addItem;

    public void Add(Item item)
    {

        items.Add(item);
    }
}
