using System;

public class LogoTypes
{
    public string user{get; set;}
    public string type{get; set;}
    public decimal amount {get; set;}
    public string description {get; set;}

    public LogoTypes(string User, string Type, decimal Amount, string Description)
    {
        user = User ; 
        type = Type ;
        amount = Amount;
        description = Description ;

    }

}