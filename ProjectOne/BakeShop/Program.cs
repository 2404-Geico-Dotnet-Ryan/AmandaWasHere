using System;
class Program
{
    // static FoodService fs = new();
    // static UserService us = new();
    // static User? currentUser = null;

    static void Main(string[] args)
    {
        // //LOGIN PROMPT
        UserRepo user = new();
        GeneralWelcome(user);
        Register(user);
        Login(user);

        //User Experience Begins:
        CartRepo cart = new();
        MainMenu(cart);
        Console.WriteLine("Thank you for shopping with Bake Shop!");
    }

    //Methods
    public static void GeneralWelcome(UserRepo user)
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("<><><>Welcome to the Bake Shop<><><>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><>");
            Console.WriteLine();
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("<><><><><><><><><><><><><><><><><>");
            Console.WriteLine();
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");

            int gInput = int.Parse(Console.ReadLine() ?? "0");
            keepGoing = GeneralNextSteps(user, gInput);
        }
    }
    public static bool GeneralNextSteps(UserRepo user, int gInput)
    {
        switch (gInput)
        {
            case 1:
                {
                    Register(user);
                    break;
                }
            case 2:
                {
                    Login(user);
                    break;
                }
        }
        return true;
    }
    public static void Register(UserRepo user)
    {
        Console.WriteLine("Please enter a user name: ");
        string userName = Console.ReadLine() ?? "";

        Console.WriteLine("Please enter a password: ");
        string password = Console.ReadLine() ?? "";
    }
    public static void Login(UserRepo user)
    {
        Console.WriteLine("Please enter your user name: ");
        string userName = Console.ReadLine() ?? "";

        Console.WriteLine("Please enter your password: ");
        string password = Console.ReadLine() ?? "";

        Console.WriteLine("Welcome back, " + userName + "!");
    }
    public static void MainMenu(CartRepo cart)
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><>");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("<><><><><><><><><><><><><><><><><>");
            Console.WriteLine();
            Console.WriteLine("[1] View Menu");
            Console.WriteLine("[1] Add To Cart");
            Console.WriteLine("[2] View Cart");
            Console.WriteLine("[3] Update Cart");
            Console.WriteLine("[4] Delete Item from Cart");
            Console.WriteLine("[5] Log Out");

            int cInput = int.Parse(Console.ReadLine() ?? "0");

            keepGoing = NextSteps(cart, cInput);
        }

    }
    public static bool NextSteps(CartRepo cart, int cInput)
    {
        switch (cInput)
        {
            //CUSTOMER ADD ITEM TO CART FLOW *Display list of available items, select
            //then returned back to the list with updated quantity reflected
            case 1:
                {
                    ViewMenu(cart);
                    break;
                }
             //CUSTOMER ADD ITEM TO CART FLOW *Display list of available items, select
            //then returned back to the list with updated quantity reflected
            case 2:
                {
                    AddItem(cart);
                    break;
                }
            //CUSTOMER VIEW CURRENT CART FLOW
            case 3:
                {
                    ViewItem(cart);
                    break;
                }
            //CUSTOMER DELETE ITEM FROM CART FLOW *Restores quantity to list
            case 4:
                {
                    UpdateItem(cart);
                    break;
                }
            // //CUSTOMER REVIEW CART HISTORY FROM LAST TIME (Not all, just last order) FLOW
            case 5:
                {
                    DeleteItem(cart);
                    break;
                }
        }
        return true;
    }

    public static void AddItem(CartRepo cart)
    {
        Console.WriteLine("Let's add to your cart!");
        Console.WriteLine("What is the item name?");
        string itemName = Console.ReadLine() ?? "";
        Console.WriteLine("How many would you like?");
        int quantity = int.Parse(Console.ReadLine() ?? "0");

        Food bakeryItem = new(0, itemName, 0, true, quantity, null);

        bakeryItem = cart.AddItem(bakeryItem);

        Console.WriteLine("Added to cart: " + bakeryItem);
    }

    public static void ViewItem(CartRepo cart)
    {
        List<Food> bakeryItems = cart.ViewAll();
        Console.WriteLine("Currently in your cart:");
        foreach (Food b in bakeryItems)
        {
            Console.WriteLine(b);
        }

    }
    public static void UpdateItem(CartRepo cart)
    {
        Food bakeryItem = PromptCustomer(cart);
        Console.WriteLine("Please update quantity: ");
        bakeryItem.Quantity = int.Parse(Console.ReadLine() ?? "0");
    }

    public static void DeleteItem(CartRepo cart)
    {
        Food bakeryItem = PromptCustomer(cart);
        Console.WriteLine("Deleted bakery item: " + cart.DeleteItem(bakeryItem));
    }

    // //Helper:
    public static Food PromptCustomer(CartRepo cart)
    {
        Food? retrievedFood = null;
        while (retrievedFood == null)
        {
            Console.WriteLine("Enter bakery item ID: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            retrievedFood = cart.ViewItem(input);
        }
        return retrievedFood;
    }
    // public static void LogOut()
    // {

    // }
    //     Exception handling, EDIT EDIT EDIT, copy/paste from class demo; would like logging
    //     public static void HandlingExceptions()
    // {
    //     int[] numbers = [1, 2, 3];

    //     System.Console.WriteLine("Enter an index: ");
    //     string input = Console.ReadLine() ?? "0";
    //     //Handling Exceptions: try-catch block
    //     try
    //     {
    //         int index = int.Parse(input);
    //         System.Console.WriteLine(numbers[index]);
    //     }
    //     catch (Exception ex)
    //     {
    //         System.Console.WriteLine(ex.Message);
    //         System.Console.WriteLine(ex.StackTrace);
    //     }

    //     System.Console.WriteLine("Program End");

    // }


}

