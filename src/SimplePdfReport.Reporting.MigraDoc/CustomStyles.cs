using MigraDoc.DocumentObjectModel;

namespace SimplePdfReport.Reporting.MigraDoc
{
    internal class CustomStyles
    {
        public const string PatientName = "PatientName";

        public static void Define(Document doc)
        {
            var patientName = doc.Styles.AddStyle(PatientName, StyleNames.Normal);
            patientName.ParagraphFormat.Font.Size = 14;
            patientName.ParagraphFormat.Font.Bold = true;
        }
    }
}