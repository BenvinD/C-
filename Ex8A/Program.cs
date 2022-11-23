using System.Threading;
using System;
class Program
{
int amt = 2500;
static void Main(string[] args)

{
Console.WriteLine("Banking Application");
Program p = new Program();
p.startthreads();
}
public void startthreads()
{
    Thread t1 = new Thread(new ThreadStart(withdrawal));
    Thread t2 = new Thread(new ThreadStart(deposit));
    t1.Name = "Withdraw Thread";
    t2.Name = "Deposit Thread";
    int c = 0;
    do{
        Console.WriteLine("1. Withdraw");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Enter Your Choice: ");
        c = int.Parse(Console.ReadLine());
        switch(c){
            case 1: 
                t1.Start();
                t1.Join();
                break;
            case 2:
                t2.Start();
                t2.Join();
                break;
            case 3: 
                Console.WriteLine("Done");
                break;
            default:
                Console.WriteLine("Enter a valid choice");
                break;
        }
    }while(c!=3);
}
public void withdrawal()
{
Monitor.Enter(this);
{
    Console.WriteLine("{0} started", Thread.CurrentThread.Name);
    Console.WriteLine("Thread Priority:" + Thread.CurrentThread.Priority);
    Console.WriteLine("The amount to be withdrawn: ");
    int bal = int.Parse(Console.ReadLine());
    if (bal > amt)
        Console.WriteLine("Not enough cash");
    else
    {
        amt = amt - bal;
        Console.WriteLine("The amount is {0}", amt);
    }
}
Monitor.Exit(this);
}
public void deposit()
{
Monitor.Enter(this);
{
    Console.WriteLine("{0} started", Thread.CurrentThread.Name);
    Console.WriteLine("Thread Priority:" + Thread.CurrentThread.Priority);
    Console.WriteLine("The amount to be Deposit: ");
    int dep = int.Parse(Console.ReadLine());
    amt += dep;
    Console.WriteLine("The amount is {0}", amt);
}
Monitor.Exit(this);
}
}
