using Microsoft.Data.SqlClient;
using Platigue.Db;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using Platigue.Gui.Export;
using Microsoft.EntityFrameworkCore.Internal;

namespace Platigue.Gui
{
    public partial class MainForm : Form
    {
        private readonly DbContextFactory _dbContextFactory;

        private void SaveChangesSafe(PlatigueDbContext context)
        {
            void HandleException(DbUpdateException? exp)
            {
                if (exp == null)
                    return;
                MessageBox.Show(exp.ToString());
            }

            HandleException(context.TrySaveChanges());
        }

        public MainForm(DbContextFactory dbContextFactory = null)
        {
            _dbContextFactory = dbContextFactory;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void ReloadAll()
        {
            using var dbContext = _dbContextFactory.Create();
            clientsListControl.Clients = dbContext.Clients.ToList();
            invoicesListControl.Invoices = dbContext.Invoices.ToList();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            var dlg = new AddEditClientForm();
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            using (var dbContext = _dbContextFactory.Create())
            {
                dbContext.Clients.Add(dlg.clientDetailsControl.Client);
                SaveChangesSafe(dbContext);
            }
            ReloadAll();
        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            if (clientsListControl.SelectedClient == null)
                return;

            using (var dbContext = _dbContextFactory.Create())
            {
                dbContext.Clients.Remove(clientsListControl.SelectedClient);
                SaveChangesSafe(dbContext);
            }

            ReloadAll();
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (clientsListControl.SelectedClient == null)
                return;

            using (var dbContext = _dbContextFactory.Create())
            {
                var dlg = new AddEditClientForm();
                dlg.clientDetailsControl.Client = dbContext.Clients.Find(clientsListControl.SelectedClient.Id);

                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                SaveChangesSafe(dbContext);
            }

            ReloadAll();
        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = _dbContextFactory.Create())
            {
                var invoiceModel = InvoiceModel.Default();
                invoiceModel.Clients.AddRange(dbContext.Clients.ToList());
                invoiceModel.SelectedClient = invoiceModel.Clients.First();

                var dlg = new AddEditInvoiceForm();
                dlg.invoiceDetailsControl.InvoiceModel = invoiceModel;

                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                var invoice = dlg.invoiceDetailsControl.InvoiceModel.ToInvoice();

                if (dbContext.Invoices.Find(invoice.Number) != null)
                {
                    MessageBox.Show("Duplicated id");
                    return;
                }

                dbContext.Invoices.Add(invoice);

                SaveChangesSafe(dbContext);
            }
            ReloadAll();
        }

        private void buttonEditInvoice_Click(object sender, EventArgs e)
        {
            var invoice = invoicesListControl.SelectedInvoice;

            if (invoice == null)
                return;

            var dlg = new AddEditInvoiceForm();
            using (var dbContext = _dbContextFactory.Create())
            {
                string selectedInvoiceId = invoice.Number;
                var selectedInvoice = dbContext.Invoices.Find(selectedInvoiceId);
                
                var clients = dbContext.Clients.ToList();
                Client selectedClient = clients.Single(x => x.Id == selectedInvoice.ClientId);
                dlg.invoiceDetailsControl.InvoiceModel = new InvoiceModel(selectedInvoice, clients, selectedClient);

                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                dlg.invoiceDetailsControl.InvoiceModel.Update(selectedInvoice);
                SaveChangesSafe(dbContext);
            }
            ReloadAll();
        }

        private void Export(DataGridView source)
        {
            var exportDialog = new ExportDialog();

            if (exportDialog.ShowDialog() != DialogResult.OK)
                return;


            var exporter = new ExporterFactory().Create(exportDialog.SelectedExportType);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = exportDialog.SelectedExportType.GetFilterString(),
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

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
            using (var dbContext = _dbContextFactory.Create())
            {
                dbContext.Invoices.Remove(invoicesListControl.SelectedInvoice);
                SaveChangesSafe(dbContext);
            }

            ReloadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ReportsViewerForm(_dbContextFactory).ShowDialog(this);
        }
    }
}
