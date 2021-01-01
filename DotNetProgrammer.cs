using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Adapter
{

    public class DotNetProgrammer : Programmer 
    {
        public void WriteCode()
        {
        	Console.WriteLine("I program C# and other dot net applications");
        }
        public void Achievements()
        {
        	Console.WriteLine("Microsoft Certified dot net developer 2018");
        }
    }
}