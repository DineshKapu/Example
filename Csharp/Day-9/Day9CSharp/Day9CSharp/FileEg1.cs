using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Day9CSharp
{
    [Serializable]
    class Customer
    {
        public int CID;
        public string CustName;
        [NonSerialized]
        public float CustRating;
    }
    class FileEg1
    {
        public static void Main()
        {
            Customer customer = new Customer() { CID = 101, CustName = "Dinesh",CustRating=4.5f};
            //customer.CID = 101;
            //customer.CustName = "Dinesh";


            //IFormatter or Binary Formatter
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(@"C:\\Example\\Csharp\\Day-9\SecondFile.txt",FileMode.Create,FileAccess.Write);  //FilePath:" C:\\Example\\Csharp\\Day-9" or @"C:\Example\Csharp\Day-9""

            formatter.Serialize(stream,customer);
            stream.Close();

            Console.WriteLine("--------------Reading From File--------------------");

            stream = new FileStream(@"C:\\Example\\Csharp\\Day-9\SecondFile.txt", FileMode.Open, FileAccess.Read);
            Customer dcust = (Customer)formatter.Deserialize(stream);
            Console.WriteLine(dcust.CID + " " + dcust.CustName+" "+dcust.CustRating);
            Console.Read();
        }
    }
}
