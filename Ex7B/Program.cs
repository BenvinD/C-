using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EX7B
{
    class Evaluvate
    {
        public string inputstr;
        public string answer;
        Stack i = new Stack();
        public void e()
        {
            int a, b, ans;
            for (int j = 0; j < inputstr.Length; j++)
            {
                String c = inputstr.Substring(j, 1);
                if (c.Equals ("*"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb); 
                    b = Convert.ToInt32(sa);
                    ans = a * b;
                    i.Push(ans.ToString());

                }
                else if (c.Equals("/"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a / b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("+"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a + b;
                    i.Push(ans.ToString());

                }
                else if (c.Equals("-"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a - b;
                    i.Push(ans.ToString());

                }
                else
                {
                    i.Push(inputstr.Substring(j, 1));
                }
            }
          answer=(String)i.Pop();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Evaluvate e1 = new Evaluvate();
            Console.WriteLine("Enter any input postfix expression");
            e1.inputstr = Console.ReadLine();
            e1.e();
            Console.WriteLine("\nPostfix Evaluvateluation:  " + e1.answer);
        }
    }
}