using System;
using System.Numerics;
using System.Collections.Generic;
public class Complex
{
public int real;
public int imaginary;
public Complex(int real, int imaginary)
{
this.real = real;
this.imaginary = imaginary;
}
public static Complex operator +(Complex c1, Complex c2)
{
return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
}
public static Complex operator -(Complex c1, Complex c2)
{
return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
}
public static Complex operator *(Complex c1, Complex c2)
{
return new Complex((c1.real*c2.real)-(c1.imaginary*c2.imaginary),(c1.real*c2.imaginary)+(c1.imaginary*c2.real));
}
public static Complex operator /(Complex c1, Complex c2)
{
return new Complex(((c1.real*c2.real)+(c1.imaginary*c2.imaginary))/((c2.real*c2.real)+(c2.imaginary*c2.imaginary)),((c1.imaginary*c2.real)-(c1.real*c2.imaginary))/((c2.real*c2.real)+(c2.imaginary*c2.imaginary)));
}
public static bool operator==(Complex c1, Complex c2)
{
return c1.real == c2.real && c1.imaginary == c2.imaginary;
}
public static bool operator!=(Complex c1, Complex c2)
{
return c1.real != c2.real || c1.imaginary != c2.imaginary;
}
public static implicit operator Complex (int value)
{
    return new Complex(value,0);
}
public static implicit operator Int32 (Complex c1)
{
    return (Int16)c1.real;
}
public override string ToString()
{
return(String.Format("{0} + {1}i", real, imaginary));
}
public static void Main()
{
Console.Write("Enter Real Number 1:");
int r1 = int.Parse(Console.ReadLine());
Console.Write("Enter imaginary Number 1:");
int i1 = int.Parse(Console.ReadLine());
Console.Write("Enter Real Number 2:");
int r2 = int.Parse(Console.ReadLine());
Console.Write("Enter imaginary Number 2:");
int i2 = int.Parse(Console.ReadLine());
Complex C1 = new Complex(r1,i1);
Complex C2 = new Complex(r2,i2);
int choice;
do{
Console.WriteLine("1. Complex Addition");
Console.WriteLine("2. Complex Subtraction");
Console.WriteLine("3. Complex Multiplication");
Console.WriteLine("4. Complex Division");
Console.WriteLine("5. Comparison");
Console.WriteLine("6. Casting");
Console.WriteLine("7. Exit");
Console.WriteLine("Enter your choice");
choice = int.Parse(Console.ReadLine());
switch(choice){
    case 1:
    Complex sum = C1 + C2;
    Console.WriteLine("First complex number: {0}",C1);
    Console.WriteLine("Second complex number: {0}",C2);
    Console.WriteLine("The sum of the two numbers: {0}",sum);
            break;
    case 2:
    Complex diff = C1 - C2;
    Console.WriteLine("First complex number: {0}",C1);
    Console.WriteLine("Second complex number: {0}",C2);
    Console.WriteLine("The difference of the two numbers: {0}",diff);
            break;
    case 3:
    Complex product = C1 * C2;
    Console.WriteLine("First complex number: {0}",C1);
    Console.WriteLine("Second complex number: {0}",C2);
    Console.WriteLine("The product of the two numbers: {0}",product);
            break;
    case 4:
    Complex quotient = C1 / C2;
    Console.WriteLine("First complex number: {0}",C1);
    Console.WriteLine("Second complex number: {0}",C2);
    Console.WriteLine("The quotient of the two numbers: {0}",quotient);
            break;
    case 5:
    Console.WriteLine("First complex number: {0}",C1);
    Console.WriteLine("Second complex number: {0}",C2);
    Console.WriteLine("The two numbers equal: {0}",C1==C2);
    Console.WriteLine("The two numbers not equal: {0}",C1!=C2);
            break;
    case 6:
    Console.Write("Enter Number to cast it to complex Number:");
    int val = Int32.Parse(Console.ReadLine());
    Complex C3 = (Complex) val;
    Console.WriteLine("Casted complex number: {0}",C3);
    int val2 = (int)C2;
    Console.WriteLine("Casted integer number: {0}",val2);
            break;
}
}while(choice != 7);
}
}