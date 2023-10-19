using WordConverter;
using WordConverter.Adapters;
using WordConverter.Formats;

// Loading the file from Word Online
using var onlineDocumentStream = File.OpenRead("example.html");
var onlineDocument = new WordOnlineDocument(onlineDocumentStream);

// "Opening" the application
var app = new WordApplication
{
    Document = new WordOnlineAdapter(onlineDocument)
};

var outputFile = "output.docx";
app.SaveDocument(outputFile);
Utilities.OpenFileWithDefaultProgram(outputFile);
