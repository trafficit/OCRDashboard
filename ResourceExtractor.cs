using System.IO;
using System.Reflection;

public static class ResourceExtractor
{
    public static void ExtractTessData()
    {
        string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "tessdata");
        Directory.CreateDirectory(outputDir);

        string resourceName = "OCRDashboard.Resources.eng.traineddata"; // проверь имя!
        string outputPath = Path.Combine(outputDir, "eng.traineddata");

        using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
        using (FileStream fileStream = new FileStream(outputPath, FileMode.Create))
        {
            stream.CopyTo(fileStream);
        }
    }
}
