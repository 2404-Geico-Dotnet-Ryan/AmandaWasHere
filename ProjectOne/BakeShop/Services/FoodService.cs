//Place to keep functionality (starting off with 1:1 since movie app only has one model):
class FoodService
{
    /*
    What do we want in our service layer/major functionalities, our actions?
    - purchase bakery items
    - view items in cart = 'ViewCart'
    - view items in inventory
    - view availability of bakery items: count of what is left
    - edit inventory
    - add to inventory

    *Trivial Services:
    -   the service is already existing in our data layer so we will just CALL the repo method

    **Don't think about UI, this is just the PROCCESS**
    */

    CartRepo cart = new(); //connects us to the data layer
    public List<Food> ViewCart() //Customer
    {
        //get all baked goods:
        List<Food> allCart = cart.ViewAllCartItems();

        //then filter what you dont want:
        //Not Applicable
        //List<Move> availableMovies = new();
        //foreach(Movie m in allMovies)
        //{if (m.Available)
        //{ availableMovies.Add(m); }}


        //return UPDATED/NEW list:
        return allCart;
    }

//Not sure if applicable:
//"Check out" movie = change the quantity of what is available?
public Food Purchase(Food p) //p is the bake item we want to reduce quantity of and mark in/out stock
{
        //Check we have quantity, does this aide in updating the quantity to reflect what bought
        if (p.InStock)
        {
            //take the quantity of p and update inventory quantity to reflect
        }
        else
        {
            p.InStock = false;
        }
        cart.UpdateItem(p);

        return p;
}


}