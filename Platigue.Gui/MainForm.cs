using Microsoft.Data.SqlClient;
using Platigue.Db;
using System.Collections.Generic;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadAll();

        }

        private void ReloadClients()
        {
            _clientsListControl.Clients = _dbContext!.Clients.ToList();
        }

        private void ReloadInvoices()
        {
            invoicesListControl.Invoices = _dbContext!.Invoices.ToList();
        }

        private void ReloadAll()
        {
            ReloadClients();
            ReloadInvoices();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            var dlg = new AddEditClientForm();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _dbContext!.Clients.Add(dlg.clientDetailsControl.Client);
                _dbContext.SaveChanges();
                ReloadClients();
            }
        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            if (_clientsListControl.SelectedClient == null)
                return;

            _dbContext!.Clients.Remove(_clientsListControl.SelectedClient);
            _dbContext.SaveChanges();
            ReloadAll();
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (_clientsListControl.SelectedClient == null)
                return;

            var dlg = new AddEditClientForm();
            dlg.clientDetailsControl.Client = _clientsListControl.SelectedClient;

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            _dbContext!.SaveChanges();
            ReloadClients();
        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            var invoiceModel = InvoiceModel.Default();
            invoiceModel.Clients.AddRange(_dbContext!.Clients.ToList());
            invoiceModel.SelectedClient = invoiceModel.Clients.First();

            var dlg = new AddEditInvoiceForm();
            dlg.invoiceDetailsControl.InvoiceModel = invoiceModel;

            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            _dbContext!.Invoices.Add(dlg.invoiceDetailsControl.InvoiceModel.ToInvoice());
            _dbContext.SaveChanges();
            ReloadAll();
        }

        private void buttonEditInvoice_Click(object sender, EventArgs e)
        {
            var selectedInvoice = invoicesListControl.SelectedInvoice;

            if (selectedInvoice == null)
                return;

            var dlg = new AddEditInvoiceForm();
            var clients = _dbContext!.Clients.ToList();
            Client selectedClient = clients.Single(x => x.Id == selectedInvoice.ClientId);
            dlg.invoiceDetailsControl.InvoiceModel = new InvoiceModel(selectedInvoice, clients, selectedClient);

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            dlg.invoiceDetailsControl.InvoiceModel.Update(selectedInvoice);
            _dbContext!.SaveChanges();

            ReloadAll();
        }
    }
}
