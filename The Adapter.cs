using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Adapter
{

    public class Program 
    {
        public static void Main()
        {
			JavaDev java1 = new JavaDev();
			
			ThreeDModeller threeD = new ThreeDModeller();
			
			Programmer designerAdapter = new DesignerAdapter(threeD);
			
			DoStuff(java1);
			DoStuff(designerAdapter);
        }
        static void DoStuff(Programmer programmer)
        {
        	programmer.WriteCode();
        	programmer.Achievements();
        }
    }
}