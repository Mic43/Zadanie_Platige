using Microsoft.Data.SqlClient;
using Platigue.Db;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Platigue.Gui;

public class DatabaseConnectionDialog : Form
{
    private TextBox _txtUsername;
    private TextBox _txtPassword;
    private TextBox _txtServerAddress;
    private TextBox _txtDatabaseName;
    private Label lblUsername;
    private Label lblPassword;
    private Label lblServerAddress;
    private Label lblDatabaseName;
    private ProgressBar progressBarConnection;
    private Button _btnSubmit;
    private PlatigueDbContext _context;

    public string Username { get; private set; }
    public string Password { get; private set; }
    public string ServerAddress { get; private set; }
    public string DatabaseName { get; private set; }
    public bool CanConnect { get; private set; }

    public PlatigueDbContext Context => _context;

    public DatabaseConnectionDialog()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        lblUsername = new Label();
        lblPassword = new Label();
        lblServerAddress = new Label();
        lblDatabaseName = new Label();
        _txtUsername = new TextBox();
        _txtPassword = new TextBox();
        _txtServerAddress = new TextBox();
        _txtDatabaseName = new TextBox();
        _btnSubmit = new Button();
        progressBarConnection = new ProgressBar();
        SuspendLayout();
        // 
        // lblUsername
        // 
        lblUsername.Location = new Point(10, 20);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(100, 23);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Username:";
        // 
        // lblPassword
        // 
        lblPassword.Location = new Point(10, 60);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(100, 23);
        lblPassword.TabIndex = 1;
        lblPassword.Text = "Password:";
        // 
        // lblServerAddress
        // 
        lblServerAddress.Location = new Point(10, 100);
        lblServerAddress.Name = "lblServerAddress";
        lblServerAddress.Size = new Size(100, 23);
        lblServerAddress.TabIndex = 2;
        lblServerAddress.Text = "Server Address:";
        // 
        // lblDatabaseName
        // 
        lblDatabaseName.Location = new Point(10, 140);
        lblDatabaseName.Name = "lblDatabaseName";
        lblDatabaseName.Size = new Size(100, 23);
        lblDatabaseName.TabIndex = 3;
        lblDatabaseName.Text = "Database Name:";
        // 
        // _txtUsername
        // 
        _txtUsername.Location = new Point(120, 20);
        _txtUsername.Name = "_txtUsername";
        _txtUsername.Size = new Size(200, 23);
        _txtUsername.TabIndex = 4;
        // 
        // _txtPassword
        // 
        _txtPassword.Location = new Point(120, 60);
        _txtPassword.Name = "_txtPassword";
        _txtPassword.PasswordChar = '*';
        _txtPassword.Size = new Size(200, 23);
        _txtPassword.TabIndex = 5;
        // 
        // _txtServerAddress
        // 
        _txtServerAddress.Location = new Point(120, 100);
        _txtServerAddress.Name = "_txtServerAddress";
        _txtServerAddress.Size = new Size(200, 23);
        _txtServerAddress.TabIndex = 6;
        // 
        // _txtDatabaseName
        // 
        _txtDatabaseName.Location = new Point(120, 140);
        _txtDatabaseName.Name = "_txtDatabaseName";
        _txtDatabaseName.Size = new Size(200, 23);
        _txtDatabaseName.TabIndex = 7;
        // 
        // _btnSubmit
        // 
        _btnSubmit.Location = new Point(120, 189);
        _btnSubmit.Name = "_btnSubmit";
        _btnSubmit.Size = new Size(100, 23);
        _btnSubmit.TabIndex = 8;
        _btnSubmit.Text = "Submit";
        _btnSubmit.Click += BtnSubmit_Click;
        // 
        // progressBarConnection
        // 
        progressBarConnection.Location = new Point(10, 169);
        progressBarConnection.MarqueeAnimationSpeed = 5;
        progressBarConnection.Name = "progressBarConnection";
        progressBarConnection.Size = new Size(316, 14);
        progressBarConnection.Style = ProgressBarStyle.Marquee;
        progressBarConnection.TabIndex = 9;
        progressBarConnection.Visible = false;
        // 
        // DatabaseConnectionDialog
        // 
        ClientSize = new Size(340, 218);
        Controls.Add(progressBarConnection);
        Controls.Add(lblUsername);
        Controls.Add(lblPassword);
        Controls.Add(lblServerAddress);
        Controls.Add(lblDatabaseName);
        Controls.Add(_txtUsername);
        Controls.Add(_txtPassword);
        Controls.Add(_txtServerAddress);
        Controls.Add(_txtDatabaseName);
        Controls.Add(_btnSubmit);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "DatabaseConnectionDialog";
        Text = "Database Connection";
        ResumeLayout(false);
        PerformLayout();
    }

    private async void BtnSubmit_Click(object sender, EventArgs e)
    {
      
        Username = _txtUsername.Text;
        Password = _txtPassword.Text;
        ServerAddress = _txtServerAddress.Text;
        DatabaseName = _txtDatabaseName.Text;

        if (string.IsNullOrWhiteSpace(ServerAddress) || string.IsNullOrWhiteSpace(DatabaseName))
        {
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        void BuildConnString()
        {
            var builder = new SqlConnectionStringBuilder()
            {
                DataSource = ServerAddress,
                InitialCatalog = DatabaseName,
                UserID = Username,
                Password = Password,
                IntegratedSecurity = false
            };
            var con = builder.ConnectionString;
            _context = PlatigueDbContext.FromConnectionString(con);
        }

        BuildConnString();

        Enabled = false;
        progressBarConnection.Visible = true;

        CanConnect = await _context.Database.CanConnectAsync();

        Enabled = true;
        progressBarConnection.Visible = false;

        DialogResult = DialogResult.OK;
        Close();
    }
}