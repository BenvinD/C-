using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Passing Down Two Values:");
      int ans = calculator.adds(a,b);
      Console.WriteLine("Add: "+ans);
      ans = calculator.sub(a,b);
      Console.WriteLine("Sub: "+ans);
      ans = calculator.mul(a,b);
      Console.WriteLine("Mul: "+ans);
      ans = calculator.div(a,b);
      Console.WriteLine("Div: "+ans);
      Console.WriteLine("Passing Down Three Values:");
      ans = calculator.adds(a,b,c);
      Console.WriteLine("Add: "+ans);
      ans = calculator.sub(a,b,c);
      Console.WriteLine("Sub: "+ans);
      ans = calculator.mul(a,b,c);
      Console.WriteLine("Mul: "+ans);
      ans = calculator.div(a,b,c);
      Console.WriteLine("Div: "+ans);
      Console.WriteLine("Passing Down Six Values:");
      ans = calculator.adds(a,b,c,d,e,f);
      Console.WriteLine("Add: "+ans);
      ans = calculator.sub(a,b,c,d,e,f);
      Console.WriteLine("Sub: "+ans);
      ans = calculator.mul(a,b,c,d,e,f);
      Console.WriteLine("Mul: "+ans);
      ans = calculator.div(a,b,c,d,e,f);
      Console.WriteLine("Div: "+ans);
        }
    }
    public class calculator
    {
      public static int adds(params int[] ListNumbers)
        {
          int total = 0;
          foreach(int i in ListNumbers) 
        {
            total += i;
        }
        return total;
        }
        public static int sub(params int[] ListNumbers)
        {
          int total = ListNumbers[0];
          for(int i = 1;i<ListNumbers.Length;i++) 
        {
            total -= ListNumbers[i];
        }
        return total;
        }
        public static int mul(params int[] ListNumbers)
        {
          int total = 1;
          foreach(int i in ListNumbers) 
        {
            total *= i;
        }
        return total;
        }
        public static int div(params int[] ListNumbers)
        {
          int total = ListNumbers[0];
          for(int i = 1;i<ListNumbers.Length;i++) 
        {
            total /= ListNumbers[i];
        }
        return total;
        }
    }
}