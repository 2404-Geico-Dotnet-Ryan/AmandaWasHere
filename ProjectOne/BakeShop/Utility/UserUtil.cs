class UserUti
{
    public Dictionary<string, User> logins;

    public int idCounter = 1;

    // //Constructor to give us menu options to start:
    public UserUti()
    {
        logins = []; //sets the dictionary to an empty collection, instead of at the top, 
        //moving it into the constructor

    }
}