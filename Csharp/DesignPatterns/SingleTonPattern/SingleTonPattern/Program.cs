using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingleTonClass trainer = SingleTonClass.GetInstance();
            //trainer.Show("Working with Single Object Instance..");
            ////let us create another Instance
            //SingleTonClass trainee = SingleTonClass.GetInstance();
            //trainee.Show("Working with Single Object Instance..");

            //SingleTonClass manager = SingleTonClass.GetInstance();
            //manager.Show("Invoking the object for the third time...");

            SingleTonClass teacher = SingleTonClass.GetInstance();
            teacher.Show("This is from the Teacher..");
            SingleTonClass student = SingleTonClass.GetInstance();
            student.Show("This is from the Student..");

            //instantiating the nested class
            SingleTonClass.DerivedSingleTon derivedobj = new SingleTonClass.DerivedSingleTon();
            derivedobj.Show("This is from Derived Object of the SingleTon..");
            Console.Read();
        }
    }
}
