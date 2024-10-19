using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Platigue.Db;

namespace Platigue.Gui
{
    public partial class ClientsListControl : UserControl
    {
        private List<Client> _clients = new();
        public Client? SelectedClient { get; private set; } = null;

        public List<Client> Clients
        {
            get => _clients;
            set
            {
                _clients = value;
                clientBindingSource.DataSource = _clients;
            }
        }

        public ClientsListControl()
        {
            InitializeComponent();
        }

        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow != null)
            {
                SelectedClient = (Client)dataGridViewClients.CurrentRow.DataBoundItem;
            }
            else
            {
                SelectedClient = null;
            }
        }
    }
}
