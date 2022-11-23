using System;

namespace HelloWorld
{
public class Vector
{
   public double X;
   public double Y;
   public double Z;
    public Vector(double _x,double _y, double _z)
    {
        X = _x;
        Y = _y;
        Z = _z;
    }
    public void show()
    {
        
        Console.Write(X >= 0 ? $"{X}x" :$"{X}x");
        Console.Write(Y >= 0 ? $"+{Y}y" :$"{Y}y");
        Console.Write(Z >= 0 ? $"+{Z}z" :$"{Z}z");
        Console.WriteLine();
    }
    public static Vector operator+(Vector v1, Vector v2)
    {
        return new Vector((double)(v1.X + v2.X),(double)(v1.Y + v2.Y), v1.Z + v2.Z);
    }
    public static Vector operator*(Vector v1, double s2)
    {
        return new Vector (v1.X * s2, v1.Y * s2, v1.Z * s2);
    }
    public static Vector operator*(Vector v1, Vector v2)
    {
    return new Vector(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
    }
    public static bool operator==(Vector v1, Vector v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
    }
    public static bool operator!=(Vector v1, Vector v2)
    {
        return v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z;
    }
}
    public class Program
    {
        public static void Main(string[] args)
        {
            Vector v1 = new Vector(2,3,4);
            Console.Write("V1: ");
            v1.show();
            Vector v2 = new Vector(2,-3,-9);
            Console.Write("V2: ");
            v2.show();
            Vector v3 = v1+v2;
            Console.Write("Added V3: ");
            v3.show();
            Vector v4 = v1*5;
            Console.Write("Multiplied V4 by Scalar: ");
            v4.show();
            Vector v5 = v1*v2;
            Console.Write("Cross Product V5: ");
            v5.show();
            Console.WriteLine($"Is V1==v2: {v1==v2}");
            Vector v6 = new Vector(2,-3,-9);
            Console.WriteLine($"Is V6==v2: {v6==v2}");
        }
    }
}