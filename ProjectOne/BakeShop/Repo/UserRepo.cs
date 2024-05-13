class UserRepo

{
    UserUtil login = new();

    public User AddUser(User u)
    {
        u.Id = login.idCounter++;

        login.logins.Add(u.Id, u);
        return u;
    }
    public User? ViewUser(int id)
    {
        if (login.logins.ContainsKey(id))
        {
            User selectedUser = login.logins[id];
            return selectedUser;
        }
        else
        {
            Console.WriteLine("You have not registered.");
            return null;
        }
    }

    //VIEW ALL
    public List<User> GetAllUsers()
    {
        return [.. login.logins.Values];
    }

    public User? UpdateUser(User u)
    {
        try
        {
            login.logins[u.Id] = u;
            return u;
        }
        catch (Exception)
        {
            Console.WriteLine("You have not registered.");
            return null;
        }

    }
    public User? DeleteUser(User u)
    {
        bool didRemove = login.logins.Remove(u.Id);

        if (didRemove)
        {
            return u;
        }
        else
        {
            Console.WriteLine("You have not registered.");
            return null;
        }
    }

}