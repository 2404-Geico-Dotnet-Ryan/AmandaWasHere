using System.Dynamic;
using System.Xml;

class UserLogins
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool SaveOrder { get; set; } //Do I want this here .... ?


    public UserLogins()
    {
        UserName = "";
        Password = "";
    }
    public UserLogins(int id, string userName, string password, bool saveOrder)
    {
        Id = id;
        UserName = userName;
        Password = password;
        SaveOrder = saveOrder;

    }

    public static void Login()
    {
        Console.WriteLine("Please enter your user name: ");
        string userName = Console.ReadLine() ?? "";

        Console.WriteLine("Please enter your password: ");
        string password = Console.ReadLine() ?? "";

        Console.WriteLine("Welcome back, " + userName + "!");
    }



    //If user is Owner --> add, edit, delete bake goods. Will that functionality live here?

    //If user is customer --> Order items, review last order. Will that functionality live here?
}