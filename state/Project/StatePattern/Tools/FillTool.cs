using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Tools
{
    public class FillTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Filltool mouseDown");
        }

        public void MouseUp()
        {
            Console.WriteLine("Filltool mouseUp");
        }
    }
}
