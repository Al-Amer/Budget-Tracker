using System;

public class CRUD
{
    public string folder = "Data";
    public string userDate = "userData.txt";
    public string userAktion = "userLogin.txx";

    public bool check_userdata_file()
    {
        // check if the file exists in the configured folder and return the result
        string path = System.IO.Path.Combine(folder, userDate);
        return System.IO.File.Exists(path);
    }
    public bool check_userAktion_file()
    {
        // check if the file exists in the configured folder and return the result
        string path = System.IO.Path.Combine(folder, userDate);
        return System.IO.File.Exists(path);
    }
    public string readFile()
    {
        string path = System.IO.Path.Combine(folder, userDate);
        if (check_userdata_file())
        {
            string text = File.ReadAllText(path);   
            return text;
        }
        else
        {
            return "No File";
        }
    }
    public void create_file()
    {
        string path = System.IO.Path.Combine(folder, userDate);
        File.Create(path);
        Console.WriteLine("File created ");
    }
    public string write_file(string d1, string d2, string d3)
    {
        string path = System.IO.Path.Combine(folder, userDate);
        if (check_userdata_file())
        {
            using (var writer = new StreamWriter(path, append:true))
            {
                writer.WriteLine($"{d1},{d2},{d3}");
            }
            return "File written";
        }
        else
        {
    
            File.WriteAllText(path, $"{d1},{d2},{d3}");
            
            return "Create File \nFile written";
        }
    }
    public string pa()
    {
        string path = System.IO.Path.Combine(folder, userDate);
        return path;
    }



}