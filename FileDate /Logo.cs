using System;
using System.Text.Json;

public class Logo{
    static string dir = "Data";
    // static string date = DateTimeOffset.Now.ToString("dd-mm-yyyy");
    static DateTimeOffset timeOffset;
    static DateTime datetime => timeOffset.Date;
    static string date = $"{datetime:dd-MM-yyy}";
    static string file = $"{date}.json";
    private string path = System.IO.Path.Combine(dir, file);
    
    public bool check_exists_file()
    {
        return System.IO.File.Exists(path);
    }
    public void add_data( LogoTypes info )
    {
        string dateFiel = DateTimeOffset.Now.ToString("dd-mm-yyyy");
        if (!check_exists_file())
        {
            List<LogoTypes> fileInfo = new List<LogoTypes>
            {
                info
            };
            string jsonone = JsonSerializer.Serialize(fileInfo);
            File.WriteAllText(path, jsonone);
            Console.WriteLine($"Successfully create file and save the data in file at {dateFiel}");
        }
        else
        {
            var file = Call_data();
            file.Add(info);
            string json = JsonSerializer.Serialize(file);
            File.WriteAllText(path, json);
            Console.WriteLine($"Successfully Entry Data to file  {dateFiel}");
        }
    }
    public List<LogoTypes> Call_data()
    {
        // string path = System.IO.Path.Combine(folder, userAktion);
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<LogoTypes>>(json) ?? new List<LogoTypes>();
    }
    public  void read_file()
    {
        Console.WriteLine(string.Join(",",Call_data().ConvertAll(p => $" User : {p.user} , Type :{p.type} , Amount : {p.amount} , Description : {p.description} \n")));

    }
    public void reuslt(string input_name)
    {
        List<LogoTypes> logs = Call_data();
        var userAmount = logs.Where(p => p.user == input_name );
    }

    


}