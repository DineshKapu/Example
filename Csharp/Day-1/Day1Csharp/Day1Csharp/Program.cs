using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConversionFunction();
            //Program prog = new Program();
            //prog.SampleTernary();
            //Console.WriteLine("******");
            //Program.ConversionFunction();
            //TestTryParse.tryParse_Function();
            //TestTryParse.Implicit_Types();
            TestTryParse.NullableEg();
            Console.Read();
        }
        public static void ConversionFunction() //static member or class member
        {
            Console.WriteLine("Min int value is {0}", int.MinValue);
            Console.WriteLine("Max int value is {0}", int.MaxValue);
            int i = 100;
            float f = i; //implict Conversion
            float f2 = 123.75f;
            i = (int)f2;//explict Conversion by typecasting
            Console.WriteLine(i);
            i = Convert.ToInt32(f2);//explict conversion by using Conversion Function
            Console.WriteLine(i);
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks :");
            //float marks = float.Parse(Console.ReadLine());
            float marks = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Num ={0} and Marks={1}",num,marks);
        }
        public void SampleTernary()//non-static menber or instance number
        {
            int num = 10;
            bool b;
            if (num == 10)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            Console.WriteLine("Number ==10 is: {0}", b);
            //using ternary operator
            b = num ==10? true : false;
            Console.WriteLine("Number ==10 is: {0}",b);
        }
  
    }
    class TestTryParse
    {
        public static void tryParse_Function()
        {
            float data = 343456782564.77f;
            int x = (int)data; //int declared its capacity but no exception
            //int x = Convert.ToInt32(data); //exception was raised
           
            Console.WriteLine(x);

            //let us try with tryparse()
            string str = "100"; //string str="100gms"
            //x = int.Parse(str); //throwing an exception
            int result;
            bool status;
            status = int.TryParse(str,out result);
            if(status) //if true
            {
                Console.WriteLine($"Status is {status} and result is {result}");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
            Console.WriteLine(x);
        }
        public static  void Box_unbox()
        {
            int i = 10;
            object obj = i; //boxing

            i = (int)obj; //unboxing

            float percent = Convert.ToSingle(Console.ReadLine());

            string s = "AAA";
            obj = s;//implict
            s =(string)obj;//explict typecast
            s = Convert.ToString(obj);//explicit conversion

        }
        public static void Implicit_Types()
        {
            int x;
            x = 8;
            var v=3.4f;
            Console.WriteLine(v);
            dynamic d;
            d = 5;
            d = "Aa";
            d = false;
            Console.WriteLine(d);
        
        }
        public static void NullableEg()
        {
            string s = null;
            int ? number = 100;//enabling a value type to also have null values
            int total;
            if(number==null)
            {
                total = 0;
            }
            else
            {
                //total = (int)number;//or
                total = number.Value;
            }
            //the above decision clause can be replaced with coalescing operator
            total = number ?? 0;//if number is null ,then it will display 0
            Console.WriteLine(total);
            float ? f = null;
            int ? ticketsonsale = Convert.ToInt32(Console.ReadLine());
            int availabletickets;
            if(ticketsonsale==null)
            {
                availabletickets = 0;
            }
            else
            {
                //availabletickets = (int)ticketsonsale;
                availabletickets = ticketsonsale.Value;
            }
            Console.WriteLine("the available tickets:{0}",availabletickets);
          
        }
    }
}
