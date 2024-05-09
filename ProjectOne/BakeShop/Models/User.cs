using System.Dynamic;
using System.Xml;

class User
{
    public int Id { get; set; }
    public string Role { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool SaveOrder { get; set; } //Do I want this here .... ?


    public User()
    {
        Role = "";
        UserName = "";
        Password = "";
    }
    public User(int id, string role, string userName, string password, bool saveOrder)
    {
        Id = id;
        Role = role;
        UserName = userName;
        Password = password;
        SaveOrder = saveOrder;

    }





    //If user is Owner --> add, edit, delete bake goods. Will that functionality live here?

    //If user is customer --> Order items, review last order. Will that functionality live here?
}