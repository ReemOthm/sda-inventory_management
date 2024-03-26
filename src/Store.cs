namespace Inventory;

class Store
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        bool isItemExist = items.Any((i) => i.Name == item.Name);
        if (isItemExist)
        {
            Console.WriteLine($"The item '{item.Name}' is already exists!");
            return;
        }
        items.Add(item);
        Console.WriteLine($"Item '{item.Name}' has added successfully.");
    }

    public void DeleteItem(string name)
    {
        var item = SearchItem(name);
        if (item == null)
        {
            Console.WriteLine($"Failed to Delete! Can Not Found Item '{name}'!");
            return;
        }
        items.Remove(item);
        Console.WriteLine($"Item '{item.Name}' has deleted successfully.");
    }

    public int GetCurrentVolume()
    {
        return items.Count;
    }

    public void FindItemByName(string name){
        var item = SearchItem(name);
        if(item == null){
            Console.WriteLine($"Item '{name}' Can Not Found!");
            return;
        }
        item.DisplayItem();
    }

    public Item? SearchItem(string name){
        return items.FirstOrDefault(i => i.Name.ToLower() == name.ToLower());
    }
}