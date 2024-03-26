namespace Inventory;

class Item
{

    public string Name { get; }

    public int Quantity { get; set; }
    public DateTime CreatedDate { get; set; }

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
    public override string ToString()
    {
        return $"{{Item Name: {Name} , Quantity: {Quantity} , Created Date: {CreatedDate} }}";
    }
}