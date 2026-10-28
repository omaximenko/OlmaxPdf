# OlmaxPdf 

OlmaxPdf is a .NET 8.0, .NET 10 library to handle interactions with PDFs via the PDFium library which is inherently not thread safe.  This library will serialize all calls which are made to the PDFium backend and execute them all on a single thread via a dispatcher.  Results are then returned through Tasks to the calling site.
It is a fork of DtronixPdf.

Supports Linux-x64, OSX-x64, Win-x64, Win-x86.

### Usage

- [Nuget Package](https://www.nuget.org/packages/OmaxPdf).
- Manual building. `dotnet build -c Release`

### Build Requirements
- .NET 8.0, .NET .10

### References

- https://github.com/Dtronix/PDFiumCore
- https://pdfium.googlesource.com/pdfium/
- https://github.com/bblanchon/pdfium-binaries
- https://github.com/mono/CppSharp

### License
[MIT](LICENSE) License