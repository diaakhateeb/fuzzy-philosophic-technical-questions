using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philosophy_Technical_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 7;
            int j = 8;
            var x = new int[] { 9 };
            object y = new int[] { 10 };

            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:m:s:ms"));
            Console.WriteLine("i " + i);
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:m:s:ms"));
            Console.WriteLine("j " + j);
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:m:s:ms"));
            Console.WriteLine("x " + x[0]);
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:m:s:ms"));
            var q = y as int[];
            Console.WriteLine(q[0]);
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy:m:s:ms"));

            Console.ReadLine();
        }
    }
}
