using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Adapter
{

    public class DesignerAdapter: Programmer
    {
      Designer designer;
      public DesignerAdapter(Designer designer)
      {
      	this.designer = designer;
      }
      public void WriteCode()
      {
        designer.DesignSome();
      }
      public void Achievements()
      {
        designer.Achievements();
      }
    }
}