class BGoodsRepo
{
    //CRUD for Owner, can customer use too?



    BakedGoods bakedGoods = new();

    public Baking AddItem(Baking a)
    {
        a.Id = bakedGoods.idCounter++;

        bakedGoods.bakeryItems.Add(a.Id, a);
        return a;
    }
    public Baking? ViewItem(int id)
    {
        if (bakedGoods.bakeryItems.ContainsKey(id))
        {
            Baking selectedItem = bakedGoods.bakeryItems[id];
            return selectedItem;
        }
        else
        {
            Console.WriteLine("Sorry, we don't have that item.");
            return null;
        }
    }

    // public Baking UpdateItem(Baking a)
    // {

    // }
    // public Baking DeleteItem(Baking a)
    // {

    // }

}