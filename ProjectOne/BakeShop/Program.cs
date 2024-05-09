/*
Due: 5/24/24 Friday

create a console application, where the application will be interacting with users via terminal. 
The project will conclude with a 5 minute presentation of working software to trainers and 
colleagues. Your code will be hosted on your personal repository on our class's Github 
Organization.

## Requirements

- The application should interact with users, and provide some console UI
- The application should allow for multiple users to log in and persist their data
- The application should demonstrate good input validation
- The application should persist data to a SQL Server DB
- The application should communicate to DB via ADO.NET or Entity Framework Core
- The application should have unit tests

## Nice to Have

- n-tier architecture
- dependency injection
- The application should log errors and system events to a file or a DB table
- Basic user authentication and authorization (admins vs normal users with passwords


Feedback:
remove the entirety of recipes. There is already a lot of work that goes into the short 
statement of "order bake items" that it will take quite the effort right there. bc its 
multiple things. 1) view baked goods 2) choose to buy one/multiple items. and 3) if 
multiple items, track that, until ready to checkout. 4) possibly add the ability to view 
past orders or purchases would keep it more self-inclusive while adding functionality.


------------- Proposal -------------
Idea: BakeShop, where you can order bakery goods and search for recipes

Users: Owner, Customer

As an Owner:
- can log in
- able to mark items not available (ingredient and search what recipes that impacts to 
then mark as not available)


As a customer:
- login
- order bake items
    - view, choose 1 or multiple, if multi, track until ready to checkout
    - see previous orders(?)


------------- Planning How To -------------
Login: creation? then store, then accesses - happy path for now, use FileIO;

marking not available: List of ingredients? That each recipe will reference to allow recipe 
updates based on availability of ingredients. PRimary key - ingredients

add/edit/delete: list/collection

order bake items: do while loop for asking if they want to add more items, bool


ADDITIONAL NOTES:
-   quantity, can I subject customer quantity from total and have the listed item update
to available or not *Similar to rock game*

*/


using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //LOGIN PROMPT
        User user1 = new();
        Login();

        //CUSTOMER FLOW
        Food bake1 = new();
        BakingWelcome();
        int cInput;
        cInput = int.Parse(Console.ReadLine());

        switch (cInput)
        {
            //CUSTOMER ADD ITEM TO CART FLOW *Display list of available items, select
            //then returned bake to the list with updated quantity reflected
            case 1:
                Console.WriteLine("");
                break;

            //CUSTOMER VIEW CURRENT CART FLOW
            case 2:
                Console.WriteLine();
                break;

            //CUSTOMER DELETE ITEM FROM CART FLOW *Restores quantity to list
            case 3:
                Console.WriteLine();
                break;

            //CUSTOMER REVIEW CART HISTORY FROM LAST TIME (Not all, just last order) FLOW
            case 4:
                Console.WriteLine();
                break;

            //CUSTOMER LOG OUT FLOW
            case 5:
                Console.WriteLine();
                break;
        }

        //OWNER FLOW
        Food bake2 = new();
        OwnerWelcome();
        int oInput;
        oInput = int.Parse(Console.ReadLine());

        switch (oInput)
        {
            //OWNER ADD ITEM TO BAKERY FLOW
            case 1:
                Console.WriteLine("");
                break;

            //OWNER UPDATE BAKERY ITEM FLOW
            case 2:
                Console.WriteLine("");
                break;

            //OWNER REMOVE BAKERY ITEM FLOW
            case 3:
                Console.WriteLine("");
                break;

            //OWNER LOG OUT FLOW
            case 4:
                Console.WriteLine("");
                break;
        }

    }



    //Exception handling, EDIT EDIT EDIT, copy/paste from class demo; would like logging
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

    //Methods
    public static void Login()
    {
        Console.WriteLine("<><><><><><><><><><><><><><><><><><>");
        Console.WriteLine("<><><>Welcome to the Bake Shop<><><>");
        Console.WriteLine("<><><><><><><><><><><><><><><><><><>");

        Console.WriteLine("Please enter your user name: ");
        string userName = Console.ReadLine() ?? "";

        Console.WriteLine("Please enter your password: ");
        string password = Console.ReadLine() ?? "";

        Console.WriteLine("Welcome back, " + userName + "!");
    }
    public static void BakingWelcome()
    {
        Console.WriteLine("<><><><><><><><><><><><><><><><><>");
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("<><><><><><><><><><><><><><><><><>");
        Console.WriteLine();
        Console.WriteLine("[1] Order Items");
        Console.WriteLine("[2] See Last Order");
        Console.WriteLine("[3] Log Out");

    }

    public static void OwnerWelcome()
    {
        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><>");
        Console.WriteLine("Hey boss, what do you need to do today?");
        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><>");
        Console.WriteLine();
        Console.WriteLine("[1] Add Items");
        Console.WriteLine("[2] Update Items");
        Console.WriteLine("[3] Delete Items");
        Console.WriteLine("[4] Log Out");

    }



}

