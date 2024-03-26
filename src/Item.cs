namespace Inventory;

class Item
{

    public string Name { get; }

    private int _quantity;
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value;}
    }
    private DateTime CreatedDate { get; set; }

    public Item(string name, int quantity, DateTime createdDate = default)
    {
        if (quantity < 0)
        {
            throw new Exception("Error: Quantity cannot be less than 0!");
        }
        Name = name;
        Quantity = quantity;
        CreatedDate = createdDate == default ? DateTime.Now : createdDate;
    }

    public void DisplayItem()
    {
        Console.WriteLine($"Item Name: {Name}\nQuantity: {Quantity}\nCreated Date: {CreatedDate}");
    }

}