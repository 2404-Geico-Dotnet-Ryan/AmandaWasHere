class Baking
{
    //Fields
    string bread;
    string bagels;
    string cookies;


    //Constructors
    public Baking()
    {
        bread = "";
        bagels = "";
        cookies = "";
    }


    //Methods

    public void BakingWelcome()
    {
        Console.WriteLine("<><><><><><><><><><><><><><><><><>");
        Console.WriteLine("****WELCOME TO THE  BAKESHOP!****");
        Console.WriteLine("<><><><><><><><><><><><><><><><><>");

        Console.WriteLine("Please select a recipe to get started!");

        Console.WriteLine("[1] I want to bake chocolate chip cookies");
        Console.WriteLine("[2] I want to make bread");
        Console.WriteLine("[3] I want to make bagels");
    }

    public int LetsBake()
    {
        int bake = 0;
        string? userInput;
        userInput = Console.ReadLine();
        if (userInput != null) bake = int.Parse(userInput);
        return bake;
    }

    public int Cookies()
    {
        int bakeCookies;
        int flaxseed = 1;
        decimal water = 2.5m;
        decimal butter = .5m;
        decimal sugar = 1.25m;
        int vanilla = 2;
        decimal flour = 1.25m;
        int cornstarch = 2;
        int soda = 1;
        decimal salt = 1.25m;
        int chips = 1;

        Console.WriteLine("Great! Let's make chocolate chip cookies!");
        Console.WriteLine("How many cookies do you want to bake? Enter [1] for less than 15 cookies, or [2] for more than 15:");
        string? cookieCount = Console.ReadLine();

        if (int.TryParse(cookieCount, out bakeCookies))
        {
            if (bakeCookies <= 15)
            {
                Console.WriteLine("Great! You will need....");
                Console.WriteLine(bakeCookies * flaxseed + " tablespoon - ground flaxseed");
                Console.WriteLine(bakeCookies * water + " tablespoons - water");
                Console.WriteLine(bakeCookies * butter + " cup - plant based butter");
                Console.WriteLine(bakeCookies * sugar + " cups - brown sugar");
                Console.WriteLine(bakeCookies * vanilla + " teaspoons - vanilla extract");
                Console.WriteLine(bakeCookies * flour + " cups - flour");
                Console.WriteLine(bakeCookies * cornstarch + " teaspoons - cornstarch");
                Console.WriteLine(bakeCookies * soda + " teaspoon - baking soda");
                Console.WriteLine(bakeCookies * salt + " teaspoon - salt");
                Console.WriteLine(bakeCookies * chips + " cup - non-dairy chocolate chips");

            }

            else
            {
                Console.WriteLine("Great! You will need....");
                Console.WriteLine(bakeCookies * flaxseed + " tablespoons - ground flaxseed");
                Console.WriteLine(bakeCookies * water + " tablespoons - water");
                Console.WriteLine(bakeCookies * butter + " cup - plant based butter");
                Console.WriteLine(bakeCookies * sugar + " cups - brown sugar");
                Console.WriteLine(bakeCookies * vanilla + " teaspoons - vanilla extract");
                Console.WriteLine(bakeCookies * flour + " cups - flour");
                Console.WriteLine(bakeCookies * cornstarch + " teaspoons - cornstarch");
                Console.WriteLine(bakeCookies * soda + " teaspoons - baking soda");
                Console.WriteLine(bakeCookies * salt + " teaspoon - salt");
                Console.WriteLine(bakeCookies * chips + " cups - non-dairy chocolate chips");
            }
        }
        //break;
        return bakeCookies;
    }

    public int Bagels()
    {
        int bakeBagels;
        int water = 300;
        int yeast = 10;
        int breadFlour = 500;
        int salt = 6;
        int sugar = 23;


        Console.WriteLine("Great! Let's make bagels!");
        Console.WriteLine("How many bagels do you want to bake? Enter [1] for less than 15 bagels, or [2] for more than 15:");
        string? bagelCount = Console.ReadLine();

        if (int.TryParse(bagelCount, out bakeBagels))
        {
            if (bakeBagels <= 15)
            {
                Console.WriteLine("Great! You will need....");
                Console.WriteLine(bakeBagels * water + "g water");
                Console.WriteLine(bakeBagels * yeast + "g instant yeast");
                Console.WriteLine(bakeBagels * breadFlour + "g bread flour");
                Console.WriteLine(bakeBagels * salt + "g salt");
                Console.WriteLine(bakeBagels * sugar + "g sugar");

            }

            else
            {
                Console.WriteLine("Great! You will need....");
                Console.WriteLine(bakeBagels * water + "g water");
                Console.WriteLine(bakeBagels * yeast + "g instant yeast");
                Console.WriteLine(bakeBagels * breadFlour + "g bread flour");
                Console.WriteLine(bakeBagels * salt + "g salt");
                Console.WriteLine(bakeBagels * sugar + "g sugar");

            }
        }
        //break;
        return bakeBagels;
    }



}