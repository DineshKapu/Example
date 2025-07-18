﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        //Using Expression Bodied
        public Box(double length, double breadth) => (Length, Breadth) = (length, breadth);
        //public static Box Add(Box b1, Box b2) =>
        //                                           (b1 == null || b2 == null)
        //                                           ?throw new ArgumentNullException("Box arguments cannot be null.")
        //                                           :new Box(checked(b1.Length + b2.Length),checked(b1.Breadth + b2.Breadth));
        public static Box operator +(Box b1,Box b2)=>
                                                    (b1 == null || b2 == null)
                                                    ?throw new ArgumentNullException("Box arguments cannot be null.")
                                                    :new Box(checked(b1.Length + b2.Length),checked(b1.Breadth + b2.Breadth));
        public void Display() => Console.WriteLine($"Length: {Length} and Breadth: {Breadth}");
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            try
            {
                double l1,b1,l2, b2;

                Console.Write("Enter Length for Box1: ");
                l1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Breadth for Box1: ");
                b1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Length for Box2: ");
                l2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Breadth for Box2: ");
                b2 = Convert.ToDouble(Console.ReadLine());

                var Box1 = new Box(l1, b1);
                Console.WriteLine("Box 1 details:");
                Box1.Display();

                var Box2 = new Box(l2, b2);
                Console.WriteLine("Box 2 details:");
                Box2.Display();
                var Box3 = Box1 + Box2;
                //var Box3 = Box.Add(Box1, Box2);
                Console.WriteLine("Box 3=> (Sum of Box 1 and Box 2):");
                Box3.Display();
                //Box Box4 = null;
                //var Box5 = Box.Add(Box3, Box4);
                //Box5.Display(); //For Dispalying Error Message
               
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Value overflow occurred during box addition.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            Console.WriteLine("Press Any Key to exit...");
            Console.Read();
        }
    }
}
