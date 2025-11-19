using System;

public class Registierung : User
{
    public string registerTiem { get; private set; }
    public string birthday {get;}
    public Registierung(string Name, string PassWord, string Birthday) : base(Name, PassWord)
    {
        birthday = Birthday;
        this.registerTiem = DateTime.Now.ToString("MM/dd/yyyy");
    }
        public void regterSave()
    {
        try
        {   
            

            Console.WriteLine($"Name : {name} ,Password :  {password} ,registerTiem :  {registerTiem} ,birthday : {birthday}");
        }
        catch(Exception e)
        {
            Console.WriteLine($" Error : {e}");
        }

    }

    
}