using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using HtmlAgilityPack;
using WordConverter.Formats;

namespace WordConverter.Adapters;

public class WordOnlineAdapter : IWordDesktopDocument
{
    private readonly WordOnlineDocument _onlineDocument;

    public WordOnlineAdapter(WordOnlineDocument document)
    {
        _onlineDocument = document;
    }

    public void Display()
    {
        Console.WriteLine("This is a Word Online document (emulated as an Office Open XML document)");
    }
    
    public void SaveDocxTo(string location)
    {
        Console.WriteLine("Saving file...");
        
        var htmlElement = _onlineDocument.Document.DocumentNode.Element("html");
        var bodyElement = htmlElement.Element("body");

        var desktopDocument = new Document();
        var desktopBody = desktopDocument.AppendChild(new Body());
        foreach (var htmlParagraph in bodyElement.ChildNodes)
        {
            var child = CreateOfficeNodeForHtmlNode(htmlParagraph);
            if (child is Paragraph)
            {
                desktopBody.AppendChild(child);                
            }
        }
        
        using var stream = File.Create(location);
        using var wordProcessingDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
        var mainPart = wordProcessingDocument.AddMainDocumentPart();
        mainPart.Document = desktopDocument;
        
        desktopDocument.Save();
        wordProcessingDocument.Save();
        Console.WriteLine($"Saved Online document (as Office Open XML) to: {stream.Name}");
    }

    private Paragraph CreateParagraph(HtmlNode htmlParagraph)
    {
        var officeParagraph = new Paragraph();
            
        foreach (var htmlNode in htmlParagraph.ChildNodes)
        {
            officeParagraph.AppendChild(CreateOfficeNodeForHtmlNode(htmlNode));
        }

        return officeParagraph;
    }

    private OpenXmlCompositeElement? CreateOfficeNodeForHtmlNode(HtmlNode htmlNode)
    {
        return htmlNode.Name switch
        {
            "p" => CreateParagraph(htmlNode),
            "#text" => CreateText(htmlNode),
            "b" => CreateBold(htmlNode),
            "i" => CreateItalic(htmlNode),
            "h1" => CreateHeading(htmlNode, "36"),
            "h2" => CreateHeading(htmlNode, "32"),
            "h3" => CreateHeading(htmlNode, "26"),
            "center" => CreateCenter(htmlNode),
            "font" => CreateFont(htmlNode),
            "a" => CreateAnchor(htmlNode),
            _ => null,
        };
    }

    private Run CreateText(HtmlNode node)
    {
        return new Run(new Text(node.InnerText)
        {
            Space = SpaceProcessingModeValues.Preserve
        });
    }

    private Run CreateBold(HtmlNode node)
    {
        var run = new Run();

        var properties = run.AddRunProperties();
        properties.Bold = new Bold
        {
            Val = new OnOffValue(true)
        };
                
        run.AppendChild(new Text(node.InnerText));

        return run;
    }

    private Run CreateItalic(HtmlNode node)
    {
        var run = new Run();

        var properties = run.AddRunProperties();
        properties.Italic = new Italic
        {
            Val = new OnOffValue(true)
        };
                
        run.AppendChild(new Text(node.InnerText));

        return run;
    }

    private Run CreateFont(HtmlNode node)
    {
        var run = new Run();

        var properties = run.AddRunProperties();
        properties.RunFonts = new()
        {
            Ascii = node.GetAttributeValue("face", null),
        };
        
        properties.Color = new Color()
        {
            Val = ParseColor(node.GetAttributeValue("color", null))
        };

        properties.FontSize = ParseFontSize(node.GetAttributeValue("size", null));
                
        run.AppendChild(new Text(node.InnerText));

        return run;
    }

    private Paragraph CreateCenter(HtmlNode node)
    {
        var officeParagraph = new Paragraph();
        officeParagraph.ParagraphProperties = new()
        {
            Justification = new Justification
            {
                Val = JustificationValues.Center
            }
        };
            
        foreach (var htmlNode in node.ChildNodes)
        {
            officeParagraph.AppendChild(CreateOfficeNodeForHtmlNode(htmlNode));
        }

        return officeParagraph;
    }

    private Paragraph CreateHeading(HtmlNode node, string size)
    {
        var paragraph = new Paragraph();
        var run = paragraph.AppendChild(new Run());

        var properties = run.AddRunProperties();
        properties.FontSize = new FontSize()
        {
            Val = size
        };
                
        run.AppendChild(new Text(node.InnerText));

        return paragraph;
    }

    private string? ParseColor(string? input)
    {
        if (input is null)
            return null;
        
        return input switch
        {
            "red" => "FF0000",
            "green" => "00FF00",
            "blue" => "0000FF",
            "black" => "000000",
            "white" => "FFFFFF",
            _ => null,
        };
    }

    private FontSize? ParseFontSize(string? input)
    {
        if (input is null)
            return null;
        try
        {
            // Font sizes in Office Open XML are multiplied by two, for some reason.
            var fontSizeNormalized = int.Parse(input) * 2;
            
            return new FontSize()
            {
                Val = fontSizeNormalized.ToString(),
            };
        }
        catch
        {
            return null;
        }
    }

    private Hyperlink CreateAnchor(HtmlNode node)
    {
        var href = node.GetAttributeValue("href", null);
        var link = new Hyperlink()
        {
            DocLocation = href,
            Anchor = href,
        };

        foreach (var child in node.ChildNodes)
        {
            link.AppendChild(CreateOfficeNodeForHtmlNode(child));
        }

        return link;
    }
}