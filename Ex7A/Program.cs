using System;
using System.Collections;
namespace Ex7A 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            Console.WriteLine("Enter the no of elements to push in stack");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for(int i=0;i<n;i++){
                int inp = int.Parse(Console.ReadLine());
                s.Push(inp);
            }
            int ch;
            do
            {
            Console.WriteLine("Menu:\n 1: Count 2: peek 3: Push 4: Pop 5: Exit\n");
            ch = int.Parse(Console.ReadLine());
            if(ch == 1 ){
                Console.Write("Number of Elements in Stack is ");
                Console.WriteLine(s.Count);
            }
            else if(ch == 2){
                if(s.Count>0)
                {
                Console.Write("The Top Element is ");
                Console.WriteLine(s.Peek());
                }
                else{
                    Console.WriteLine("Stack is empty!");
                }
            }
            else if(ch == 3){
                Console.Write("Enter The element to be Pushed: ");
                int ele = int.Parse(Console.ReadLine());
                s.Push(ele);
            }
            else if(ch == 4 )
            {
                if(s.Count>0)
                {
                Console.Write("Poped Element ");
                Console.WriteLine(s.Peek());
                s.Pop();
                }
                else{
                    Console.WriteLine("Stack is empty!");
                }
            }
            }while(ch != 5);
        }
    }
}