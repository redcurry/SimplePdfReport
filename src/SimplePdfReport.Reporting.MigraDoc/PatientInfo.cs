using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;

namespace SimplePdfReport.Reporting.MigraDoc
{
    internal class PatientInfo
    {
        public static readonly Color Shading = new Color(243, 243, 243);

        public void Add(Section section, Patient patient)
        {
            var table = AddPlainTable(section);
            table.Shading.Color = Shading;

            // Use two columns of equal width
            var columnWidth = Size.GetWidth(section) / 2.0;
            table.AddColumn(columnWidth);
            table.AddColumn(columnWidth);

            var row = table.AddRow();

            AddPatientNameAndSex(row.Cells[0], patient);
        }

        private Table AddPlainTable(Section section)
        {
            var table = section.AddTable();

            table.Rows.LeftIndent = 0;

            table.LeftPadding = Size.TableCellPadding;
            table.TopPadding = Size.TableCellPadding;
            table.RightPadding = Size.TableCellPadding;
            table.BottomPadding = Size.TableCellPadding;

            return table;
        }

        private void AddPatientNameAndSex(Cell cell, Patient patient)
        {
            var p = cell.AddParagraph();
            p.Style = CustomStyles.PatientName;

            p.AddText($"{patient.LastName}, {patient.FirstName}");
            p.AddSpace(2);
            AddSexSymbol(p, patient.Sex);
        }

        private void AddSexSymbol(Paragraph p, Sex sex)
        {
            p.AddImage(new SexSymbol(sex).GetMigraDocFileName());
        }
    }
}