class CartRepo
{
    //CRUD for Customer - hopefully this prevents the customer from making edits to the Food
    //and is for what they put in their shopping cart...So do I need a Utility for that?
    //Can I keep the same bakedGoods here for use in CustomerCart as they are being used
    //in the BGoods repo for the owner use and customer use to ADD items to their cart

    CustomerCart bakedGoods = new();

    public Food AddItem(Food a)
    {
        a.Id = bakedGoods.idCounter++;

        bakedGoods.shoppingCart.Add(a.Id, a);
        return a;
    }
    public Food? ViewItem(int id)
    {
        if (bakedGoods.shoppingCart.ContainsKey(id))
        {
            Food selectedItem = bakedGoods.shoppingCart[id];
            return selectedItem;
        }
        else
        {
            Console.WriteLine("Sorry, we don't have that item.");
            return null;
        }
    }
    //VIEW CART
    public List<Food> ViewAllCartItems()
    {
        return bakedGoods.shoppingCart.Values.ToList();
    }
    public Food? UpdateItem(Food b)
    {
        try
        {
            bakedGoods.shoppingCart[b.Id] = b;
            return b;
        }
        catch (Exception)
        {
            Console.WriteLine("Sorry, we don't have that item.");
            return null;
        }

    }
    public Food? DeleteItem(Food c)
    {
        bool didRemove = bakedGoods.shoppingCart.Remove(c.Id);

        if (didRemove)
        {
            return c;
        }
        else
        {
            Console.WriteLine("Sorry, we don't have that item.");
            return null;
        }
    }

}