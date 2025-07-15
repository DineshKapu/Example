using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_Caching
{
    class Client
    {
        static void Main(string[] args)
        {
            //Obtaing a singleton instance
            SingleTonCache cache = SingleTonCache.GetInstance();

            //1.Add Some Data to the cache
            Console.WriteLine("Adding Keys and Values to the Cache---");
            Console.WriteLine($"Adding EID_1 as Key to the cache: {cache.Add("EID_1",101)}");
            Console.WriteLine($"Adding Ename_1 as another key to the cache:{cache.Add("EName_1","Dinesh")}");

            Console.WriteLine($"Adding EID_2 as Key to the cache: {cache.AddOrUpdate("EID_2", 102)}");
            Console.WriteLine($"Adding Ename_2 as another key to the cache:{cache.AddOrUpdate("EName_2", "Mahohar")}");

            Console.WriteLine($"Adding EID_3 as Key to the cache: {cache.AddOrUpdate("EID_3", 103)}");
            Console.WriteLine($"Adding Ename_3 as another key to the cache:{cache.AddOrUpdate("EName_3", "Jaya")}");

            //2.Retrive Data From the Cache
            Console.WriteLine($"Fetching data from the Collction");
            Console.WriteLine($"Getting employee ID_1 from theCache :{cache.Get("EID_1")}");
            Console.WriteLine($"Getting employee Name_1 from theCache :{cache.Get("EName_1")}");

            Console.WriteLine("Iterating through all cached items:");
            foreach (var item in cache.GetAll())
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            //4.removing a key
            Console.WriteLine("Removing key from cache");

            Console.WriteLine($"Removing ID 101:{cache.Remove("EID_1")}");
            foreach (var item in cache.GetAll())
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            //3.calling add or update
            //Console.WriteLine($"Adding the existing the key to check AddOrUpdate():{cache.AddOrUpdate("EID",102)}");

            //4.removing a key
            //Console.WriteLine("Removing key from cache");

            //Console.WriteLine($"Removing ID 101:{cache.Remove("EID")}");
            ////   Console.WriteLine($"Getting Employee ID from cache : {cache.Get("EID")}");


            //Console.WriteLine("Fetching Data from the collection");
            //Console.WriteLine($"Getting Employee ID from cache : {cache.Get("EID")}");
            //Console.WriteLine($"Getting Employee Name from cache : {cache.Get("EName")}");

            Console.Read();

        }
    }
}
