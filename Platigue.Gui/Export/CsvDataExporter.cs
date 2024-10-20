namespace Platigue.Gui.Export;

public class CsvDataExporter : IDataExporter
{
    public void Export(DataGridView source, string filePath)
    {
        var header = source.Columns.OfType<DataGridViewColumn>()
            .Select(x => x.HeaderText)
            .Aggregate((acc, col) => $"{acc}, {col}");
        var data = source.Rows
            .OfType<DataGridViewRow>()
            .Select(row => row.Cells.OfType<DataGridViewCell>()
                .Select(c => c.Value.ToString())
                .Aggregate((acc, valueStr) => $"{acc}, {valueStr ?? string.Empty}"));
                
        var content = Enumerable.Repeat(header, 1).Union(data);

        File.WriteAllLines(filePath, content);

    }
}