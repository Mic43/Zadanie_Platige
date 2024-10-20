namespace Platigue.Gui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            clientsListControl = new ClientsListControl();
            buttonAddClient = new Button();
            buttonRemoveClient = new Button();
            buttonEditClient = new Button();
            invoicesListControl = new InvoicesListControl();
            buttonRemoveInvoice = new Button();
            buttonEditInvoice = new Button();
            addInvoiceButton = new Button();
            buttonExportClients = new Button();
            buttonExportInvoices = new Button();
            buttonReports = new Button();
            SuspendLayout();
            // 
            // clientsListControl
            // 
            clientsListControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientsListControl.Location = new Point(12, 12);
            clientsListControl.Name = "clientsListControl";
            clientsListControl.Size = new Size(1169, 254);
            clientsListControl.TabIndex = 1;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddClient.Location = new Point(12, 272);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(75, 23);
            buttonAddClient.TabIndex = 2;
            buttonAddClient.Text = "Add";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonRemoveClient
            // 
            buttonRemoveClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemoveClient.Location = new Point(93, 272);
            buttonRemoveClient.Name = "buttonRemoveClient";
            buttonRemoveClient.Size = new Size(75, 23);
            buttonRemoveClient.TabIndex = 3;
            buttonRemoveClient.Text = "Remove";
            buttonRemoveClient.UseVisualStyleBackColor = true;
            buttonRemoveClient.Click += buttonRemoveClient_Click;
            // 
            // buttonEditClient
            // 
            buttonEditClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEditClient.Location = new Point(174, 272);
            buttonEditClient.Name = "buttonEditClient";
            buttonEditClient.Size = new Size(75, 23);
            buttonEditClient.TabIndex = 4;
            buttonEditClient.Text = "Edit";
            buttonEditClient.UseVisualStyleBackColor = true;
            buttonEditClient.Click += buttonEditClient_Click;
            // 
            // invoicesListControl
            // 
            invoicesListControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            invoicesListControl.Location = new Point(12, 331);
            invoicesListControl.Name = "invoicesListControl";
            invoicesListControl.Size = new Size(1169, 285);
            invoicesListControl.TabIndex = 5;
            // 
            // buttonRemoveInvoice
            // 
            buttonRemoveInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemoveInvoice.Location = new Point(93, 622);
            buttonRemoveInvoice.Name = "buttonRemoveInvoice";
            buttonRemoveInvoice.Size = new Size(75, 23);
            buttonRemoveInvoice.TabIndex = 8;
            buttonRemoveInvoice.Text = "Remove";
            buttonRemoveInvoice.UseVisualStyleBackColor = true;
            buttonRemoveInvoice.Click += buttonRemoveInvoice_Click;
            // 
            // buttonEditInvoice
            // 
            buttonEditInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEditInvoice.Location = new Point(174, 622);
            buttonEditInvoice.Name = "buttonEditInvoice";
            buttonEditInvoice.Size = new Size(75, 23);
            buttonEditInvoice.TabIndex = 7;
            buttonEditInvoice.Text = "Edit";
            buttonEditInvoice.UseVisualStyleBackColor = true;
            buttonEditInvoice.Click += buttonEditInvoice_Click;
            // 
            // addInvoiceButton
            // 
            addInvoiceButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addInvoiceButton.Location = new Point(12, 622);
            addInvoiceButton.Name = "addInvoiceButton";
            addInvoiceButton.Size = new Size(75, 23);
            addInvoiceButton.TabIndex = 6;
            addInvoiceButton.Text = "Add";
            addInvoiceButton.UseVisualStyleBackColor = true;
            addInvoiceButton.Click += addInvoiceButton_Click;
            // 
            // buttonExportClients
            // 
            buttonExportClients.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonExportClients.Location = new Point(255, 272);
            buttonExportClients.Name = "buttonExportClients";
            buttonExportClients.Size = new Size(75, 23);
            buttonExportClients.TabIndex = 9;
            buttonExportClients.Text = "Export";
            buttonExportClients.UseVisualStyleBackColor = true;
            buttonExportClients.Click += buttonExportClients_Click;
            // 
            // buttonExportInvoices
            // 
            buttonExportInvoices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonExportInvoices.Location = new Point(255, 622);
            buttonExportInvoices.Name = "buttonExportInvoices";
            buttonExportInvoices.Size = new Size(75, 23);
            buttonExportInvoices.TabIndex = 10;
            buttonExportInvoices.Text = "Export";
            buttonExportInvoices.UseVisualStyleBackColor = true;
            buttonExportInvoices.Click += buttonExportInvoices_Click;
            // 
            // buttonReports
            // 
            buttonReports.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonReports.Location = new Point(1106, 622);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(75, 23);
            buttonReports.TabIndex = 11;
            buttonReports.Text = "Reports";
            buttonReports.UseVisualStyleBackColor = true;
            buttonReports.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 657);
            Controls.Add(buttonReports);
            Controls.Add(buttonExportInvoices);
            Controls.Add(buttonExportClients);
            Controls.Add(buttonRemoveInvoice);
            Controls.Add(buttonEditInvoice);
            Controls.Add(addInvoiceButton);
            Controls.Add(invoicesListControl);
            Controls.Add(buttonEditClient);
            Controls.Add(buttonRemoveClient);
            Controls.Add(buttonAddClient);
            Controls.Add(clientsListControl);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private ClientsListControl clientsListControl;
        private Button buttonAddClient;
        private Button buttonRemoveClient;
        private Button buttonEditClient;
        private InvoicesListControl invoicesListControl;
        private Button buttonRemoveInvoice;
        private Button buttonEditInvoice;
        private Button addInvoiceButton;
        private Button buttonExportClients;
        private Button buttonExportInvoices;
        private Button buttonReports;
    }
}
