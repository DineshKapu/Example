using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Csharp
{
    class InstanceVSStatic
    {
        int mydata; //non static menber
        static int ourdata=15; //static member for the entire class
        float floatdata;
        string str;
        public void Display() //non static instance menber
        {
            Console.WriteLine(str);
        }
        public static void accessFunction()
        {
            InstanceVSStatic instobj1 = new InstanceVSStatic();
            instobj1.mydata = 5;
            InstanceVSStatic instobj2 = new InstanceVSStatic();
            instobj2.mydata = 10;
            Console.WriteLine(instobj1.mydata + " " + instobj2.mydata);
            instobj1.mydata = 100;
            Console.WriteLine(instobj1.mydata + " " + instobj2.mydata);

            //InstanceVSStatic.ourdata = 10;
            Console.WriteLine("Static data {0}",ourdata);

            InstanceVSStatic.ourdata = 25;
            Console.WriteLine("Static data {0}", ourdata);

            Console.WriteLine("********");
            instobj1.str = "I am object1";
            instobj1.Display();
            instobj2.str = "I am object2";
            instobj2.Display();

        }
        static void Main()
        {
            //InstanceVSStatic.ourdata = 20;
            //Console.WriteLine(InstanceVSStatic.ourdata);
            //InstanceVSStatic.accessFunction();

            // strings and its working
            string str;
            str = "I am a string";
            Console.WriteLine(str);
            Console.WriteLine("str for the first time is :{0}", str.GetHashCode());

            string str2 = "I am a String";
            Console.WriteLine("str2 is :{0}", str2.GetHashCode());
            Console.WriteLine(str2);

            string str3=str;
            Console.WriteLine(str3);
            Console.WriteLine("str3 is :{0}", str3.GetHashCode());
            char[] cArray = new char[] { 'A', 'E', 'I', 'O', 'U' };
            string s4 = new string(cArray);
            /*
             //String Reverse
            string s4 = "EVE";
            Console.WriteLine("str4 is :{0}", s4.GetHashCode());
            char[] cArray = s4.ToCharArray();
            string s5 = string.Empty;
            for(int i=cArray.Length-1;i>=0;i--)
            {
                s5 += cArray[i];
            }
            Console.WriteLine(s5);
            Console.WriteLine("str5 is :{0}", s5.GetHashCode());*/

            Console.WriteLine("----String Builder");

            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("hashcode of sb: {0} and value of sb :{1}", sb.GetHashCode(),sb);
            sb.Append(" World");
            Console.WriteLine("hashcode of sb: {0} and value of sb :{1}", sb.GetHashCode(), sb);
            

            Console.Read();
        }
    }
}
