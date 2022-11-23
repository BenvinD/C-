using System;
using System.Text.RegularExpressions;
class validate{
    public void chk_username(string s){
        var match = Regex.Match(s , @"\b[a-z]+\b");
        if(match.ToString() == s){
        Console.WriteLine("valid username");
        }
        else
        Console.WriteLine("Invalid Username");
    }
    public void chk_accno(string s){
        var match = Regex.Match(s , @"\w*\d{1,}\w*");
        if(match.ToString() == s){
        Console.WriteLine("valid accno");
        }
        else
        Console.WriteLine("Invalid accno");
    }
    public void chk_email(string s){
        var match = Regex.Match(s ,@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        if(match.ToString() == s){
        Console.WriteLine("valid email id");
        }
        else
        Console.WriteLine("Invalid email id");
    }
    public void chk_phno(string s){
        var match = Regex.Match(s ,@"^([0]|\+91)?[7896]\d{9}$");
        if(match.ToString() == s){
        Console.WriteLine("valid phone no");
        }
        else
        Console.WriteLine("Invalid phone no");
    }
}
namespace MyApp 
{
internal class Program
{
static void Main(string[] args)
{
int choice;
Console.WriteLine("Bank Application form validation");
do{
    Console.WriteLine("1. check username\n2. check account no\n3. check email id\n4. check phone no\n5. Exit");
    choice = int.Parse(Console.ReadLine());
    validate v = new validate();
    if(choice == 1){
        Console.WriteLine("Enter Username : ");
        string name = Console.ReadLine();
        v.chk_username(name);
    }
    else if(choice == 2){
        Console.WriteLine("Enter Account no : ");
        string accno = Console.ReadLine();
        v.chk_accno(accno);
    }
    else if(choice == 3){
        Console.WriteLine("Enter email id : ");
        string email = Console.ReadLine();
        v.chk_email(email);
    }   
    else if(choice == 4){
        Console.WriteLine("Enter phone no : ");
        string phno = Console.ReadLine();
        v.chk_phno(phno);
    } 
}while(choice != 5);
}
}
}