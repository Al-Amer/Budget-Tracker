using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;


public class Program
{
    public static void Main()
    {
        string[] situation = ["Login","Registrieren", "Read data"];
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("🛠️ Project Guidelines and Requirements");
        Console.WriteLine("wellcome");
        bool user_situation = false;
        bool regester_situation = false;
        bool run_situation = true;
        // while (run_situation){
        //     Console.WriteLine("chois number your situation please\nIf you ready press Ok/y ");
        //     string answer_1 = Console.ReadLine();
        //     if (String.IsNullOrEmpty(answer_1) || String.IsNullOrWhiteSpace(answer_1)){
        //         Console.WriteLine("Please don't press Enter with no Answer");
        //         break;
        //     }else if (answer_1 == "ok" || answer_1 == "y"  ){
                
        //     }

        // }
        Console.WriteLine("UserNameL");
        string user = Console.ReadLine()!;
        Console.WriteLine("Password");
        string pw = Console.ReadLine()!;
        // Console.WriteLine("Birthday");
        // string Birthday = Console.ReadLine()!;
        // string date = DateTime.Now.ToString("MM/dd/yyyy");
        // Registierung registierung = new Registierung(user, pw, Birthday);
            Login login = new Login(user, pw);
            
        // registierung.regterSave();
        Console.WriteLine("-----------------");
        // Console.WriteLine($"date : {date}");
        // CRUD crud = new CRUD();
        // Console.WriteLine(crud.check_userdata_file());
        Console.WriteLine("-----------------");
        // Console.WriteLine(crud.check_userAktion_file());
        Console.WriteLine("-----------------");
        // Console.WriteLine(crud.readFile());
        // crud.write_file(user, pw, Birthday);
        // Console.WriteLine(crud.pa());
        // Console.WriteLine(crud.readFile());
        // SaveUserData saveUserData = new SaveUserData();
        // Console.WriteLine(saveUserData.check_exists_file());
        // saveUserData.create_file();
        // saveUserData.add_data(registierung);
        // Console.WriteLine(saveUserData.check_exists_file());
        // saveUserData.read_file();
        // saveUserData.read_file();
        SaveloginInfo saveloginInfo = new SaveloginInfo();
        saveloginInfo.check_exists_file();
        saveloginInfo.add_data(login);
        saveloginInfo.check_exists_file();
        saveloginInfo.read_file();





     

    }
}

// Important 
// ameralmunajjed@Amers-MacBook-Air test % pwd
// /Users/ameralmunajjed/WBS/C_Shapr/test
