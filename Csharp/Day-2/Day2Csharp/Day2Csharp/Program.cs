using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Csharp
{
    class ArraysEg
    {
        public static void SingleDimension()
        {
            int[] arr = new int[] {42,6,8,35,3 };
            Console.WriteLine("Rank of an array-{0}",arr.Rank);

            foreach(int n in arr)
            {
                Console.Write(" "+n);
            }
        }
        public static void TwoDimension()
        {
            int[,] arr = new int[2, 3] { { 1,2,3},{ 4,5,6} };
            //we sholud use lops to accept and display array values

            // 2 dimensional array will involve 2 loops 

            //option-1

            /*for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }*/

            //option-2
            Console.WriteLine(arr.Length);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //arr[i,j]=Convert.ToInt32(Console.ReadLine());
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static void JaggedArrays()
        {
            //1.declare jagged array of 2 rows
            int[][] myjagg = new int[2][];

            //2.now let us set the size for each row
            //myjagg[0] = new int[] { 2, 4, 6 };
            myjagg[0] = new int[3];
            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1] = new int[2];
            myjagg[1][0] = 1;
            myjagg[1][1] = 3;

            // anothe way of initalization
            int[][] jagg2 =
            {
                new int[]{5,10,15,20 },
                new int[] {25,30},
                new int[] {35,40,45},
                new int[] {50,55},
            };

            // to displaying the jagged array elements
            Console.WriteLine(jagg2.Length);
            for(int i=0;i<jagg2.Length;i++)
            {
                
                Console.WriteLine("Number of elements at Row:" + i + "is" + jagg2[i].Length);

                //inner loop
                for(int j=0;j<jagg2[i].Length;j++)
                {
                    Console.Write(jagg2[i][j] + " ");
                }
                Console.WriteLine();
            }


        }

        //2-D Array
        public static void TwoDim()
        {
            int row, col;
            Console.Write("Enter the number of rows:");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns:");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
        
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }

        }

        public static void JaggArr()
        {
            int row;
            Console.Write("Enter the number of rows:");
            row = Convert.ToInt32(Console.ReadLine());
            int[][] arr1 = new int[row][];
            for(int i=0;i<row;i++)
            {
                Console.WriteLine("Enter the no.of cols in row{0}", i);
                int col = Convert.ToInt32(Console.ReadLine());
                arr1[i] = new int[col];
                for(int j=0;j<col;j++)
                {
                    arr1[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ArraysEg.SingleDimension();
            //Console.WriteLine("**********");
            //ArraysEg.TwoDimension();
            //Console.WriteLine("**********");
            // ArraysEg.JaggedArrays();
            ArraysEg.TwoDim();
            ArraysEg.JaggArr();
            Console.Read();
        }
    }
}
