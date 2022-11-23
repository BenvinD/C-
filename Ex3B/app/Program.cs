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
        return new Vector((v1.X + v2.X),(v1.Y + v2.Y), v1.Z + v2.Z);
    }
    public static Vector operator-(Vector v1, Vector v2)
    {
        return new Vector((v1.X - v2.X),(v1.Y - v2.Y), v1.Z - v2.Z);
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
            Console.Write("Enter Value for Vector V1 X:");
            double X1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Value for Vector V1 y:");
            double Y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Value for Vector V1 Z:");
            double Z1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Value for Vector V2 X:");
            double X2 = double.Parse(Console.ReadLine());
            Console.Write("Enter Value for Vector V2 y:");
            double Y2 = double.Parse(Console.ReadLine());
            Console.Write("Enter Value for Vector V2 Z:");
            double Z2 = double.Parse(Console.ReadLine());
            Vector v1 = new Vector(X1,Y1,Z1);
            Vector v2 = new Vector(X2,Y2,Z2);
int choice;
do{
Console.WriteLine("1. Vector Addition");
Console.WriteLine("2. Vector Subtraction");
Console.WriteLine("3. Vector Multiplication");
Console.WriteLine("4. Vector Scalar Multiplication");
Console.WriteLine("5. Comparison");
Console.WriteLine("6. Exit");
Console.WriteLine("Enter your choice");
choice = int.Parse(Console.ReadLine());
switch(choice){
    case 1:
    Vector sum = v1 + v2;
    Console.Write("First Vector: ");
    v1.show();
    Console.Write("Second Vector: ");
    v2.show();
    Console.Write("The sum of the two numbers: ");
    sum.show();
    break;
    case 2:
    Vector diff = v1 - v2;
    Console.Write("First Vector: ");
    v1.show();
    Console.Write("Second Vector: ");
    v2.show();
    Console.Write("The difference of the two numbers: ");
    diff.show();
    break;
    case 3:
    Vector product = v1 * v2;
    Console.Write("First Vector: ");
    v1.show();
    Console.Write("Second Vector: ");
    v2.show();
    Console.Write("The product of the two vectors: ");
    product.show();
    break;
    case 4:
    Console.WriteLine("Enter your scalar value:");
    int v = int.Parse(Console.ReadLine());
    Vector quotient = v1*v;
    Console.Write("Vector: ");
    v1.show();
    Console.Write("The product of the vector and scalar: ");
    quotient.show();
    break;
    case 5:
    Console.Write("First Vector: ");
    v1.show();
    Console.Write("Second Vector: ");
    v2.show();
    Console.WriteLine($"The two vectors are equal:{v1==v2}");
    Console.WriteLine($"The two vectors not equal:{v1!=v2}");
    break;
}
}while(choice != 6);
}
}
}