using WordConverter.Formats;

namespace WordConverter;

public class WordApplication
{
    public IWordDesktopDocument Document { get; set; } = null!;

    public void DisplayDocument()
    {
        Console.WriteLine("Displaying the document...");
        Document.Display();
    }
    
    public void SaveDocument(string fileLocation)
    {
        Document.SaveDocxTo(fileLocation);
    }
}