using System;

public class User
{
    public string name{get; set;}
    public string password{get; set;}
    public User(string Name, string PassWord)
    {
        name =Name;
        password = PassWord;
    }

}