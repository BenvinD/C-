using System;
    public class Bank
    {
        public int acc_number;
        public double acc_bal;
        public string acc_own_name;
        public Bank(int ac,double ac_bal,string acc_name)
        {
            acc_number = ac;
            acc_bal = ac_bal;
            acc_own_name = acc_name;
        }
    }
    public abstract class Account : Bank
    {
        public int _ac;
        public double min_bal;
        public string accname;
        public Account(int ac, double ac_bal, string accname):base(ac,ac_bal,accname)
        {
            _ac = ac;
            min_bal = ac_bal;
            accname = accname;
        }
        public abstract void CalculateBankCharge();
        public abstract void Debit(double amt);
        public abstract void Credit(double amt);
        public abstract void ChangeName(string name);
        public abstract void Display();
    }
    public class SavingsAccount: Account
    {
        double min_bal;
        public SavingsAccount(int ac, double ac_bal, string accname, double min):base(ac,ac_bal,accname)
        {
            min_bal = min;
        }
        public override void Debit(double amt)
        {
            if(base.acc_bal-amt>this.min_bal)
            base.acc_bal-=amt;
            else
            Console.WriteLine("Goes beyond Min Balance");
        }
        public override void Credit(double amt)
        {
            base.acc_bal+=amt;
        }
        public override void Display()
        {
            Console.WriteLine("Account Name: " + base.acc_own_name);
            Console.WriteLine("Account Number: " + base.acc_number);
            Console.WriteLine("Account Balance: " + base.acc_bal);
        }
        public override void CalculateBankCharge()
        {
        double interest_rate = 0.05;
        double rate = base.acc_bal * (interest_rate / 100);
        Console.WriteLine("Bank Interest : " + rate);
        }
        public override void ChangeName(string s)
        {
            base.acc_own_name = s;
        }
    }
    public class CurrentAccount : Account
    {
        double min_bal;
        public CurrentAccount(int ac, double ac_bal, string accname, double min):base(ac,ac_bal,accname)
        {
            min_bal = min;
        }
        public override void Debit(double amt)
        {
            if(base.acc_bal-amt>this.min_bal)
            base.acc_bal-=amt;
            else
            Console.WriteLine("Goes beyond Min Balance");
        }
        public override void Credit(double amt)
        {
            base.acc_bal+=amt;
        }
        public override void Display()
        {
            Console.WriteLine("Account Name: " + base.acc_own_name);
            Console.WriteLine("Account Number: " + base.acc_number);
            Console.WriteLine("Account Balance: " + base.acc_bal);
        }
        public override void CalculateBankCharge()
        {
        double interest_rate = 0;
        double rate = base.acc_bal;
        Console.WriteLine("Bank Interest : " + rate);
        }
        public override void ChangeName(string s)
        {
            base.acc_own_name = s;
        }
    }
    sealed class Manage: Account
    {
        public override void Debit(double amt)
        {
            if(base.acc_bal-amt>base.min_bal)
            base.acc_bal-=amt;
            else
            Console.WriteLine("Goes beyond Min Balance");
        }
        public override void Credit(double amt)
        {
            base.acc_bal+=amt;
        }
        public override void Display()
        {
            Console.WriteLine("Account Name: " + base.acc_own_name);
            Console.WriteLine("Account Number: " + base.acc_number);
            Console.WriteLine("Account Balance: " + base.acc_bal);
        }
        public override void CalculateBankCharge()
        {
        double rate = base.acc_bal;
        Console.WriteLine("Bank Interest : " + rate);
        }
        public override void ChangeName(string s)
        {
            base.acc_own_name = s;
        }
        int _ac;
        double bal;
        string accname;
        public Manage(int ac, double ac_bal, string accname):base(ac,ac_bal,accname)
        {
            _ac = ac;
            bal = ac_bal;
            accname = accname;
        }

    }

namespace HelloWorld
{
internal class Program
{
static void Main(string[] args)
{
int choice;
List<SavingsAccount> arlist = new List<SavingsAccount>();
do{
Console.WriteLine("--------------------");
Console.WriteLine("Menu");
Console.WriteLine("1. Create an account");
Console.WriteLine("2. Check your savings");
Console.WriteLine("3. Credit amount");
Console.WriteLine("4. Debit amount");
Console.WriteLine("5. Account Statement");
Console.WriteLine("6. Exit");
Console.WriteLine("Enter your choice");
choice = int.Parse(Console.ReadLine());
Console.WriteLine("--------------------");
int accno;
switch(choice){
    case 1:
            Console.WriteLine("Create Account");
            Console.WriteLine("Enter your account number");
            accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name of account holder");
            string name = Console.ReadLine();
            Console.WriteLine("Enter initial amount");
            double balance = int.Parse(Console.ReadLine());
            arlist.Add(new SavingsAccount(accno,balance,name,0));
            break;
    case 2:
            Console.WriteLine("Enter your account number");
            accno = int.Parse(Console.ReadLine());
            arlist[accno-1].Display();
            break;
    case 3:
            Console.WriteLine("Enter your account number");
            accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount you want to credit");
            int credamt = int.Parse(Console.ReadLine());
            arlist[accno-1].Credit(credamt);
            break;
    case 4:
            Console.WriteLine("Enter your account number");
            accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount you want to withdraw");
            int wthamt = int.Parse(Console.ReadLine());
            arlist[accno-1].Debit(wthamt);
            break;
    case 5:
            Console.WriteLine("Enter your account number");
            accno = int.Parse(Console.ReadLine());
            arlist[accno-1].Display();
            break;
}
}while(choice != 6);
}
}
}
