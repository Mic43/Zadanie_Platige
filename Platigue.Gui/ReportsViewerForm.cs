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
        private readonly DbContextFactory? _dbContextFactory;

        public ReportsViewerForm(DbContextFactory dbContextFactory = null)
        {
            _dbContextFactory = dbContextFactory;
            InitializeComponent();
        }

        private void reload1Button_Click(object sender, EventArgs e)
        {
            using (var ctx = _dbContextFactory.Create())
            {
                dataGridViewGetClientsByContry.DataSource = ctx.GetClientsCountByCountry().ToList();
            }
        }

        private void buttonReload2_Click(object sender, EventArgs e)
        {
            using (var ctx = _dbContextFactory.Create())
            {
                dataGridViewGetInvoicesValueByMonth.DataSource = ctx.GetInvoicesValueByMonth().ToList();
            }
        }

        private void buttonReload3_Click(object sender, EventArgs e)
        {
            using (var ctx = _dbContextFactory.Create())
            {
                dataGridViewGetInvoicesByClient.DataSource = ctx.GetInvoicesByClient().ToList();
            }
        }
    }
}
