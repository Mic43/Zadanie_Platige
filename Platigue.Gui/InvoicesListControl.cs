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
    public partial class InvoicesListControl : UserControl
    {
        private List<Invoice> _invoices = new();
        public Invoice? SelectedInvoice { get; private set; } = null;

        public List<Invoice> Invoices
        {
            get => _invoices;
            set
            {
                _invoices = value;
                invoiceBindingSource.DataSource = _invoices;
            }
        }

        public InvoicesListControl()
        {
            InitializeComponent();
        }

        private void dataGridViewInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.CurrentRow != null)
            {
                //TODO: exception throw here
                SelectedInvoice = (Invoice)dataGridViewInvoices.CurrentRow.DataBoundItem;
            }
            else
            {
                SelectedInvoice = null;
            }
        }

    }
}
