using System;
using MigraDoc.DocumentObjectModel;

namespace SimplePdfReport.Reporting.MigraDoc.Internal
{
    internal class HeaderAndFooter
    {
        public void Add(Section section, ReportData data)
        {
            AddHeader(section, data.Patient);
            AddFooter(section);
        }

        private void AddHeader(Section section, Patient patient)
        {
            var header = section.Headers.Primary.AddParagraph();
            header.Format.AddTabStop(Size.GetWidth(section), TabAlignment.Right);

            header.AddText($"{patient.LastName}, {patient.FirstName} (ID: {patient.Id})");
            header.AddTab();
            header.AddText($"Generated {DateTime.Now:g}");
        }

        private void AddFooter(Section section)
        {
            var footer = section.Footers.Primary.AddParagraph();
            footer.Format.AddTabStop(Size.GetWidth(section), TabAlignment.Right);

            footer.AddText("Mean Dose Report, General Hospital, Radiation Oncology");
            footer.AddTab();
            footer.AddText("Page ");
            footer.AddPageField();
            footer.AddText(" of ");
            footer.AddNumPagesField();
        }
    }
}