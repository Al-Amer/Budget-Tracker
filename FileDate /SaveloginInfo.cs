using System;
using System.Text.Json;

public class SaveloginInfo 
{
    static string folder = "Data";
    static string userAktion = "userLogin.json";
    static string path = System.IO.Path.Combine(folder, userAktion);

    public bool check_exists_file()
    {
        return System.IO.File.Exists(path);
    }
    public void add_data(Login login)
    {
        if (!check_exists_file())
        {
            List<Login> logins = new List<Login>
            {
                login
            };
            string jsonone = JsonSerializer.Serialize(logins);
            File.WriteAllText(path, jsonone);
            Console.WriteLine("create file and save the Login data in file");
        }
        else
        {
            var file = Call_data();
            file.Add(login);
            string json = JsonSerializer.Serialize(file);
            File.WriteAllText(path, json);
            Console.WriteLine("Login Data it is saved in file ");
        }

    }
  
    public List<Login> Call_data()
    {
        // string path = System.IO.Path.Combine(folder, userAktion);
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<Login>>(json) ?? new List<Login>();
    }
    public  void read_file()
    {
        Console.WriteLine(string.Join(",",Call_data().ConvertAll(p => $" Name : {p.name} , Password :{p.password} , Login Time : {p.loginTiem} \n")));

    }
    
}