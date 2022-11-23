using System;
class Employee{
   List<string> emp = new List<string>{"Benvin","Yuta","Luffy"};
   public void emp_exist(string e){
       try{
           int st = 0;
           for(int i=0;i<emp.Count();i++){
           if(emp[i] == e)
           {
               st = 1;
               Console.WriteLine("Employee Exists");
           }
           if(i == emp.Count()-1 && st == 0)
           throw new NoEmployeeException();        
       }
       }
       catch(NoEmployeeException err){
           Console.WriteLine("ERROR: " + err);
       }
   }

   public void hire_emp(string e){
        try{
           emp.Add(e);
           throw new HireEmployeeException();
       }
       catch(HireEmployeeException err){
           Console.WriteLine("ERROR: "+ err);
       }
   }
   public void fire_emp(string e){
       try{
           emp.Remove(e);
           throw new FireEmployeeException();
       }
       catch(FireEmployeeException err){
           Console.WriteLine("ERROR: "+ err);
       }
   }
}
class NoEmployeeException:ApplicationException{
public override string Message{
get{
   return string.Format("Employee does not exist");
}
}
}
class HireEmployeeException:ApplicationException{
public override string Message{
get{
   return string.Format("Employee Hired");
}
}
}
class FireEmployeeException:ApplicationException{
public override string Message{
get{
   return string.Format("Employee Fired");
}
}
}
namespace Solution
{
internal class Program
{
static void Main(string[] args)
{

Console.Write("Employee Management system");
int ch;
do{
Console.WriteLine("Menu\n1.exmployee exists\n2.hire employee\n3.fire employee\n4.Exit");
ch = int.Parse(Console.ReadLine());
Employee e = new Employee();
if(ch==1){
string st;
Console.WriteLine("Enter name of Employee");
st = Console.ReadLine();
e.emp_exist(st);
}
else if(ch == 2){
string st;
Console.WriteLine("Enter Employee to be Hired");
st = Console.ReadLine();
e.hire_emp(st);
}
else if(ch == 3){
string st;
Console.WriteLine("Enter Employee to be Fired");
st = Console.ReadLine();
e.fire_emp(st);
}
}while(ch!=4);
}
}
}
