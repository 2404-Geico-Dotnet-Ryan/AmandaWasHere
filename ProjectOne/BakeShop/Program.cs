/*
------------- Proposal -------------
Idea: BakeShop, where you can order bakery goods and search for recipes

Users: Owner, Customer

As an Owner:
- can log in
- able to mark items not available (ingredient and search what recipes that impacts to 
then mark as not available)
- add/edit/delete recipes

As a customer:
- login
- order bake items
- search for recipes


------------- Planning How To -------------
Login: creation? then store, then accesses - happy path for now, use FileIO;

marking not available: List of ingredients? That each recipe will reference to allow recipe 
updates based on availability of ingredients. PRimary key - ingredients

add/edit/delete: list/collection

order bake items: do while loop for asking if they want to add more items, bool

search recipes: ? not sure yet, probably similar to login, have fileIO where recipes are stored?


*/




using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int bakeCookies = 0;
        int bakeBagels = 0;
        Baking bake1 = new();

        bake1.BakingWelcome();
        int bake = bake1.LetsBake();


        switch (bake)
        {
            case 1:
                {
                    bakeCookies = bake1.Cookies();
                    return;
                }

            case 2:
                {
                    Console.WriteLine("Great! Let's make bread! You will need:");
                    Console.WriteLine("2 cups - water");
                    Console.WriteLine(".25 cup - sugar");
                    Console.WriteLine("1.5 tablespoons - active dry yeast");
                    Console.WriteLine("1.5 teaspoons - salt");
                    Console.WriteLine(".25 cup - vegetable oil");
                    Console.WriteLine("6 cups - bread flour");

                    break;
                }
            case 3:
                {
                    bakeBagels = bake1.Bagels();
                    return;
                }
        }


    }


}

