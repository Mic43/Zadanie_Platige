namespace Platigue.Gui
{
    partial class InvoicesListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewInvoices = new DataGridView();
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currencyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vATDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            issueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invoiceBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInvoices
            // 
            dataGridViewInvoices.AllowUserToAddRows = false;
            dataGridViewInvoices.AllowUserToDeleteRows = false;
            dataGridViewInvoices.AutoGenerateColumns = false;
            dataGridViewInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoices.Columns.AddRange(new DataGridViewColumn[] { clientIdDataGridViewTextBoxColumn, numberDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn, currencyDataGridViewTextBoxColumn, vATDataGridViewTextBoxColumn, issueDateDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridViewInvoices.DataSource = invoiceBindingSource;
            dataGridViewInvoices.Dock = DockStyle.Fill;
            dataGridViewInvoices.Location = new Point(0, 0);
            dataGridViewInvoices.Name = "dataGridViewInvoices";
            dataGridViewInvoices.ReadOnly = true;
            dataGridViewInvoices.Size = new Size(696, 341);
            dataGridViewInvoices.TabIndex = 0;
            dataGridViewInvoices.SelectionChanged += dataGridViewInvoices_SelectionChanged;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Number";
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            valueDataGridViewTextBoxColumn.HeaderText = "Value";
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            currencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            vATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            issueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceBindingSource
            // 
            invoiceBindingSource.DataSource = typeof(Db.Invoice);
            // 
            // InvoicesListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewInvoices);
            Name = "InvoicesListControl";
            Size = new Size(696, 341);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource invoiceBindingSource;
        public DataGridView dataGridViewInvoices;
    }
}
