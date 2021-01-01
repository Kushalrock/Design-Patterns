using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Adapter
{

    public class JavaDev: Programmer
    {
        public void WriteCode()
        {
        	Console.WriteLine("I like to program in Java.");
        }
        public void Achievements()
        {
        	Console.WriteLine("Free Code Camp completed all the assignmemts");
        }
    }
}