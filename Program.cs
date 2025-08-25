using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OCRDashboard
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ExtractTessData();

            ApplicationConfiguration.Initialize();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void ExtractTessData()
        {
            string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "tessdata");
            Directory.CreateDirectory(outputDir);

            string resourceName = "OCRDashboard.Resources.eng.traineddata";
            string outputPath = Path.Combine(outputDir, "eng.traineddata");

            if (File.Exists(outputPath)) return;

            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    MessageBox.Show("Не удалось найти встроенный ресурс: " + resourceName);
                    return;
                }

                using (FileStream fileStream = new FileStream(outputPath, FileMode.Create))
                {
                    stream.CopyTo(fileStream);
                }
            }
        }
    }
}
