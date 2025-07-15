﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Csharp
{
    class ExceptionFiltersEg
    {
        static void Main()
        {
            try
            {
                int[] a = new int[3];
                a[6] = 5;
                int number = 0;
                int x = 5 / number;
            }
        
            catch(DivideByZeroException) when (DateTime.Now.DayOfWeek!=DayOfWeek.Friday)
            {
                Console.WriteLine("Will not catch as it is Friday");
            }
            catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("Hurray it is Friday");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("hi");
            }
            catch (Exception e) when (e.GetType().ToString()=="System.IndexOutOfRangeException")
            {
                SomeOtherTask();
            }
        
        Console.Read();
        }
        public static void SomeOtherTask()
        {
            Console.WriteLine("A nes is being executed....");
        }
    }
}
