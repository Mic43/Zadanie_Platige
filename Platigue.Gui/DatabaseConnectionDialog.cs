namespace Platigue.Gui;

public class DatabaseConnectionDialog : Form
{
    private TextBox _txtUsername;
    private TextBox _txtPassword;
    private TextBox _txtServerAddress;
    private TextBox _txtDatabaseName;
    private Button _btnSubmit;

    public string Username { get; private set; }
    public string Password { get; private set; }
    public string ServerAddress { get; private set; }
    public string DatabaseName { get; private set; }

    public DatabaseConnectionDialog()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        FormBorderStyle = FormBorderStyle.FixedDialog;

        Label lblUsername = new Label { Text = "Username:", Left = 10, Top = 20, Width = 100 };
        Label lblPassword = new Label { Text = "Password:", Left = 10, Top = 60, Width = 100 };
        Label lblServerAddress = new Label { Text = "Server Address:", Left = 10, Top = 100, Width = 100 };
        Label lblDatabaseName = new Label { Text = "Database Name:", Left = 10, Top = 140, Width = 100 };


        _txtUsername = new TextBox { Left = 120, Top = 20, Width = 200 };
        _txtPassword = new TextBox { Left = 120, Top = 60, Width = 200, PasswordChar = '*' };
        _txtServerAddress = new TextBox { Left = 120, Top = 100, Width = 200 };
        _txtDatabaseName = new TextBox { Left = 120, Top = 140, Width = 200 };


        _btnSubmit = new Button { Text = "Submit", Left = 120, Top = 180, Width = 100 };
        _btnSubmit.Click += BtnSubmit_Click;


        this.Text = "Database Connection";
        this.ClientSize = new System.Drawing.Size(340, 230);
        this.Controls.Add(lblUsername);
        this.Controls.Add(lblPassword);
        this.Controls.Add(lblServerAddress);
        this.Controls.Add(lblDatabaseName);
        this.Controls.Add(_txtUsername);
        this.Controls.Add(_txtPassword);
        this.Controls.Add(_txtServerAddress);
        this.Controls.Add(_txtDatabaseName);
        this.Controls.Add(_btnSubmit);
    }

    private void BtnSubmit_Click(object sender, EventArgs e)
    {
        // Collect data
        Username = _txtUsername.Text;
        Password = _txtPassword.Text;
        ServerAddress = _txtServerAddress.Text;
        DatabaseName = _txtDatabaseName.Text;

        if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password) ||
            string.IsNullOrWhiteSpace(ServerAddress) || string.IsNullOrWhiteSpace(DatabaseName))
        {
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}