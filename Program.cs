class Item {
    public string Name{ get; }
    private int quantity;

    public int Quantity{
        set{quantity = value;}
        get{return quantity;}
    }
    public DateTime CreatedDate{ get; set;}

    public Item(string name, int quantity, DateTime createdDate = default){
        if(quantity < 0){
            throw new Exception("Error: Quantity cannot be less than 0!");
        }
        Name = name;
        Quantity = quantity;
        CreatedDate = createdDate == default ? DateTime.Now : createdDate;
    }

}

class Store{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item){
        bool isItemExist = items.Any((i)=> i.Name == item.Name);
        if(isItemExist){
            Console.WriteLine($"The item '{item.Name}' is already exists!");
            return;
        }
        items.Add(item);
        Console.WriteLine($"{item.Name} has been added successfully.");
    }

}

class Program{
    static void Main(string []args){
        // items example - You do not need to follow exactly the same
        var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
        var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
        var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
        var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
        var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
        var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
        var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
        var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
        var coffee = new Item("Coffee", 20);
        var sandwich = new Item("Sandwich", 15);
        var batteries = new Item("Batteries", 10);
        var umbrella = new Item("Umbrella", 5);
        var sunscreen = new Item("Sunscreen", 8);

        var store = new Store();
        store.AddItem(pen);
        store.AddItem(pen);
        store.AddItem(soap);
    }
}