using HtmlAgilityPack;

namespace WordConverter.Formats;

public class WordOnlineDocument
{
    public HtmlDocument Document { get; } = new();

    public WordOnlineDocument(Stream file)
    {
        Document.Load(file);
    }
}