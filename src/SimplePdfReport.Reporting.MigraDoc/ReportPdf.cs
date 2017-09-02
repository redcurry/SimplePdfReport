using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;

namespace SimplePdfReport.Reporting.MigraDoc
{
    public class ReportPdf : IReport
    {
        public void Export(string path, ReportData data)
        {
            ExportPdf(path, CreateReport(data));
        }

        private void ExportPdf(string path, Document report)
        {
            var pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = report;
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(path);
        }

        private Document CreateReport(ReportData data)
        {
            var doc = new Document();
            doc.Add(CreateMainSection(data));
            return doc;
        }

        private Section CreateMainSection(ReportData data)
        {
            var section = new Section();
            return section;
        }
    }
}
