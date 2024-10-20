using System.Xml.Linq;

namespace Platigue.Gui.Export;

public class XmlDataExporter : IDataExporter
{
    public void Export(DataGridView source, string filePath)
    {
        var rows = 
            from DataGridViewRow row in source.Rows
            select new XElement("Row",
                source.Columns.Cast<DataGridViewColumn>().Select(column =>
                    new XElement(column.DataPropertyName, row.Cells[column.Index].Value)));

        var xml = new XElement("Rows", rows);
        xml.Save(filePath);
    }
}