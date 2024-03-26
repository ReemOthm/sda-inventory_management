namespace Inventory;

class Item
{

    public readonly string name;
    private int Quantity { get; set; }
    private DateTime CreatedDate { get; set; }

    public Item(string name, int quantity, DateTime createdDate = default)
    {
        if (quantity < 0)
        {
            throw new Exception("Error: Quantity cannot be less than 0!");
        }
        this.name = name;
        Quantity = quantity;
        CreatedDate = createdDate == default ? DateTime.Now : createdDate;
    }

}