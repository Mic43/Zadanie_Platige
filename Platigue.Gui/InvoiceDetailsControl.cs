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
using Platigue.Db;

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
            textBoxNumber.DataBindings.Add("Text", bindingSourceMain, "Number", true,
                DataSourceUpdateMode.OnPropertyChanged);
            comboBoxClients.DataBindings.Add("DataSource", bindingSourceMain, "Clients", true);
            comboBoxClients.DisplayMember = "Id";
            comboBoxClients.DataBindings.Add("SelectedItem", bindingSourceMain, "SelectedClient", true,
                DataSourceUpdateMode.OnPropertyChanged);
        }
    }

    public class InvoiceModel
    {
        public Client? SelectedClient { get; set; }
        public List<Client> Clients { get; set; }

        public string Number { get;  set; }
        public decimal Value { get; set; }
        public string Currency { get; set; }
        public decimal VAT { get; set; }
        public DateTime IssueDate { get; set; }
        public string Description { get; set; }

        public InvoiceModel(Invoice invoice, List<Client> clients, Client? selectedClient)
        {
            if (invoice == null) throw new ArgumentNullException(nameof(invoice));

            Clients = clients ?? throw new ArgumentNullException(nameof(clients));
            SelectedClient = selectedClient;

            Number = invoice.Number;
            Value = invoice.Value;
            Currency = invoice.Currency;
            VAT = invoice.VAT;
            IssueDate = invoice.IssueDate;
            Description = invoice.Description;
        }

        public static InvoiceModel Default()
        {
            return new InvoiceModel(Invoice.Default(), [], null);
        }

        public Invoice ToInvoice()
        {
            return new Invoice(Number, SelectedClient, Value, Currency, VAT, IssueDate,Description);
        }
        public void Update(Invoice existing)
        {
            existing.Client = SelectedClient;
            existing.Currency = Currency;
            existing.VAT = VAT;
            existing.IssueDate = IssueDate;
            existing.Description = Description;
        }
    }

}
