using System;
using System.Text.Json;

public class SaveUserData : DataMethods
{
    public string folder = "Data";
    public string userDate = "userData.json";
    public void create_file()
    {
        string path = System.IO.Path.Combine(folder, userDate);
        File.Create(path);
        Console.WriteLine($"File {userDate} it is created ");
    }
    public bool check_exists_file()
    {
        string path = System.IO.Path.Combine(folder, userDate);
        return System.IO.File.Exists(path);
    }
    
    public void add_data(User user)
    {
        string path = System.IO.Path.Combine(folder, userDate);
        // if (check_exists_file())
        // {
        //     using (var writer = new StreamWriter(path, append:true))
        //     {
        //         writer.WriteLine($"{d1},{d2},{d3}");
        //     }
        //     return "File written";
        // }
        // else
        // {
    
        //     File.WriteAllText(path, $"{d1},{d2},{d3}");
            
            // return "Create File \nFile written";
        // }
    }
    public List<User> Call_data()
    {
        string path = System.IO.Path.Combine(folder, userDate);
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }
    public void read_file()
    {

    }
    public int ID()
    {
        return 0;
    }
}