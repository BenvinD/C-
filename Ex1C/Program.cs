using System;
public class Bank{
   int init_amt;
   public Bank(int amt){
       init_amt = amt;
   }
   public void deposit(ref int Deposit_Amount){
       Console.WriteLine("Amount after depositing:");
       Console.WriteLine(init_amt + Deposit_Amount);
   }
  
   public void withdraw(ref int with_amt){
       if(init_amt - with_amt < 0 )
       Console.WriteLine("Insuffiient funds");
       else{
           Console.WriteLine("Amount after Withdrawing:");
           init_amt-=with_amt;
           Console.WriteLine(init_amt - with_amt);
       }
   }
}
class HelloWorld {
 static void Main() {
   Console.WriteLine("Enter the initial amount");
   int amt = int.Parse(Console.ReadLine());
   Bank SBI = new Bank(amt);
   int ch;
   do{
   Console.WriteLine("Enter the operation");
   Console.WriteLine("Menu");
   Console.WriteLine("1. Deposit");
   Console.WriteLine("2. Withdraw");
   Console.WriteLine("3. Exit");
   ch = int.Parse(Console.ReadLine());
   switch(ch){
       case 1:
           Console.WriteLine("Enter the amount to be deposited");
           int Deposit_Amount = int.Parse(Console.ReadLine());
           SBI.deposit(ref Deposit_Amount);
           break;
       case 2:
           Console.WriteLine("Enter the amount to be withdrawed");
           int with_amt = int.Parse(Console.ReadLine());
           SBI.withdraw(ref with_amt);
           break;
       default:
           break;
   }
   }while(ch!=3);
 }
}
