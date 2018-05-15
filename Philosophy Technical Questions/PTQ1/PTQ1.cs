using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philosophy_Technical_Questions.PTQ1
{
    class PTQ1
    {
        public void WhatIsTheDiff()
        {
            var i = 7;
            int j = 8;
            var x = new int[] { 9 };
            object y = new int[] { 10 };
            int[] z = new int[] { 11 };

            Console.WriteLine("i " + i);
            Console.WriteLine("j " + j);
            Console.WriteLine("x " + x[0]);
            Console.WriteLine((y as int[])[0]);
            Console.WriteLine(z[0]);

            Console.ReadLine();
        }
    }
}
