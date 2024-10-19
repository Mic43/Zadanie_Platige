namespace Platigue.Gui;

public interface IDataExporter
{
    void Export(DataGridView source, string filePath);
}