using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platigue.Gui
{
    public partial class InvoiceDetailsControl : UserControl
    {
        private InvoiceModel _invoiceModel;
        public InvoiceModel InvoiceModel
        {
            get => _invoiceModel;
            set
            {
                _invoiceModel = value;
                bindingSourceMain.DataSource = _invoiceModel;
            }
        }

        public InvoiceDetailsControl()
        {
            InitializeComponent();
            InvoiceModel = InvoiceModel.Default();
            //
            txtNumber.DataBindings.Add("Text", bindingSourceMain, "Number", true,
                DataSourceUpdateMode.OnPropertyChanged);
            txtValue.DataBindings.Add("Text", bindingSourceMain, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCurrency.DataBindings.Add("Text", bindingSourceMain, "Currency", true, DataSourceUpdateMode.OnPropertyChanged);
            txtVAT.DataBindings.Add("Text", bindingSourceMain, "VAT", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpIssueDate.DataBindings.Add("Value", bindingSourceMain, "IssueDate", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescription.DataBindings.Add("Text", bindingSourceMain, "Description", true, DataSourceUpdateMode.OnPropertyChanged);

            comboBoxClients.DataBindings.Add("DataSource", bindingSourceMain, "Clients", true);
            comboBoxClients.DisplayMember = "Id";
            comboBoxClients.DataBindings.Add("SelectedItem", bindingSourceMain, "SelectedClient", true,
                DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
