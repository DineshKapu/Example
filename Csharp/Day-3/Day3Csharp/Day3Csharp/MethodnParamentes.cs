using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Csharp
{
    class MethodnParamentes
    {
        //by value
         public static void SimpleValueMethod(int j)//we have copy
        {
            j = 100;
            Console.WriteLine(" J's value is " + j);
        }

        //by refernce
        public static void SimpleRefMethod(ref int j) //we have refernce,i am receving the address
        {
            j = 100;
            Console.WriteLine(" J's value is " + j);
        }

        //using out

        public static int Calculator(int n1,int n2,out int sum,out int product,out int subtraction,out int division)

        {
            sum = n1 + n2;
            product = n1 * n2;
            subtraction = n1 - n2;
            division = n1 / n2;
            return (n1 * n2)*n1;
        }

        //parameter array-1
        public static int AddElements(params int[]arr)
        {
            int sum = 0;
      
            foreach(int n in arr)
            {
                sum += n;
            }
            return sum;
        }

        //parameter array-2
        public static void ParamsMethod(params int[] number)
        {
            Console.WriteLine($"The length of an array: {number.Length}");
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Tester
    {
        static void Main()
        {
            int i = 10;
            MethodnParamentes.SimpleValueMethod(i);
            Console.WriteLine("I's value is {0} ",i);
            Console.WriteLine("____________________________");
            MethodnParamentes.SimpleRefMethod(ref i);
            Console.WriteLine("I's value is {0}", i);
            Console.WriteLine("______________With OUT parameters_____________");
            int total, prod,pro,dif,di;
            prod=MethodnParamentes.Calculator(5, 4,out total,out pro,out dif,out di);
            Console.WriteLine($"Sum: {total}, Product: {pro}, Difference: {dif}, Division : {di}, SomMulti: {prod}");
            Console.WriteLine("____________Parameter Array-1___________");
            Console.WriteLine(MethodnParamentes.AddElements());
            Console.WriteLine(MethodnParamentes.AddElements(5,6,2));
            Console.WriteLine(MethodnParamentes.AddElements(10,20,30,40,50));

            Console.WriteLine("____________Parameter Array-2___________");
            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            MethodnParamentes.ParamsMethod(); //0 arguments
            MethodnParamentes.ParamsMethod(num); //array argument
            MethodnParamentes.ParamsMethod(1,2,3,4,5,6,7); // coma sepated values
            Console.Read();
        }
    }
}
