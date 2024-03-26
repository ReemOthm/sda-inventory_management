namespace Inventory;

class Store
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        bool isItemExist = items.Any((i) => i.name == item.name);
        if (isItemExist)
        {
            Console.WriteLine($"The item '{item.name}' is already exists!");
            return;
        }
        items.Add(item);
        Console.WriteLine($"Item '{item.name}' has added successfully.");
    }

    public void DeleteItem(Item item)
    {
        bool isItemExist = items.Any((i) => i.name == item.name);
        if (!isItemExist)
        {
            Console.WriteLine($"Failed to Delete! Can Not Found Item '{item.name}'!");
            return;
        }
        items.Remove(item);
        Console.WriteLine($"Item '{item.name}' has deleted successfully.");
    }

    public int GetCurrentVolume()
    {
        return items.Count;
    }
}