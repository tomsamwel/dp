using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selectiontool mouseUp");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selectiontool mouseUp");
        }
    }
}
