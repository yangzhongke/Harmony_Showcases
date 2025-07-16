using System.Text;
using NPOI.XSSF.UserModel;

namespace HarmonyDemoOnlyLib1;

public class ExcelConverter
{
    public string ConvertToText(string filename)
    {
        StringBuilder sb = new ();
        using XSSFWorkbook workbook = new XSSFWorkbook(filename, true);
        for (int iSheet = 0; iSheet < workbook.NumberOfSheets; iSheet++)
        {
            var sheet = workbook.GetSheetAt(iSheet);
            for (int iRow = 0; iRow < sheet.LastRowNum; iRow++)
            {
                var row = sheet.GetRow(iRow);
                for (int iCell = 0; iCell < row.LastCellNum; iCell++)
                {
                    var cell = row.GetCell(iCell);
                    string? value = cell.GetCellValue();
                    sb.Append(value).Append("\t");
                }
                sb.AppendLine();
            }
        }
        return sb.ToString();
    }

    public int Add(int i, int j)
    {
        LicenceManager.Check();
        return i + j;
    }
}