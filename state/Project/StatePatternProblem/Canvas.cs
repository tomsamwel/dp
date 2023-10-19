using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternProblem
{
    public class Canvas
    {
        public ToolType toolType;

        public void MouseDown()
        {
            switch (toolType)
            {
                case ToolType.Selection:
                    Console.WriteLine("Selectiontool mouseDown");
                    break;
                case ToolType.Brush:
                    Console.WriteLine("Brushtool mouseDown");
                    break;
                case ToolType.Eraser:
                    Console.WriteLine("Eraser mouseDown");
                    break;
                default:
                    Console.WriteLine("Geen Tool geselecteerd");
                    break;
            }
        }
        public void MouseUp()
        {
            switch (toolType)
            {
                case ToolType.Selection:
                    Console.WriteLine("Selectiontool mouseUp");
                    break;
                case ToolType.Brush:
                    Console.WriteLine("Brushtool mouseUp");
                    break;
                case ToolType.Eraser:
                    Console.WriteLine("Eraser mouseUp");
                    break;
                default:
                    break;
            }
        }
    }

    
}
