/*
Due: 5/24/24 Friday

create a console application, where the application will be interacting with users via terminal. 
The project will conclude with a 5 minute presentation of working software to trainers and 
colleagues. Your code will be hosted on your personal repository on our class's Github 
Organization.

## Requirements

- The application should be a C# Console Application
- The application should build and run
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


*/


using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        Baking bake1 = new();
        Baking.BakingWelcome();

        UserLogins user1 = new();
        UserLogins.Login();
    }


}

