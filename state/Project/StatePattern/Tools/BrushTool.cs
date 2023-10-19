using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brushtool mouseUp");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brushtool mouseUp");
        }
    }
}
