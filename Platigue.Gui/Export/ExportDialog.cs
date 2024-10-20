namespace Platigue.Gui.Export;

public class ExportDialog : Form
{
    private ComboBox _exportComboBox;
    private Button _exportButton;
    private Button _button1;

    public ExportType SelectedExportType { get;  set; }

    public ExportDialog()
    {
        InitializeComponent();
        PopulateComboBox();
        BindControls();
    }

    private void InitializeComponent()
    {
        _exportComboBox = new ComboBox();
        _exportButton = new Button();
        _button1 = new Button();
        SuspendLayout();
        // 
        // exportComboBox
        // 
        _exportComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        _exportComboBox.Location = new Point(12, 28);
        _exportComboBox.Name = "_exportComboBox";
        _exportComboBox.Size = new Size(200, 23);
        _exportComboBox.TabIndex = 0;
        // 
        // exportButton
        // 
        _exportButton.DialogResult = DialogResult.OK;
        _exportButton.Location = new Point(12, 73);
        _exportButton.Name = "_exportButton";
        _exportButton.Size = new Size(75, 23);
        _exportButton.TabIndex = 1;
        _exportButton.Text = "Export";
        // 
        // button1
        // 
        _button1.DialogResult = DialogResult.Cancel;
        _button1.Location = new Point(93, 73);
        _button1.Name = "_button1";
        _button1.Size = new Size(75, 24);
        _button1.TabIndex = 2;
        _button1.Text = "Cancel";
        // 
        // ExportDialog
        // 
        CancelButton = _button1;
        ClientSize = new Size(300, 104);
        Controls.Add(_button1);
        Controls.Add(_exportComboBox);
        Controls.Add(_exportButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "ExportDialog";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Export Dialog";
        ResumeLayout(false);
    }

    private void PopulateComboBox()
    {
        _exportComboBox.DataSource = Enum.GetValues(typeof(ExportType)); ;
    }

    private void BindControls()
    {
        _exportComboBox.DataBindings.Add("SelectedItem",this , nameof(SelectedExportType), 
            true, DataSourceUpdateMode.OnPropertyChanged);
    }
}