namespace WordConverter.Formats;

public interface IWordDesktopDocument
{
    /// <summary>
    /// Save the Word Desktop document to the specified file location, using the
    /// DOCX format as the package container.
    /// </summary>
    /// <param name="location"></param>
    public void SaveDocxTo(string location);

    /// <summary>
    /// Display the document to the screen.
    /// </summary>
    public void Display();
}