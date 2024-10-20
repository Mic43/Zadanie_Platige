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
    public partial class ClientDetailsControl : UserControl
    {
        private Client _client;
        public Client Client
        {
            get => _client;
            set
            {
                _client = value;
                bindingSourceMain.DataSource = _client;
                bindingSourceMain.ResetBindings(false);
            }
        }

        public ClientDetailsControl()
        {
            InitializeComponent();
            Client = Client.Default();

            txtName.DataBindings.Add("Text", bindingSourceMain, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtShortcut.DataBindings.Add("Text", bindingSourceMain, "Shortcut", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCountry.DataBindings.Add("Text", bindingSourceMain, "Country", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAddress.DataBindings.Add("Text", bindingSourceMain, "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNIP.DataBindings.Add("Text", bindingSourceMain, "NIP", true, DataSourceUpdateMode.OnPropertyChanged);
            chkIsActive.DataBindings.Add("Checked", bindingSourceMain, "IsActive", true, DataSourceUpdateMode.OnPropertyChanged);

        }
    }
}
