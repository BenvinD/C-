using System;

class Man
{
    public string name;
    public int age;
    public Man(int age, string name)
    {
        this.name = name;
        this.age = age;
    }
}
class Employee: Man
{
    public int emp_id;
    public double emp_salary;

    public Employee(int id, double salary,string name,int age):base(age,name)
    {
        emp_id = id;
        emp_salary = salary;
    }
    public void Print()
    {
        Console.WriteLine("Emp ID:      " + emp_id      );
        Console.WriteLine("Emp Name:    " + name        );
        Console.WriteLine("Emp Salary:  " + emp_salary  );
        Console.WriteLine("Emp Age:     " + age         );
    }
    static void Main(string[] args)
    {
        List<Employee> arlist = new List<Employee>();
        int choice;
        do{
        Console.WriteLine("Menu");
        Console.WriteLine("1. Add Employee");
        Console.WriteLine("2. View Employee");
        Console.WriteLine("3. Edit Employee");
        Console.WriteLine("4. Remove Employee");
        Console.WriteLine("5. Exit");
        Console.WriteLine("Enter your choice");
        choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
                    Console.WriteLine("Enter Employee name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Employee ID:");
                    int e_id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Employee Salary:");
                    double salary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Employee Age:");
                    int age = int.Parse(Console.ReadLine());
                    arlist.Add(new Employee(e_id,salary,name,age));
                    break;
            case 2:
                    Console.WriteLine("Enter Employee ID:");
                    e_id = int.Parse(Console.ReadLine());
                    bool flag = true;
                    for(int i=0;i<arlist.Count;i++)
                    {
                        if(arlist[i].emp_id == e_id)
                        {
                            arlist[i].Print();
                            flag = false;
                        }
                    }
            if(flag)
            Console.WriteLine("Employe Not Found");
                    break;
            case 3:
            Console.WriteLine("Enter Employee ID:");
            e_id = int.Parse(Console.ReadLine());
            flag = true;
            for(int i=0;i<arlist.Count;i++)
            {
                if(arlist[i].emp_id == e_id)
                {
                Console.WriteLine("Enter Employee name:");
                arlist[i].name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                arlist[i].emp_salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Age:");
                arlist[i].age = int.Parse(Console.ReadLine());
                flag = false;
                }
            }
            if(flag)
            Console.WriteLine("Employee Not Found");
            break;
            case 4:
            Console.WriteLine("Enter Employee ID:");
            e_id = int.Parse(Console.ReadLine());
            for(int i=0;i<arlist.Count;i++)
            {
                if(arlist[i].emp_id == e_id)
                {
                    arlist.RemoveAt(i);
                }
            }
            break;
        }
    }while(choice!=5);
}
}