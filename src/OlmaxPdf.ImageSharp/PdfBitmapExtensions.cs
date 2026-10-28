using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;

namespace OlmaxPdf.ImageSharp
{
    public static class PdfBitmapExtensions
    {
        public static unsafe Image<Bgra32> GetImage(this PdfBitmap bitmap)
        {
            var width = bitmap.Width;
            var height = bitmap.Height;
            return Image.WrapMemory<Bgra32>(Configuration.Default, (void*)bitmap.Pointer, width * height * 4, width, height);
        }

    }
}
