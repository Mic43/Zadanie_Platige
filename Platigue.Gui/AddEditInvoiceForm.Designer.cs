namespace Platigue.Gui
{
    partial class AddEditInvoiceForm
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
            button1 = new Button();
            button2 = new Button();
            invoiceDetailsControl = new InvoiceDetailsControl();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(93, 258);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(172, 258);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // invoiceDetailsControl
            // 
            invoiceDetailsControl.Location = new Point(12, 12);
            invoiceDetailsControl.Name = "invoiceDetailsControl";
            invoiceDetailsControl.Size = new Size(327, 228);
            invoiceDetailsControl.TabIndex = 3;
            // 
            // AddEditInvoiceForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(351, 302);
            Controls.Add(invoiceDetailsControl);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddEditInvoiceForm";
            Text = "Invoice";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        public InvoiceDetailsControl invoiceDetailsControl;
        private InvoiceDetailsControl invoiceDetailsControl1;
    }
}