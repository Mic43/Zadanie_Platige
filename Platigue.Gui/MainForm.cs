using Microsoft.Data.SqlClient;
using Platigue.Db;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Platigue.Gui
{
    public partial class MainForm : Form
    {
        private void SaveChangesSafe()
        {
            void HandleException(DbUpdateException? exp)
            {
                if (exp == null)
                    return;
                MessageBox.Show(exp.ToString());
            }

            HandleException(_dbContext!.TrySaveChanges());
        }

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
            clientsListControl.Clients = _dbContext!.Clients.ToList();
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
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            _dbContext!.Clients.Add(dlg.clientDetailsControl.Client);
            SaveChangesSafe();
            ReloadClients();
        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            if (clientsListControl.SelectedClient == null)
                return;

            _dbContext!.Clients.Remove(clientsListControl.SelectedClient);
            SaveChangesSafe();
            ReloadAll();
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (clientsListControl.SelectedClient == null)
                return;

            var dlg = new AddEditClientForm();
            dlg.clientDetailsControl.Client = clientsListControl.SelectedClient;

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            SaveChangesSafe();
            ReloadClients();
        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            var invoiceModel = InvoiceModel.Default();
            invoiceModel.Clients.AddRange(_dbContext!.Clients.ToList());
            invoiceModel.SelectedClient = invoiceModel.Clients.First();

            var dlg = new AddEditInvoiceForm();
            dlg.invoiceDetailsControl.InvoiceModel = invoiceModel;

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            var invoice = dlg.invoiceDetailsControl.InvoiceModel.ToInvoice();

            if (_dbContext.Invoices.Find(invoice.Number) != null)
            {
                MessageBox.Show("Duplicated id");
                return;
            }

            _dbContext!.Invoices.Add(invoice);

            SaveChangesSafe();
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
            SaveChangesSafe();

            ReloadAll();
        }

        private void Export(DataGridView source)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Save as CSV"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var exporter = new CsvDataExporter();
            try
            {
                exporter.Export(source, saveFileDialog.FileName);
                MessageBox.Show("Export successful!", "Export", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (IOException ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Export Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportClients_Click(object sender, EventArgs e)
        {
            Export(clientsListControl.dataGridViewClients);
        }
        private void buttonExportInvoices_Click(object sender, EventArgs e)
        {
            Export(invoicesListControl.dataGridViewInvoices);
        }

        private void buttonRemoveInvoice_Click(object sender, EventArgs e)
        {
            if (invoicesListControl.SelectedInvoice == null)
                return;

            _dbContext!.Invoices.Remove(invoicesListControl.SelectedInvoice);
            SaveChangesSafe();
            ReloadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = _dbContext.GetInvoicesByClient().ToList();
            results.ForEach(x => Trace.WriteLine(x.ToString()));
        }
    }
}
