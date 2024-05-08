class BakedGoods
{

    public Dictionary<int, Baking> bakeryItems;

    public int idCounter = 1;
    // //Constructor to give us menu options to start:
    public BakedGoods()
    {
        Baking bakeGood1 = new(idCounter++, "Bagel", 1.99, true, 0);
        Baking bakeGood2 = new(idCounter++, "Cookies", 1.50, true, 0);
        Baking bakeGood3 = new(idCounter++, "Bread", 4.87, true, 0);


        bakeryItems = []; //sets the dictionary to an empty collection, instead of at the top, 
        //moving it into the constructor
        bakeryItems.Add(bakeGood1.Id, bakeGood1);
        bakeryItems.Add(bakeGood2.Id, bakeGood2);
        bakeryItems.Add(bakeGood3.Id, bakeGood3);

    }

}