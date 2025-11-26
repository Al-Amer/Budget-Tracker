using System;

public class Registierung : User
{
    public Guid id {get; set;}
    public string registerTiem { get; private set; }
    public string birthday {get; set; }
    public Registierung(string Name, string PassWord, string Birthday) : base(Name, PassWord)
    {
        birthday = Birthday;
        this.registerTiem = DateTime.Now.ToString("MM/dd/yyyy");
        this.id = Guid.NewGuid();
    }
    public Registierung() : base("", "")
    {
        this.id = Guid.Empty;
    }
    public void regterSave()
    {
        try
        {   
            

            Console.WriteLine($"Name : {name} ,Password :  {password} ,registerTiem :  {registerTiem} ,birthday : {birthday} , ID: {id}");
        }
        catch(Exception e)
        {
            Console.WriteLine($" Error : {e}");
        }

    }

    
}