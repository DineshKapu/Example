using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day10CSharp
{
    //file Info and Directory info classes
    class Fileseg2
    {
        static void Main()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Example\TestDir");
            if(dinfo.Exists)
            {
                Console.WriteLine("Directory by  the name already exists....");
            }
            else
            {
                dinfo.Create();
                Console.WriteLine("New Directory Created...");
            }
            Console.WriteLine("-------------Iterating the subdirectories of the given Directory------");
            DirectoryInfo di = new DirectoryInfo(@"C:\Example\Csharp");
            if(di.Exists)
            {
                DirectoryInfo[] subdirs = di.GetDirectories();

                foreach(object obj in subdirs)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
            else
            {
                Console.WriteLine("The Given Directory Doesn't exist");
            }

            Console.WriteLine("------------files from a directory-----------");
            FileInfo[] finfo = di.GetFiles();
            foreach(FileInfo f in finfo)
            {
                Console.WriteLine("File Name:{0} Size:{1}",f.FullName,f.Length);
            }
            Console.Read();
        }
    }
}
