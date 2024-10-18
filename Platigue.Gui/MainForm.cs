using Microsoft.Data.SqlClient;
using Platigue.Db;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Platigue.Gui
{
    public partial class MainForm : Form
    {
        private readonly PlatigueDbContext? _dbContext;

        public MainForm(PlatigueDbContext? dbContext = null)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

    }
}
