namespace Platigue.Gui.Export;

public class ExporterFactory
{
    public IDataExporter Create(ExportType exportType)
    {
        switch (exportType)
        {
            case ExportType.Csv:
                return new CsvDataExporter();
            case ExportType.Xml:
                return new XmlDataExporter();
            default:
                throw new ArgumentOutOfRangeException(nameof(exportType), exportType, null);
        }
    }
}