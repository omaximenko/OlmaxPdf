using System;
using System.IO;
using PDFiumCore;

namespace OlmaxPdf
{
    class PdfFileWriteCopyStream : FPDF_FILEWRITE_
    {
        public Stream WriteStream { get; }

        public PdfFileWriteCopyStream(Stream writeStream)
        {
            WriteStream = writeStream;
            WriteBlock = CopyToStream;
        }

        private unsafe int CopyToStream(IntPtr pthis, IntPtr pdata, ulong size)
        {
            if (size > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "Block size exceeds maximum supported stream length.");
            }

            var reader = new UnmanagedMemoryStream((byte*) pdata, (long)size);
            reader.CopyTo(WriteStream);
            return 1;
        }
    }
}
