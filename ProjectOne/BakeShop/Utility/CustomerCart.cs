class CustomerCart
{
    public Dictionary<int, Food> shoppingCart;

    public int idCounter = 1;

    // //Constructor to give us menu options to start:
    public CustomerCart()
    {
        
        shoppingCart = []; //sets the dictionary to an empty collection, instead of at the top, 
        //moving it into the constructor
    }



}