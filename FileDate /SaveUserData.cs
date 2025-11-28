using System;
using System.Diagnostics;
using System.Text.Json;

public class SaveUserData : DataMethods
{
    static string folder = "Data";
    static string userDate = "userData.json";
    static string path = System.IO.Path.Combine(folder, userDate);

    public bool check_exists_file()
    {
        return System.IO.File.Exists(path);
    }
    
    public void add_data(Registierung registierung)
    {
        if (!check_exists_file())
        {
            // Console.WriteLine("file nut exsist");
            List<Registierung> regelist = new List<Registierung>
            {
                registierung
            };
            string jsonone = JsonSerializer.Serialize(regelist);
            File.WriteAllText(path, jsonone);
            Console.WriteLine("create file and save the Register data in file");
        }
        else
        {    
            var file = Call_data();
            // Console.WriteLine("read file ");
            // read_file();
            file.Add(registierung);
            // Console.WriteLine();
            string json = JsonSerializer.Serialize(file);

            // Console.WriteLine(json);
            // Console.WriteLine("string json = JsonSerializer.Serialize(file);");
            File.WriteAllText(path, json);
            // Console.WriteLine("File.WriteAllText(product.json, json);");
            Console.WriteLine("Register Data it is saved in file ");
        }
        
    }
    public List<Registierung> Call_data()
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<Registierung>>(json) ?? new List<Registierung>();
        
    }
    public void read_file()
    {
        Console.WriteLine(string.Join(",",Call_data().ConvertAll(p => $"ID: {p.id}, Name : {p.name} , Password :{p.password} , Birthday : {p.birthday}\n")));
    }
     public void registerInfo()
    {
        List<Registierung>  users =Call_data();
        Console.WriteLine(string.Join(",",Call_data().ConvertAll(p => $" Name : {p.name} , Login Time : {p.password} \n")));
    }


}
