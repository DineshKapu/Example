using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9CSharp
{

    //generic delegates example
    public delegate T Trans<T>(T arg);
    public delegate int Arithmetic(int x, int y);
    class Util
    {
        public static void Transform<T>(T[] values,Trans<T>targ)
        {
            for(int i=0;i<values.Length;i++)
            {
                values[i] = targ(values[i]);
            }
        }
      
    }
    class GenericDelegates
    {
        //example for passing delegates as an argument to function
        static void Main()
        {
            DoOperation(10, 2, Multiply);
            DoOperation(10, 2, Divide);

            Console.WriteLine("...................Generic Delegates..............");
            int[] arr = new int[] { 4, 5, 6 };
            Util.Transform(arr,Square);
            foreach(var v in arr)
            {
                Console.Write(v+" ");
            }
            Console.WriteLine();
            float[] arr1 = new float[] { 4.5f, 5.5f, 6.5f };
            Util.Transform(arr1, Square);
            foreach (var v in arr1)
            {
                Console.Write(v + " ");
            }
            Console.Read();

        }

        static int Square(int x)
        {
            return x * x;
        }
        static float Square(float x)
        {
            return x * x;
        }
        public static void DoOperation(int a,int b,Arithmetic adel)
        {
            int z = adel(a,b);
            Console.WriteLine(z);
        }
        static int Multiply(int n1,int n2)
        {
            return n1 * n2;
        }
        static int Divide(int a1,int a2)
        {
            return a1 / a2;
        }
    }
}
