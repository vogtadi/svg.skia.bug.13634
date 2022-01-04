using System.IO;
using SkiaSharp;
using Svg.Skia;

namespace Lib_Common
{
    public class MyConverter
    {
        public static byte[] SVGToPNG(byte[] svgData)
        {
            using (var svg = new SKSvg())
            {
                using (var inputStream = new MemoryStream(svgData))
                {
                    svg.Load(inputStream);
                }

                using (var outputStream = new MemoryStream())
                {
                    svg.Picture.ToImage(outputStream, SKColor.Empty, SKEncodedImageFormat.Png, 100, 1f, 1f, SKColorType.Bgra8888, SKAlphaType.Premul, SKColorSpace.CreateSrgb());

                    return outputStream.ToArray();
                }
            }
        }
    }
}
