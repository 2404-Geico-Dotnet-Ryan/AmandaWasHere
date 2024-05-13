class UserService
{
    /*Place to keep functionality (starting off with 1:1 since movie app only has one model):
    
    What do we want in our service layer/major functionalities?
    - register
    - user login
    - user logout (?)

    */
    UserRepo ur = new();

    //Register - taking in info and perform a login "registering"
    public User? Register(User u)
    {
        //Not allowing Owner to register (they should be added internally):
        if (u.Role != "Customer")
        {
            Console.WriteLine("Invalid role. Please contact System Coordinator to create your login.");
            return null;
        }
        //Not allowing duplicate User Names:
        //First step, get all users and compare what was entered to what exists
        List<User> allUsers = ur.GetAllUsers();
        foreach (User name in allUsers)
        {
            if (name.UserName == u.UserName)
            {
                Console.WriteLine("User Name already taken. Try again.");
                return null;
            }
        }
        //trivial service if we dont care about validation, or we use the code above with this:
        return ur.AddUser(u);
    }

    //Login
    public User? Login(string userName, string password)
    {
        List<User> allUsers = ur.GetAllUsers();
        foreach (User name in allUsers)
        {
            if (name.UserName == userName && name.Password == password)
            {
                return name; //returning indicates success
            }
        }
        //If we make it this far, there was no match:
        Console.WriteLine("Not a valid user name and/or password.");
        return null;
    }
}