using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportPDF.Model
{
    public class PdfGenerator
    {
        public byte[] pdf(System.Text.StringBuilder head) {
         
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            byte[] pdfBytes = htmlToPdf.GeneratePdf(head.ToString());
            return pdfBytes;
        }
    }
}
