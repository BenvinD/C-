using System;

namespace HelloWorld
{
    public class Fuel
    {
        public string state;
        public int cost;

        public Fuel(string s,int c)
        {
            state = s;
            cost = c;
        }
        public void fuelCal(int Fuel_consumed, int c)
        {
            Console.WriteLine("Cose for the Fuel Consumed is "+ Fuel_consumed*c);
        }
    }
    public class TamilNadu : Fuel{
         int liter;
         string fuel_name;
        public void fuelCal()
        {
            Console.WriteLine("Cose for the Fuel Consumed in "+base.state+" is "+ liter*base.cost);
        }
        public TamilNadu(int l,string f_name, string s, int c): base(s,c)
        {
            liter = l;
            fuel_name = f_name;
        }
    }

    public class Kerala : Fuel{
        int liter;
         string fuel_name;
        public void fuelCal()
        {
            Console.WriteLine("Cose for the Fuel Consumed in "+ base.state +" is "+ liter*base.cost);
        }
        public Kerala(int l,string f_name, string s, int c): base(s,c)
        {
            liter = l;
            fuel_name = f_name;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Kerala s1 = new Kerala(50,"BP","Kerala",100);
            s1.fuelCal();
            TamilNadu s2 = new TamilNadu(10,"HP","TamilNadu",50);
            s2.fuelCal();
        }
    }
}