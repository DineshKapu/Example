using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Csharp
{
    class ControlStatements
    {
        #region
        static void Main()
        {
            ControlStatements cs = new ControlStatements();
            //char retgrade=cs.CheckGrade();
            //Console.WriteLine("The Grade is:{0}",retgrade);
            //OR
            //Console.WriteLine(cs.CheckGrade());
            //cs.CheckGrade_with_Switch();
            IterationStatements loops = new IterationStatements();
            loops.WhileLoop();
            Console.WriteLine("*****");
            loops.DoWhileLoop();
            Console.WriteLine("*****");
            loops.ForLoop();
            Console.WriteLine("*****");
      
            loops.ForEachLoop();
            Console.Read();
        }
        #endregion
        #region
        public char CheckGrade() 
        { 
          char grade;
          Console.WriteLine("Enter your Grade:");
           grade = Convert.ToChar(Console.ReadLine());
           if(grade=='O' || grade == 'o')
            {
                Console.WriteLine("Outstanding");
            }
           else if(grade=='A' || grade == 'a')
            {
                Console.WriteLine("Excellent");
            }
            else if (grade == 'B' || grade == 'b')
            {
                Console.WriteLine("Very Good");
            }
            else if (grade == 'C' || grade == 'c')
            {
                Console.WriteLine("Fair");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            return grade;
        }
        #endregion
        /// <summary>
        ///     The below Function works on multiple switch Claues
        /// </summary>
        public void CheckGrade_with_Switch()
        {
            char grade;
            Console.WriteLine("Enter the Grade:");
            grade = Convert.ToChar(Console.ReadLine().ToUpper());
            switch(grade)
            {

                case 'O':
                    Console.WriteLine("Outstanding");
                    break;
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Vey Good");
                    break;
                case 'C':
                    Console.WriteLine("Fair");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }
        }
    }
   
    class IterationStatements
    {
        public void WhileLoop()
        {
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <=5);
        }

        public void ForLoop()
        {
            int tot = 0;
            int i = 0;
            for(;i<=5;i++)
            {
                tot += i;
            }
            Console.WriteLine("Sum of all numbers:{0}", tot);
        }
        public void ForEachLoop()
        {
            int[] data = new int[] { 76, 4, 12, 0, 3 };
            Console.WriteLine(data.Length);
            Console.WriteLine("--Before Sort---");
            foreach(int x in data)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---After Sort----");
            Array.Sort(data);
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }

        }
    }
}
