using NPOI.SS.UserModel;

namespace HarmonyDemoOnlyLib1;

public static class CellExtensions
{
    public static string? GetCellValue(this ICell cell)
    {
        return cell.StringCellValue;
    }
}