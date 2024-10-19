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
                if (_dbContext != null) 
                    _dbContext.Dispose();
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
            _clientsListControl = new ClientsListControl();
            buttonAddClient = new Button();
            buttonRemoveClient = new Button();
            buttonEditClient = new Button();
            invoicesListControl = new InvoicesListControl();
            buttonRemoveInvoice = new Button();
            buttonEditInvoice = new Button();
            addInvoiceButton = new Button();
            SuspendLayout();
            // 
            // _clientsListControl
            // 
            _clientsListControl.Location = new Point(12, 12);
            _clientsListControl.Name = "_clientsListControl";
            _clientsListControl.Size = new Size(420, 254);
            _clientsListControl.TabIndex = 1;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Location = new Point(51, 284);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(75, 23);
            buttonAddClient.TabIndex = 2;
            buttonAddClient.Text = "button1";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonRemoveClient
            // 
            buttonRemoveClient.Location = new Point(132, 284);
            buttonRemoveClient.Name = "buttonRemoveClient";
            buttonRemoveClient.Size = new Size(75, 23);
            buttonRemoveClient.TabIndex = 3;
            buttonRemoveClient.Text = "button1";
            buttonRemoveClient.UseVisualStyleBackColor = true;
            buttonRemoveClient.Click += buttonRemoveClient_Click;
            // 
            // buttonEditClient
            // 
            buttonEditClient.Location = new Point(213, 284);
            buttonEditClient.Name = "buttonEditClient";
            buttonEditClient.Size = new Size(75, 23);
            buttonEditClient.TabIndex = 4;
            buttonEditClient.Text = "button1";
            buttonEditClient.UseVisualStyleBackColor = true;
            buttonEditClient.Click += buttonEditClient_Click;
            // 
            // invoicesListControl
            // 
            invoicesListControl.Location = new Point(450, 12);
            invoicesListControl.Name = "invoicesListControl";
            invoicesListControl.Size = new Size(724, 254);
            invoicesListControl.TabIndex = 5;
            // 
            // buttonRemoveInvoice
            // 
            buttonRemoveInvoice.Location = new Point(662, 284);
            buttonRemoveInvoice.Name = "buttonRemoveInvoice";
            buttonRemoveInvoice.Size = new Size(75, 23);
            buttonRemoveInvoice.TabIndex = 8;
            buttonRemoveInvoice.Text = "button1";
            buttonRemoveInvoice.UseVisualStyleBackColor = true;
            // 
            // buttonEditInvoice
            // 
            buttonEditInvoice.Location = new Point(581, 284);
            buttonEditInvoice.Name = "buttonEditInvoice";
            buttonEditInvoice.Size = new Size(75, 23);
            buttonEditInvoice.TabIndex = 7;
            buttonEditInvoice.Text = "button1";
            buttonEditInvoice.UseVisualStyleBackColor = true;
            buttonEditInvoice.Click += buttonEditInvoice_Click;
            // 
            // addInvoiceButton
            // 
            addInvoiceButton.Location = new Point(500, 284);
            addInvoiceButton.Name = "addInvoiceButton";
            addInvoiceButton.Size = new Size(75, 23);
            addInvoiceButton.TabIndex = 6;
            addInvoiceButton.Text = "button1";
            addInvoiceButton.UseVisualStyleBackColor = true;
            addInvoiceButton.Click += addInvoiceButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 504);
            Controls.Add(buttonRemoveInvoice);
            Controls.Add(buttonEditInvoice);
            Controls.Add(addInvoiceButton);
            Controls.Add(invoicesListControl);
            Controls.Add(buttonEditClient);
            Controls.Add(buttonRemoveClient);
            Controls.Add(buttonAddClient);
            Controls.Add(_clientsListControl);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private ClientsListControl _clientsListControl;
        private Button buttonAddClient;
        private Button buttonRemoveClient;
        private Button buttonEditClient;
        private InvoicesListControl invoicesListControl;
        private Button buttonRemoveInvoice;
        private Button buttonEditInvoice;
        private Button addInvoiceButton;
    }
}
