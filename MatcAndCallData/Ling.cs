using System;

public class Ling
{
    // check data
    public string folder = "Data";
    public void checkDir()
    {
        if (!Directory.Exists(folder)){
            Console.WriteLine($"Directory: {folder} it is nut exists");
        }else if (Directory.Exists(folder))
        {
            Console.WriteLine(folder);
        }
        
    }

    // comparison data with name and password return false or true 

    //show data 

    // accept data 

}