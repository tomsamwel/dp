using System.Diagnostics;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordConverter;

public static class Utilities
{
    public static void OpenFileWithDefaultProgram(string filePath)
    {
        using var process = new Process();
        process.StartInfo.FileName = "explorer";
        process.StartInfo.Arguments = $"\"{filePath}\"";
        process.Start();
    }

    /// <summary>
    /// Add run properties to the given <code>Run</code> node, with some good
    /// defaults.
    /// </summary>
    /// <param name="run"></param>
    /// <returns></returns>
    public static RunProperties AddRunProperties(this Run run)
    {
        var properties = new RunProperties()
        {
            Languages = new Languages()
            {
                Val = "nl-NL"
            }
        };
        
        return run.AppendChild(properties);
    }
}