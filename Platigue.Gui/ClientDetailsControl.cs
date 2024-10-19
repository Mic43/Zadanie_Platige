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
                bindingSourceMain.DataSource = _client; //?? Client.Default();
            }
        }

        public ClientDetailsControl()
        {
            InitializeComponent();
            Client = Client.Default();

            textBoxName.DataBindings.Add("Text", bindingSourceMain, "Name", true, 
                DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
