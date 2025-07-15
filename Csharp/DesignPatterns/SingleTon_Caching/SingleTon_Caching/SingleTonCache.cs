using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_Caching
{
    public sealed class SingleTonCache : IMyCache
    {
        //since shared resources have to be Protected in a multithreaded Environment
        //we can use ConcurrentDictionary Collection which enables thread safety
        private ConcurrentDictionary<object, object> cd = new ConcurrentDictionary<object, object>();

        //object for storing singlrton instnce
        private static readonly SingleTonCache singleobj = new SingleTonCache();

        //Private Constructor
        private SingleTonCache()
        {
            Console.WriteLine("SingleTon Instance Created..");
        }

        //Providing static methods for instantiation and return the Singleton Object
        public static SingleTonCache GetInstance()
        {
            return singleobj;
        }
        //The below method will add a key and a values to the cache
        public object Add(object key, object value)
        {
            if (cd.TryAdd(key, value))
            {
                return value;
            }
            else
                return null;
        }
        //the below method will Check the key,if found updates the value,else add value

        public object AddOrUpdate(object key, object value)
        {
            //if (cd.ContainsKey(key))
            //{
            //    cd.TryRemove(key, out object removedvalue);
            //}
            //return cd.TryAdd(key, value);

            //if (cd.ContainsKey(key))  // If the key already exists...
            //{
            //    cd[key] = value;      // ...just update its value
            //}
            //else
            //{
            //    cd.TryAdd(key, value); // Otherwise, add it to the dictionary
            //}
            //return true;
            return cd.AddOrUpdate(key, value, (k, oldValue) => value);
        }

        //the below method will return a value of a specified key if found,else null
        public object Get(object key)
        {
            if (cd.ContainsKey(key))
            {
                return cd[key];
            }
            return null;
        }
        //The below methoad will remove a key and its value from the cache
        public bool Remove(object key)
        {
            return cd.TryRemove(key, out object removedval);
        }
        //one instance Methoad
        public void Clear()
        {
            cd.Clear();
        }
        public ConcurrentDictionary<object, object> GetAll()
        {
            return cd;
        }
    }
}
