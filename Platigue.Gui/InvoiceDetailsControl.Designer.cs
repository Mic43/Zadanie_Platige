namespace Platigue.Gui
{
    partial class InvoiceDetailsControl
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
            lblNumber = new Label();
            txtNumber = new TextBox();
            lblValue = new Label();
            txtValue = new TextBox();
            lblCurrency = new Label();
            txtCurrency = new TextBox();
            lblVAT = new Label();
            txtVAT = new TextBox();
            lblIssueDate = new Label();
            dtpIssueDate = new DateTimePicker();
            lblDescription = new Label();
            txtDescription = new TextBox();
            bindingSourceMain = new BindingSource(components);
            comboBoxClients = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMain).BeginInit();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(12, 15);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(54, 15);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Number:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(120, 12);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(200, 23);
            txtNumber.TabIndex = 1;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(12, 45);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(38, 15);
            lblValue.TabIndex = 2;
            lblValue.Text = "Value:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(120, 42);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(200, 23);
            txtValue.TabIndex = 3;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(12, 75);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(58, 15);
            lblCurrency.TabIndex = 4;
            lblCurrency.Text = "Currency:";
            // 
            // txtCurrency
            // 
            txtCurrency.Location = new Point(120, 72);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(200, 23);
            txtCurrency.TabIndex = 5;
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Location = new Point(12, 105);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(29, 15);
            lblVAT.TabIndex = 6;
            lblVAT.Text = "VAT:";
            // 
            // txtVAT
            // 
            txtVAT.Location = new Point(120, 102);
            txtVAT.Name = "txtVAT";
            txtVAT.Size = new Size(200, 23);
            txtVAT.TabIndex = 7;
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(12, 135);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(63, 15);
            lblIssueDate.TabIndex = 8;
            lblIssueDate.Text = "Issue Date:";
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Location = new Point(120, 132);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(200, 23);
            dtpIssueDate.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 165);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 162);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 23);
            txtDescription.TabIndex = 11;
            // 
            // comboBoxClients
            // 
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(120, 191);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(200, 23);
            comboBoxClients.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 194);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 12;
            label1.Text = "Client:";
            // 
            // InvoiceDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(dtpIssueDate);
            Controls.Add(lblIssueDate);
            Controls.Add(txtVAT);
            Controls.Add(lblVAT);
            Controls.Add(txtCurrency);
            Controls.Add(lblCurrency);
            Controls.Add(txtValue);
            Controls.Add(lblValue);
            Controls.Add(txtNumber);
            Controls.Add(lblNumber);
            Controls.Add(comboBoxClients);
            Name = "InvoiceDetailsControl";
            Size = new Size(343, 237);
            ((System.ComponentModel.ISupportInitialize)bindingSourceMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;


        private BindingSource bindingSourceMain;
        private ComboBox comboBoxClients;
        private Label label1;
    }
}
