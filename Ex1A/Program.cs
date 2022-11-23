using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
      int ans = calculator.adds(a,b);
      Console.WriteLine("Add: "+ans);
      ans = calculator.sub(a,b);
      Console.WriteLine("Sub: "+ans);
      ans = calculator.mul(a,b);
      Console.WriteLine("Mul: "+ans);
      ans = calculator.div(a,b);
      Console.WriteLine("Div: "+ans);
        }
    }
    public class calculator
    {
      public static int adds(int a,int b)
        {
          return a+b;
        }
        public static int sub(int a,int b)
        {
          return a-b;
        }
        public static int mul(int a,int b)
        {
          return a*b;
        }
        public static int div(int a,int b)
        {
          return a/b;
        }
    }
}