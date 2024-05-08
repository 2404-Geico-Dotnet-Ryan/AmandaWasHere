using System.Dynamic;

class UserLogins
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool SaveOrder { get; set; }


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
    }



    //If user is Owner --> add, edit, delete bake goods

    //If user is customer --> Order items, review last order
}