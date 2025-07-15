﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day11CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using thread Pool
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            }

            //Without Thread Pool
            //for(int i=0;i<10;i++)
            //{
            //    Thread t = new Thread(MyMethod) {Name="Thread"+i};
            //    t.Start();
            //}
            Console.Read();
        }
        public static void MyMethod(object obj)
        {

            Thread thread = Thread.CurrentThread;
            string message = $"Background:{thread.IsBackground},Is it from Pool:" + $"{thread.IsThreadPoolThread},name of the Thread:{thread.Name} and the ThreadId:{thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
