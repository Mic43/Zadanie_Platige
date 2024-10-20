namespace Platigue.Gui.Export;

public interface IDataExporter
{
    void Export(DataGridView source, string filePath);
}