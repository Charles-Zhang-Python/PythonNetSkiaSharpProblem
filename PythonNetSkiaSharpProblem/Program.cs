using SkiaSharp;

namespace PythonNetSkiaSharpProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var info = new SKImageInfo(width: 64, height: 64);
                using var surface = SKSurface.Create(info);
                SKCanvas canvas = surface.Canvas;
                canvas.Clear(new SKColor(red: 0, green: 200, blue: 200, alpha: 255));
                using SKImage image = surface.Snapshot();
                using SKData pngData = image.Encode(SKEncodedImageFormat.Png, quality: 100);
                const string outputPath = "filled64.png";
                using var stream = File.OpenWrite(outputPath);
                pngData.SaveTo(stream);

                System.Console.WriteLine($"Saved {outputPath}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }   
        }
    }
}
