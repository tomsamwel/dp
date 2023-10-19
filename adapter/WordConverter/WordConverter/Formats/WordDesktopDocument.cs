using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

namespace WordConverter.Formats;

public class WordDesktopDocument : IWordDesktopDocument
{
    public WordprocessingDocument Document { get; set; }

    public WordDesktopDocument(string filePath)
    {
        Document = WordprocessingDocument.Open(filePath, false);
    }

    public void SaveDocxTo(string location)
    {
        using var stream = File.Create(location);
        var fileBackedDocument = Document.Clone(stream);
        fileBackedDocument.Save();
    }

    public void Display()
    {
        Console.WriteLine("This is a Word Desktop document (Office Open XML)");
    }
}