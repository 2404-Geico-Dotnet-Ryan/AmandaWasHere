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
        Console.WriteLine("****WELCOME TO THE  BAKESHOP!****");
        Console.WriteLine("<><><><><><><><><><><><><><><><><>");

        Console.WriteLine("Please select an option from below!");

        Console.WriteLine("[1] Order Items");
        Console.WriteLine("[2] See Last Order");

    }




}