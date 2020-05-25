using ExpertPdf.HtmlToPdf;
using ExpertPdf.HtmlToPdf.PdfDocument;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ReportPDF.Model
{
    public class ExpertPdf
    {
        public byte[] pdf(System.Text.StringBuilder head)
        {
            PdfConverter pdfConverter = new PdfConverter();
            Document pdfDocument = pdfConverter.GetPdfDocumentObjectFromHtmlString(head.ToString());
            MemoryStream pdfStream = new MemoryStream();
            return pdfDocument.Save();
        }
    }
}
