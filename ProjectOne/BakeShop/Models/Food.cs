class Food
{
    //Properties

    public int Id { get; set; }
    public string ItemName { get; set; }
    public double Price { get; set; }
    public bool InStock { get; set; }
    public int Quantity { get; set; }



    //Constructors
    public Food()
    {
        ItemName = "";
    }

    public Food(int id, string itemName, double price, bool inStock, int quantity)
    {
        Id = id;
        ItemName = itemName;
        Price = price;
        InStock = inStock;
        Quantity = quantity;

    }


    //Methods - Can ToString be moved to UI?
    public override string ToString()
    {
        return "ID: " + Id
        + ", Item Name: " + ItemName
        + ", Price: " + Price
        + ", In Stock: " + InStock
        + ", Quantity: " + Quantity;

    }




}