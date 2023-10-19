using StatePatternProblem;

Canvas Canvas = new Canvas();
Canvas.toolType = ToolType.Selection;
Canvas.MouseDown();
Canvas.MouseUp();

Canvas.toolType = ToolType.Brush;
Canvas.MouseDown();
Canvas.MouseUp();

Canvas.toolType = ToolType.Eraser;
Canvas.MouseDown();
Canvas.MouseUp();