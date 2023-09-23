using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection.Metadata;
using iTextSharp.text;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;
using iTextSharp.text.pdf;
using Paragraph = iTextSharp.text.Paragraph;

namespace TraversalCoreProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "File1.pdf");

            using var stream = new FileStream(path,FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Reservation Pdf Document");
            document.Add(paragraph);
            document.Close();

            return File("/pdfreports/File1.pdf", "application/pdf", "File1.pdf");
            
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "File2.pdf");
            using var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Reservation Pdf Document");
            document.Add(paragraph);

            PdfPTable pdfPTable=new PdfPTable(3);
            pdfPTable.AddCell("Guest Name");
            pdfPTable.AddCell("Guest Surname");
            pdfPTable.AddCell("Guest ID");

            pdfPTable.AddCell("Ahmet");
            pdfPTable.AddCell("Yılmaz");
            pdfPTable.AddCell("25684100798");

            pdfPTable.AddCell("Canan");
            pdfPTable.AddCell("Çalışkan");
            pdfPTable.AddCell("34529845607");

            pdfPTable.AddCell("Umut");
            pdfPTable.AddCell("Yurdaışık");
            pdfPTable.AddCell("1245763089");

            document.Add(pdfPTable);
            document.Close();
            return File("/pdfreports/File2.pdf", "application/pdf", "File2.pdf");
        }
    }
}
