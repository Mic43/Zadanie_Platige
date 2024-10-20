using Platigue.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platigue.Gui
{
    public partial class ReportsViewerForm : Form
    {
        private readonly PlatigueDbContext? _dbContext;

        public ReportsViewerForm(PlatigueDbContext? dbContext = null)
        {
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void reload1Button_Click(object sender, EventArgs e)
        {
            dataGridViewGetClientsByContry.DataSource = _dbContext.GetClientsCountByCountry().ToList();
        }

        private void buttonReload2_Click(object sender, EventArgs e)
        {
            dataGridViewGetInvoicesValueByMonth.DataSource = _dbContext.GetInvoicesValueByMonth().ToList();
        }

        private void buttonReload3_Click(object sender, EventArgs e)
        {
            dataGridViewGetInvoicesByClient.DataSource = _dbContext.GetInvoicesByClient().ToList();
        }
    }
}
