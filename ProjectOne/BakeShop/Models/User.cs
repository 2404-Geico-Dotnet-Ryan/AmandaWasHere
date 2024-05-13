using System.Dynamic;
using System.Xml;

class User
{
    public int Id { get; set; }
    public string Role { get; set; } //Owner bool?; Ryan suggests string; Owner and Customer
    public string UserName { get; set; }
    public string Password { get; set; }
    //public bool SaveOrder { get; set; } //Do I want this here .... ? This will be to allow
    //the customer to see last order

    public User()
    {
        Role = "";
        UserName = "";
        Password = "";
    }
    public User(int id, string role, string userName, string password)
    {
        Id = id;
        Role = role;
        UserName = userName;
        Password = password;
    }


    public override string ToString() //allows for single quotations
    {
        return "ID: " + Id
        + ", Role: " + Role
        + ", User Name: " + UserName
        + ", Password: " + Password;

    }


    //If user is Owner --> add, edit, delete bake goods. Will that functionality live here?

    //If user is customer --> Order items, review last order. Will that functionality live here?
}