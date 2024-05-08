class Baking
{
    //Properties

    public int Id { get; set; }
    public string ItemName { get; set; }
    public double Price { get; set; }
    public bool InStock { get; set; }
    public int Quantity { get; set; }



    //Constructors
    public Baking()
    {
        ItemName = "";
    }

    public Baking(int id, string itemName, double price, bool inStock, int quantity)
    {
        Id = id;
        ItemName = itemName;
        Price = price;
        InStock = inStock;
        Quantity = quantity;

    }


    //Methods
    public override string ToString()
    {
        return "ID: " + Id
        + ", Item Name: " + ItemName
        + ", Price: " + Price
        + ", In Stock: " + InStock
        + ", Quantity: " + Quantity;

    }

    public static void BakingWelcome()
    {
        Console.WriteLine("<><><><><><><><><><><><><><><><><>");
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("<><><><><><><><><><><><><><><><><>");
        Console.WriteLine();
        Console.WriteLine("[1] Order Items");
        Console.WriteLine("[2] See Last Order");

    }

    public static void OwnerWelcome()
    {

        Console.WriteLine("<><><><><><><><><><><><><><><><><>");
        Console.WriteLine("Hey boss, what do you need to do today?");
        Console.WriteLine("<><><><><><><><><><><><><><><><><>");
        Console.WriteLine();
        Console.WriteLine("[1] Add Items");
        Console.WriteLine("[2] Update Items");
        Console.WriteLine("[3] Delete Items");

    }


}