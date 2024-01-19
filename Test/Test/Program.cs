using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTest dt = new DateTest();
            dt.Test();
            TextTest tt = new TextTest();
            tt.Test();
            NumberTest nt = new NumberTest();
            nt.Test();




            Console.ReadLine();
        }
    }
}
