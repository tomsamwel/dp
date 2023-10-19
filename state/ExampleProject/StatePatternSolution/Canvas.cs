using StatePattern.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Canvas
    {
        public ITool CurrentToolState { get; set; }

        private ITool _selectionTool = new SelectionTool();
        private ITool _brushTool = new BrushTool();
        private ITool _fillTool = new FillTool();

        public ITool SelectionTool { get => _selectionTool; set => _selectionTool = value; }
        public ITool BrushTool { get => _brushTool; set => _brushTool = value; }
        public ITool FillTool { get => _fillTool; set => _fillTool = value; }

        public void mouseDown()
        {
            CurrentToolState.MouseDown();
        }
        public void mouseUp()
        {
            CurrentToolState.MouseUp();
        }
    }
}
