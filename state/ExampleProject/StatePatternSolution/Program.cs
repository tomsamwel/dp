using StatePattern;
using StatePattern.Tools;

Canvas Canvas = new Canvas();

Canvas.CurrentToolState = Canvas.BrushTool;
Canvas.CurrentToolState.MouseDown();
Canvas.CurrentToolState.MouseUp();

Canvas.CurrentToolState = Canvas.SelectionTool;
Canvas.CurrentToolState.MouseDown();
Canvas.CurrentToolState.MouseUp();

Canvas.CurrentToolState = Canvas.FillTool;
Canvas.CurrentToolState.MouseDown();
Canvas.CurrentToolState.MouseUp();