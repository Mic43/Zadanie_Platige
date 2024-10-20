namespace Platigue.Gui
{
    partial class ReportsViewerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewGetClientsByContry = new DataGridView();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getClientsCountByCountryResultBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            reload1Button = new Button();
            tabPage2 = new TabPage();
            dataGridViewGetInvoicesValueByMonth = new DataGridView();
            monthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalValueWithTaxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getInvoicesValueByMonthResultBindingSource = new BindingSource(components);
            panel2 = new Panel();
            buttonReload2 = new Button();
            tabPage3 = new TabPage();
            dataGridViewGetInvoicesByClient = new DataGridView();
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalValueDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalValueWithTaxDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            getInvoicesByClientResultBindingSource = new BindingSource(components);
            panel3 = new Panel();
            buttonReload3 = new Button();
            getInvoicesByClientResultBindingSource1 = new BindingSource(components);
            getInvoicesValueByMonthResultBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGetClientsByContry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getClientsCountByCountryResultBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGetInvoicesValueByMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getInvoicesValueByMonthResultBindingSource).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGetInvoicesByClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getInvoicesByClientResultBindingSource).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)getInvoicesByClientResultBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getInvoicesValueByMonthResultBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGetClientsByContry
            // 
            dataGridViewGetClientsByContry.AllowUserToAddRows = false;
            dataGridViewGetClientsByContry.AllowUserToDeleteRows = false;
            dataGridViewGetClientsByContry.AutoGenerateColumns = false;
            dataGridViewGetClientsByContry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGetClientsByContry.Columns.AddRange(new DataGridViewColumn[] { countryDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn });
            dataGridViewGetClientsByContry.DataSource = getClientsCountByCountryResultBindingSource;
            dataGridViewGetClientsByContry.Dock = DockStyle.Fill;
            dataGridViewGetClientsByContry.Location = new Point(3, 3);
            dataGridViewGetClientsByContry.Name = "dataGridViewGetClientsByContry";
            dataGridViewGetClientsByContry.ReadOnly = true;
            dataGridViewGetClientsByContry.Size = new Size(786, 416);
            dataGridViewGetClientsByContry.TabIndex = 0;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Country";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getClientsCountByCountryResultBindingSource
            // 
            getClientsCountByCountryResultBindingSource.DataSource = typeof(Db.GetClientsCountByCountryResult);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridViewGetClientsByContry);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(reload1Button);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 371);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 48);
            panel1.TabIndex = 1;
            // 
            // reload1Button
            // 
            reload1Button.Location = new Point(5, 15);
            reload1Button.Name = "reload1Button";
            reload1Button.Size = new Size(75, 23);
            reload1Button.TabIndex = 0;
            reload1Button.Text = "Reload";
            reload1Button.UseVisualStyleBackColor = true;
            reload1Button.Click += reload1Button_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewGetInvoicesValueByMonth);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGetInvoicesValueByMonth
            // 
            dataGridViewGetInvoicesValueByMonth.AllowUserToAddRows = false;
            dataGridViewGetInvoicesValueByMonth.AllowUserToDeleteRows = false;
            dataGridViewGetInvoicesValueByMonth.AutoGenerateColumns = false;
            dataGridViewGetInvoicesValueByMonth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGetInvoicesValueByMonth.Columns.AddRange(new DataGridViewColumn[] { monthDataGridViewTextBoxColumn, totalValueDataGridViewTextBoxColumn, totalValueWithTaxDataGridViewTextBoxColumn });
            dataGridViewGetInvoicesValueByMonth.DataSource = getInvoicesValueByMonthResultBindingSource;
            dataGridViewGetInvoicesValueByMonth.Dock = DockStyle.Fill;
            dataGridViewGetInvoicesValueByMonth.Location = new Point(3, 3);
            dataGridViewGetInvoicesValueByMonth.Name = "dataGridViewGetInvoicesValueByMonth";
            dataGridViewGetInvoicesValueByMonth.ReadOnly = true;
            dataGridViewGetInvoicesValueByMonth.Size = new Size(786, 368);
            dataGridViewGetInvoicesValueByMonth.TabIndex = 3;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            monthDataGridViewTextBoxColumn.HeaderText = "Month";
            monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            monthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalValueDataGridViewTextBoxColumn
            // 
            totalValueDataGridViewTextBoxColumn.DataPropertyName = "TotalValue";
            totalValueDataGridViewTextBoxColumn.HeaderText = "TotalValue";
            totalValueDataGridViewTextBoxColumn.Name = "totalValueDataGridViewTextBoxColumn";
            totalValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalValueWithTaxDataGridViewTextBoxColumn
            // 
            totalValueWithTaxDataGridViewTextBoxColumn.DataPropertyName = "TotalValueWithTax";
            totalValueWithTaxDataGridViewTextBoxColumn.HeaderText = "TotalValueWithTax";
            totalValueWithTaxDataGridViewTextBoxColumn.Name = "totalValueWithTaxDataGridViewTextBoxColumn";
            totalValueWithTaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getInvoicesValueByMonthResultBindingSource
            // 
            getInvoicesValueByMonthResultBindingSource.DataSource = typeof(Db.GetInvoicesValueByMonthResult);
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonReload2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 48);
            panel2.TabIndex = 2;
            // 
            // buttonReload2
            // 
            buttonReload2.Location = new Point(5, 15);
            buttonReload2.Name = "buttonReload2";
            buttonReload2.Size = new Size(75, 23);
            buttonReload2.TabIndex = 0;
            buttonReload2.Text = "Reload";
            buttonReload2.UseVisualStyleBackColor = true;
            buttonReload2.Click += buttonReload2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewGetInvoicesByClient);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGetInvoicesByClient
            // 
            dataGridViewGetInvoicesByClient.AutoGenerateColumns = false;
            dataGridViewGetInvoicesByClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGetInvoicesByClient.Columns.AddRange(new DataGridViewColumn[] { clientIdDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn1, totalValueDataGridViewTextBoxColumn1, totalValueWithTaxDataGridViewTextBoxColumn1 });
            dataGridViewGetInvoicesByClient.DataSource = getInvoicesByClientResultBindingSource;
            dataGridViewGetInvoicesByClient.Dock = DockStyle.Fill;
            dataGridViewGetInvoicesByClient.Location = new Point(3, 3);
            dataGridViewGetInvoicesByClient.Name = "dataGridViewGetInvoicesByClient";
            dataGridViewGetInvoicesByClient.Size = new Size(786, 368);
            dataGridViewGetInvoicesByClient.TabIndex = 3;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            countDataGridViewTextBoxColumn1.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn1.HeaderText = "Count";
            countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            countDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalValueDataGridViewTextBoxColumn1
            // 
            totalValueDataGridViewTextBoxColumn1.DataPropertyName = "TotalValue";
            totalValueDataGridViewTextBoxColumn1.HeaderText = "TotalValue";
            totalValueDataGridViewTextBoxColumn1.Name = "totalValueDataGridViewTextBoxColumn1";
            totalValueDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalValueWithTaxDataGridViewTextBoxColumn1
            // 
            totalValueWithTaxDataGridViewTextBoxColumn1.DataPropertyName = "TotalValueWithTax";
            totalValueWithTaxDataGridViewTextBoxColumn1.HeaderText = "TotalValueWithTax";
            totalValueWithTaxDataGridViewTextBoxColumn1.Name = "totalValueWithTaxDataGridViewTextBoxColumn1";
            totalValueWithTaxDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // getInvoicesByClientResultBindingSource
            // 
            getInvoicesByClientResultBindingSource.DataSource = typeof(Db.GetInvoicesByClientResult);
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonReload3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 371);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 48);
            panel3.TabIndex = 2;
            // 
            // buttonReload3
            // 
            buttonReload3.Location = new Point(5, 15);
            buttonReload3.Name = "buttonReload3";
            buttonReload3.Size = new Size(75, 23);
            buttonReload3.TabIndex = 0;
            buttonReload3.Text = "Reload";
            buttonReload3.UseVisualStyleBackColor = true;
            buttonReload3.Click += buttonReload3_Click;
            // 
            // getInvoicesByClientResultBindingSource1
            // 
            getInvoicesByClientResultBindingSource1.DataSource = typeof(Db.GetInvoicesByClientResult);
            // 
            // getInvoicesValueByMonthResultBindingSource1
            // 
            getInvoicesValueByMonthResultBindingSource1.DataSource = typeof(Db.GetInvoicesValueByMonthResult);
            // 
            // ReportsViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ReportsViewerForm";
            Text = "ReportsViewerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGetClientsByContry).EndInit();
            ((System.ComponentModel.ISupportInitialize)getClientsCountByCountryResultBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGetInvoicesValueByMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)getInvoicesValueByMonthResultBindingSource).EndInit();
            panel2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGetInvoicesByClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)getInvoicesByClientResultBindingSource).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)getInvoicesByClientResultBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)getInvoicesValueByMonthResultBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewGetClientsByContry;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private BindingSource getClientsCountByCountryResultBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Button reload1Button;
        private DataGridView dataGridViewGetInvoicesValueByMonth;
        private DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalValueWithTaxDataGridViewTextBoxColumn;
        private BindingSource getInvoicesValueByMonthResultBindingSource;
        private Panel panel2;
        private Button buttonReload2;
        private TabPage tabPage3;
        private DataGridView dataGridViewGetInvoicesByClient;
        private BindingSource getInvoicesValueByMonthResultBindingSource1;
        private Panel panel3;
        private Button buttonReload3;
        private BindingSource getInvoicesByClientResultBindingSource;
        private BindingSource getInvoicesByClientResultBindingSource1;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalValueDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalValueWithTaxDataGridViewTextBoxColumn1;
    }
}