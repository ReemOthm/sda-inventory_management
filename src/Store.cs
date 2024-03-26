namespace Inventory;

class Store
{
    private List<Item> items = [];

    private int _maximumCapacity;

    public Store(int maximumCapacity)
    {
        this._maximumCapacity = maximumCapacity;
    }

    public void AddItem(Item item)
    {
        try
        {
            if (GetCurrentVolume() + item.Quantity > _maximumCapacity)
            {
                throw new Exception("Cannot Add! Items Exceed the Store Capacity");
            }

            bool isItemExist = items.Any((i) => i.Name == item.Name);
            if (isItemExist)
            {
                Console.WriteLine($"The item '{item.Name}' is already exists!");
                return;
            }
            items.Add(item);
            Console.WriteLine($"Item '{item.Name}' has added successfully.");

        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }
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
        return items.Sum(item => item.Quantity);
    }

    public void FindItemByName(string name)
    {
        var item = SearchItem(name);
        if (item == null)
        {
            Console.WriteLine($"Item '{name}' Can Not Found!");
            return;
        }
        Console.WriteLine(item.ToString());
    }

    public Item? SearchItem(string name)
    {
        return items.FirstOrDefault(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
    }

    public List<Item> SortByNameAsc()
    {
        return [.. items.OrderBy(i => i.Name)];
    }

    public List<Item> SortByDate(SortOrder sortOrder)
    {
        return sortOrder switch
        {
            SortOrder.ASC => [.. items.OrderBy(i => i.CreatedDate)],
            SortOrder.DESC => [.. items.OrderByDescending(i => i.CreatedDate)],
        };
    }
}