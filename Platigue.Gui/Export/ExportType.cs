namespace Platigue.Gui.Export;

public enum ExportType
{
    Csv,
    Xml
}

public static class ExportTypeExtensions
{
    public static string GetFilterString(this ExportType exportType)
    {
        return exportType switch
        {
            ExportType.Csv => "CSV files (*.csv)|*.csv",
            ExportType.Xml => "Xml files (*.xml)|*.xml",
            _ => throw new ArgumentOutOfRangeException(nameof(exportType), exportType, null)
        };
    }
}