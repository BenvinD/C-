using System;
namespace HelloWorld{
    delegate Matrix MatrixDelegate(Matrix a, Matrix b);
    public delegate void Eventlogger();
    class Matrix{
        public int[,] mat;
        public Matrix(int[,] a)
        {     
            mat = a;
        }
        public void show()
        {
            for(int i=0;i<mat.GetLength(0);i++)
            {
                for(int j=0;j<mat.GetLength(1);j++)
                {
                    Console.Write(mat[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        public Matrix add(Matrix a,Matrix b)
        {
                int[,] arr = new int[a.mat.GetLength(0),a.mat.GetLength(1)];
                Matrix tmp = new Matrix(arr);
                for(int i=0;i<mat.GetLength(0);i++)
                {
                    for(int j=0;j<mat.GetLength(1);j++)
                    {
                        tmp.mat[i,j] = a.mat[i,j]+b.mat[i,j];
                    }
                }
                return tmp;
        }
        public Matrix sub(Matrix a,Matrix b)
        {
                int[,] arr = new int[a.mat.GetLength(0),a.mat.GetLength(1)];
                Matrix tmp = new Matrix(arr);
                for(int i=0;i<mat.GetLength(0);i++)
                {
                    for(int j=0;j<mat.GetLength(1);j++)
                    {
                        tmp.mat[i,j] = a.mat[i,j]-b.mat[i,j];
                    }
                }
                return tmp;
        }
        public Matrix mul(Matrix a,Matrix b)
        {
                int[,] arr = new int[a.mat.GetLength(0),b.mat.GetLength(1)];
                Matrix tmp = new Matrix(arr);
                for(int i=0;i<mat.GetLength(0);i++)
                {
                    for(int j=0;j<mat.GetLength(1);j++)
                    for(int k=0;k<mat.GetLength(1);k++)
                    {
                        tmp.mat[i,j] += a.mat[i,k]*b.mat[k,j];
                    }
                }
                return tmp;
        }
    }
    class Program
    {
        public static event Eventlogger alert;
        static void log()
        {
            Console.WriteLine("MisMatched Index.Try Again");
        }
        public static void Main()
        {
            int[,] trr = new int[3,3];
            Matrix opp = new Matrix(trr);
            MatrixDelegate opa = opp.add;
            MatrixDelegate ops = opp.sub;
            MatrixDelegate opm = opp.mul;
            int choice;
            Console.WriteLine("Enter the number of row for Matrix1: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of col for Matrix1: ");
            int c = int.Parse(Console.ReadLine());
            int[,] arr = new int[r,c];
            Console.WriteLine("Enter the number of Matrix1: ");
            for(int i=0;i<r;i++)
                for(int j=0;j<c;j++)
                    arr[i,j]=int.Parse(Console.ReadLine());
            Matrix a = new Matrix(arr);
            a.show();
            Console.WriteLine("Enter the number of row for Matrix2: ");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of col for Matrix2: ");
            int c1 = int.Parse(Console.ReadLine());
            int[,] brr = new int[r,c];
            Console.WriteLine("Enter the number of Matrix2: ");
            for(int i=0;i<r;i++)
                for(int j=0;j<c;j++)
                    brr[i,j]=int.Parse(Console.ReadLine());
            Matrix b = new Matrix(brr);
            Console.WriteLine("1. Matrix Addition");
            Console.WriteLine("2. Matrix Subtraction");
            Console.WriteLine("3. Matrix Multiplication");
            Console.WriteLine("4. Change Matrix");
            Console.WriteLine("5. Exit");
            do{
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:
                int[,] srr = new int[a.mat.GetLength(0),a.mat.GetLength(1)];
                Matrix sum = new Matrix(srr);
                if(a.mat.GetLength(0)!=b.mat.GetLength(0) || a.mat.GetLength(1)!=b.mat.GetLength(1))
                {
                    alert += new Eventlogger(log);
                    alert.Invoke();
                    alert -= new Eventlogger(log);
                }
                else
                {
                sum = opa(a,b);
                Console.WriteLine("Sum:");
                sum.show();
                }
                break;
                case 2:
                int[,] drr = new int[a.mat.GetLength(0),a.mat.GetLength(1)];
                Matrix dif = new Matrix(drr);
                if(a.mat.GetLength(0)!=b.mat.GetLength(0) || a.mat.GetLength(1)!=b.mat.GetLength(1))
                {
                    alert += new Eventlogger(log);
                    alert.Invoke();
                    alert -= new Eventlogger(log);
                }
                else
                {
                dif = ops(a,b);
                Console.WriteLine("Difference:");
                dif.show();
                }
                break;
                case 3:
                int[,] prr = new int[a.mat.GetLength(0),b.mat.GetLength(1)];
                Matrix pro = new Matrix(prr);
                if(a.mat.GetLength(0)!=b.mat.GetLength(1))
                {
                    alert += new Eventlogger(log);
                    alert.Invoke();
                    alert -= new Eventlogger(log);
                }
                else
                {
                pro = opm(a,b);
                Console.WriteLine("Product:");
                pro.show();
                }
                break;
                case 4:
                Console.WriteLine("Enter the number of row for Matrix1: ");
                r = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of col for Matrix1: ");
                 c = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of Matrix1: ");
                for(int i=0;i<r;i++)
                    for(int j=0;j<c;j++)
                        arr[i,j]=int.Parse(Console.ReadLine());
                a = new Matrix(arr);
                a.show();
                Console.WriteLine("Enter the number of row for Matrix2: ");
                r1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of col for Matrix2: ");
                c1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of Matrix2: ");
                for(int i=0;i<r;i++)
                    for(int j=0;j<c;j++)
                        brr[i,j]=int.Parse(Console.ReadLine());
                b = new Matrix(brr);
                break;
            }
            }while(choice!=5);
            }
    }
}