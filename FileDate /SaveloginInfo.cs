using System;
using System.Text.Json;

public class SaveloginInfo: DataMethods
{
    public string folder = "Data";
    public string userAktion = "userLogin.json";
    public void create_file()
    {
        string path = System.IO.Path.Combine(folder, userAktion);
        File.Create(path);
        Console.WriteLine($"File {userAktion} it is created ");
    }
    public bool check_exists_file()
    {
        return true;
    }
    public void add_data(User user)
    {
        
    }
    public List<User> Call_data()
    {
        string path = System.IO.Path.Combine(folder, userAktion);
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }
    public  void read_file()
    {
        
    }
    
}