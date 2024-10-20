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
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Text = "Database Connection";
        this.ClientSize = new System.Drawing.Size(340, 230);

        this.SuspendLayout();

        Label lblUsername = new Label();
        lblUsername.Text = "Username:";
        lblUsername.Left = 10;
        lblUsername.Top = 20;
        lblUsername.Width = 100;

        Label lblPassword = new Label();
        lblPassword.Text = "Password:";
        lblPassword.Left = 10;
        lblPassword.Top = 60;
        lblPassword.Width = 100;

        Label lblServerAddress = new Label();
        lblServerAddress.Text = "Server Address:";
        lblServerAddress.Left = 10;
        lblServerAddress.Top = 100;
        lblServerAddress.Width = 100;

        Label lblDatabaseName = new Label();
        lblDatabaseName.Text = "Database Name:";
        lblDatabaseName.Left = 10;
        lblDatabaseName.Top = 140;
        lblDatabaseName.Width = 100;

        // Create text boxes
        _txtUsername = new TextBox();
        _txtUsername.Left = 120;
        _txtUsername.Top = 20;
        _txtUsername.Width = 200;

        _txtPassword = new TextBox();
        _txtPassword.Left = 120;
        _txtPassword.Top = 60;
        _txtPassword.Width = 200;
        _txtPassword.PasswordChar = '*';

        _txtServerAddress = new TextBox();
        _txtServerAddress.Left = 120;
        _txtServerAddress.Top = 100;
        _txtServerAddress.Width = 200;

        _txtDatabaseName = new TextBox();
        _txtDatabaseName.Left = 120;
        _txtDatabaseName.Top = 140;
        _txtDatabaseName.Width = 200;

        // Create button
        _btnSubmit = new Button();
        _btnSubmit.Text = "Submit";
        _btnSubmit.Left = 120;
        _btnSubmit.Top = 180;
        _btnSubmit.Width = 100;
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

        this.ResumeLayout(false);
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