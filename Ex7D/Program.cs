using System;
using System.Collections.Generic;
using System.Collections;

namespace Ex7D
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            int ch = 0;
            do
            {
                Console.Write("1. Count\n2. Enqueue\n3. Dequeue\n4. Peek\n5. Contains\n6. Clear\n");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(q.Count);
                        break;
                    case 2:
                        int data = int.Parse(Console.ReadLine());
                        q.Enqueue(data);
                        break;
                    case 3:
                        Console.WriteLine(q.Dequeue());
                        break;
                    case 4:
                        Console.WriteLine(q.Peek());
                        break;
                    case 5:
                        Console.WriteLine(q.Contains(int.Parse(Console.ReadLine())));
                        break;
                    case 6:
                        q.Clear();
                        break;
                }
                Console.Write("Enter 1 to exit! or 0 to continue");
                ch = int.Parse(Console.ReadLine());
            }while (ch!=1);
        }
    }
}