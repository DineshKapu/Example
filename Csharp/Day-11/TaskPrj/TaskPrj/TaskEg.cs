using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPrj
{
    class TaskEg
    {
        static async Task Main()
        {
            Console.WriteLine("Starting Async Operation...");
            await AnotherAsyncOperation();
            Console.WriteLine("Async Operations Completed...");
            Console.Read();
        }
        static async Task AnotherAsyncOperation()
        {
            await Task.Delay(2000);
            Console.WriteLine("Operation in Progress...");
        }

    }
}
