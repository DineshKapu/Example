using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Day6Sharp
{
    class NonGenericCollection
    {
        public static void ArrayListDemo()
        {
            ArrayList a1 = new ArrayList();
            a1.Add(10);
            a1.Add("hi");
            a1.Add(78.90);
            a1.Add(true);

            Console.WriteLine($"Capacity:{a1.Capacity}");
            Console.WriteLine($"Count:{a1.Count}");
            foreach (var i in a1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"indexof:{a1.IndexOf(2)}");
            a1.RemoveAt(1);
            a1.Add("sai");
            a1.Add(50);
            foreach (var i in a1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Capacity:{a1.Capacity}");
            Console.WriteLine($"Count:{a1.Count}");

        }

        static void HashtableDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Sai", "B");
            ht.Add("John", "A");
            ht.Add("Nithi", "B");
            ht.Add("Shiva", "C");
            //ht.Add(null, "C");
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine("Contains Value"+ht.ContainsValue("A"));//it return boolean value
            //display students from A grade
            foreach(DictionaryEntry i in ht)
            {
                if(i.Value.Equals("A"))
                {
                    Console.WriteLine(i.Key + " " + i.Value);
                }
            }
        }
        
        static void SortedListDemo()
        {
            SortedList st = new SortedList();
            st.Add("Sai", "B");
            st.Add("John", "A");
            st.Add("Nithi", "B");
            st.Add("Shiva", "C");
            //st.Add(null, "C");
            foreach (DictionaryEntry de in st)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

        }
        public static void Main(string[] args)
        {
            //NonGenericCollection.ArrayListDemo();
            NonGenericCollection.HashtableDemo();
            NonGenericCollection.SortedListDemo();
            Console.Read();
        }
    }
}
