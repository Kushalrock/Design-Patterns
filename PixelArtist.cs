using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Adapter
{

    public class PixelArtist:Designer 
    {
        public void DesignSome()
        {
        	Console.WriteLine("I use pixels for art");
        }
        public void Achievements()
        {
        	Console.WriteLine("Worked in a major game project as the head designer");
        }
    }
}