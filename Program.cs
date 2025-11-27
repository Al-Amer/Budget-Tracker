using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using BudgetLogger.Models;
using BudgetLogger.Core;
using BudgetLogger.Models;
using System.Globalization;


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
        bool regiLog = true;
        string user = "";
        string pw = "";
        // string logo_data = "";
            // Transaction type;
        SaveUserData saveUserData = new SaveUserData();
        SaveloginInfo saveloginInfo = new SaveloginInfo();
        Logo logo_json = new Logo();
        while (run_situation){ 
            Console.WriteLine("chois number your situation please\nIf you ready press Ok/y ");
            string answer_1 = Console.ReadLine();
            if (String.IsNullOrEmpty(answer_1) || String.IsNullOrWhiteSpace(answer_1)){
                Console.WriteLine("Please don't press Enter with no Answer");
                break;
            }else if (answer_1 == "ok" || answer_1 == "y"  ){
                // string user;
                // string pw;
                while (regiLog)
                {
                    Console.WriteLine("Register/Login");
                    string choisUser = Console.ReadLine()?.ToLower().Trim();
                    if (choisUser == "register")
                    {
                        Console.WriteLine("UserNameL");
                        user = Console.ReadLine()?.ToLower().Trim();
                        Console.WriteLine("Password");
                        pw = Console.ReadLine()?.ToLower().Trim();
                        Console.WriteLine("Birthday");
                        string birthday = Console.ReadLine()!;
                        Registierung registierung = new Registierung(user, pw, birthday);
                        saveUserData.add_data(registierung);
                        Login login = new Login (user, pw);
                        saveloginInfo.add_data(login);
                        regiLog = false;
                    }else if (choisUser == "login")
                    {
                        Console.WriteLine("UserNameL");
                        user = Console.ReadLine()?.ToLower().Trim();
                        Console.WriteLine("Password");
                        pw = Console.ReadLine()?.ToLower().Trim();
                        Login login = new Login (user, pw);
                        saveloginInfo.add_data(login);
                        regiLog = false;
                    }
                    else
                    {
                        Console.Write("try again please /n but this tie give the wright Anser :");
                    }
                    
                }
                // End of while (regiLog)
                //
                Console.WriteLine($"Logged in as: {user} ");
                //
                // --- 2. Get Transaction Type ---
                TransactionType type;
                while (true)
                {
                    Console.Write("Enter Type (income/expense): ");
                    var typeInput = Console.ReadLine()?.Trim().ToLower();
                    if (typeInput == "income" && Enum.TryParse("Income", true, out type)) break;
                    if (typeInput == "expense" && Enum.TryParse("Expense", true, out type)) break;
                    Console.WriteLine("[ERROR] Invalid type. Please enter 'income' or 'expense'.");
                }
                
                // --- 3. Get Description (for the 'out' part of your example) ---
                string description;
                while (true)
                {
                    Console.Write("Enter Description: ");
                    description = Console.ReadLine()?.Trim() ?? string.Empty;
                    if (!string.IsNullOrWhiteSpace(description)) break;
                    Console.WriteLine("[ERROR] Description cannot be empty.");
                }

                // --- 4. Get Amount ---
                decimal amount;
                while (true)
                {
                    Console.Write("Enter Amount: ");
                    var amountInput = Console.ReadLine();
                    // Use TryParse for robustness (error handling)
                    if (decimal.TryParse(amountInput, NumberStyles.Currency, CultureInfo.CurrentCulture, out amount) && amount > 0)
                    {
                        break;
                    }
                    Console.WriteLine("[ERROR] Invalid amount. Must be a positive number.");
                }

                // --- 5.1  Generate Log File info.log---
                LogGenerator.WriteInfoLog(user, type, amount, description);
                // --- 5.2  Generate Log File date.json---
               
                LogoTypes logoTypes = new LogoTypes(user, type.ToString() , amount ,description );
                logo_json.add_data(logoTypes);


            }
            else
            {
                Console.WriteLine("are you sur you want go out ?? y/n ");
                string input = Console.ReadLine()?.ToLower().Trim();
                if (input == "y")
                {
                    Console.WriteLine("Thank you ");
                    run_situation = false;
                    
                }
            }

        }
        // End of  while (run_situation)



        // Console.WriteLine("UserNameL");
        // string user = Console.ReadLine()?.ToLower().Trim();
        // Console.WriteLine("Password");
        // string pw = Console.ReadLine()?.ToLower().Trim();
        // Console.WriteLine("Birthday");
        // string Birthday = Console.ReadLine()!;
        // string date = DateTime.Now.ToString("MM/dd/yyyy");
        // Registierung registierung = new Registierung(user, pw, Birthday);
            // Login login = new Login(user, pw);
            
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
        // SaveloginInfo saveloginInfo = new SaveloginInfo();
        // saveloginInfo.check_exists_file();
        // saveloginInfo.add_data(login);
        // saveloginInfo.check_exists_file();
        // saveloginInfo.read_file();
        // string folder ="Data";
        // if (Directory.Exists(folder))
        // {
        //     Console.WriteLine($"Dir : {folder} it is exists");
        // }

        //  if (Directory.Exists($"{folder}/{user}"))
        // {
        //     Console.WriteLine($"Dir : {user} it is exists 1");
        //     if (File.Exists($"{folder}/{user}/{user}.json"))
        //     {
        //         Console.WriteLine($"File : {user}.json it is exists 2");
        //     }
        //     else
        //     {
        //         File.Create($"{folder}/{user}/{user}.json");
        //         Console.WriteLine($"File : {user}.json it is created now 3");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine($"Dir : Amer it is nut exists");
        //     string newOne = folder+$"/{user}.json";
        //     Directory.CreateDirectory($"{folder}/{user}");
        //     Console.WriteLine($"Dir : {folder}/{user} it is created Now (((()))) 4");
        //     Console.WriteLine($"file : {user} it is exists 5");
        //     File.Create($"{folder}/{user}/{user}.json");
        //     Console.WriteLine($"File : {user}.json it is created now 6");
        // }







    }
}

// Important 
// ameralmunajjed@Amers-MacBook-Air test % pwd
// /Users/ameralmunajjed/WBS/C_Shapr/test
