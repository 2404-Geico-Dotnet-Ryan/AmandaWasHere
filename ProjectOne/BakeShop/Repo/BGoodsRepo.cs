class BGoodsRepo
{
    //CRUD for Owner
    BakedGoods bakedGoods = new();

    public Food AddItem(Food a)
    {
        a.Id = bakedGoods.idCounter++;

        bakedGoods.bakeryItems.Add(a.Id, a);
        return a;
    }
    public Food? ViewItem(int id)
    {
        if (bakedGoods.bakeryItems.ContainsKey(id))
        {
            Food selectedItem = bakedGoods.bakeryItems[id];
            return selectedItem;
        }
        else
        {
            Console.WriteLine("Sorry, we don't have that item.");
            return null;
        }
    }

    //VIEW ALL
    public List<Food> GetAllBakeryItems()
    {
        return [.. bakedGoods.bakeryItems.Values];
    }

    public Food? UpdateItem(Food b)
    {
        try
        {
            bakedGoods.bakeryItems[b.Id] = b;
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
        bool didRemove = bakedGoods.bakeryItems.Remove(c.Id);

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