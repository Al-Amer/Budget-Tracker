using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;


public class Program
{
    public static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("🛠️ Project Guidelines and Requirements");

        Console.WriteLine("UserNameL");
        string user = Console.ReadLine()!;
        Console.WriteLine("Password");
        string pw = Console.ReadLine()!;
        Console.WriteLine("Birthday");
        string Birthday = Console.ReadLine()!;
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        Registierung registierung = new Registierung(user, pw, Birthday);


        registierung.regterSave();
        Console.WriteLine("-----------------");
        Console.WriteLine($"date : {date}");
        // CRUD crud = new CRUD();
        // Console.WriteLine(crud.check_userdata_file());
        Console.WriteLine("-----------------");
        // Console.WriteLine(crud.check_userAktion_file());
        Console.WriteLine("-----------------");
        // Console.WriteLine(crud.readFile());
        // crud.write_file(user, pw, Birthday);
        // Console.WriteLine(crud.pa());
        // Console.WriteLine(crud.readFile());
        SaveUserData saveUserData = new SaveUserData();
        Console.WriteLine(saveUserData.check_exists_file());
        // saveUserData.create_file();
        saveUserData.add_data(registierung);
        Console.WriteLine(saveUserData.check_exists_file());
        // saveUserData.read_file();
        saveUserData.read_file();




     

    }
}

// Important 
// ameralmunajjed@Amers-MacBook-Air test % pwd
// /Users/ameralmunajjed/WBS/C_Shapr/test
