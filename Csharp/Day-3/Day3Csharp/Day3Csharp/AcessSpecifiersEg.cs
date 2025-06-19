using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Csharp
{
    class AcessSpecifiersEg
    {
        private int privatemember;
        public int publicmember;
        protected int protectedmember;
        internal int internalmember;
        internal protected int internalprotectedmember;
        void Allaccessfunction()
        {
            privatemember=1;
            publicmember = 2;
            protectedmember=3;
            internalmember=4;
            internalprotectedmember = 5;
        }
        

        /*
        public static void Main()
        {
            AcessSpecifiersEg aeg = new AcessSpecifiersEg();
            Console.WriteLine(aeg.data);
            aeg.accessibility();
            Console.Read();
        }*/
    }
    class TestAcessibility:AcessSpecifiersEg
    {
        public void CheckAcess()
        {
            AcessSpecifiersEg aeg = new AcessSpecifiersEg();
            aeg.publicmember = 10;
            aeg.internalmember=20;
            aeg.internalprotectedmember = 30;

            TestAcessibility ta = new TestAcessibility();
            ta.publicmember = 100;
            ta.internalmember = 200;
            ta.protectedmember = 300;
            ta.internalprotectedmember = 400;
            
        }
    }
}
