namespace Inventory;

class Store
{
    private List<Item> _items = [];

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

            bool isItemExist = _items.Any((i) => i.Name == item.Name);
            if (isItemExist)
            {
                Console.WriteLine($"The item '{item.Name}' is already exists!");
                return;
            }
            _items.Add(item);
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
        _items.Remove(item);
        Console.WriteLine($"Item '{item.Name}' has deleted successfully.");
    }

    public int GetCurrentVolume()
    {
        return _items.Sum(item => item.Quantity);
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
        return _items.FirstOrDefault(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
    }

    public List<Item> SortByNameAsc()
    {
        return [.. _items.OrderBy(i => i.Name)];
    }

    public List<Item> SortByDate(SortOrder sortOrder)
    {
        return sortOrder switch
        {
            SortOrder.ASC => [.. _items.OrderBy(i => i.CreatedDate)],
            SortOrder.DESC => [.. _items.OrderByDescending(i => i.CreatedDate)],
        };
    }

    public Dictionary<string, List<Item>> GroupByDate()
    {
        DateTime dateTime = DateTime.Now.AddMonths(-3);

        var groupedDictionary = _items.GroupBy(i => i.CreatedDate > dateTime ? "New Arrival" : "Old").ToDictionary(g => g.Key, g => g.ToList()).OrderBy(d => d.Key);

        return groupedDictionary.ToDictionary();
    }
}