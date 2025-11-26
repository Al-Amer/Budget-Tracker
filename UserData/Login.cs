using System;


public class Login : User
{
    public string loginTiem { get; private set; }
    public string id {get; set;}

    public Login(string Name , string PassWord ) : base(Name, PassWord)
    {
        this.loginTiem = DateTimeOffset.Now.DateTime.ToString();
        // id = Id;
    }
    public void regterSave()
    {
        try
        {   
            

            Console.WriteLine($"Name : {name} ,Password :  {password} ,loginTiem :  {loginTiem} , ID: {id}");
        }
        catch(Exception e)
        {
            Console.WriteLine($" Error : {e}");
        }

    }
}