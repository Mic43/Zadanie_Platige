﻿namespace Platigue.Gui
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
            label1 = new Label();
            textBoxNumber = new TextBox();
            bindingSourceMain = new BindingSource(components);
            comboBoxClients = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMain).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(67, 8);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(100, 23);
            textBoxNumber.TabIndex = 1;
            // 
            // comboBoxClients
            // 
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(66, 38);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(121, 23);
            comboBoxClients.TabIndex = 2;
            // 
            // InvoiceDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxClients);
            Controls.Add(textBoxNumber);
            Controls.Add(label1);
            Name = "InvoiceDetailsControl";
            Size = new Size(488, 269);
            ((System.ComponentModel.ISupportInitialize)bindingSourceMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumber;
        private BindingSource bindingSourceMain;
        private ComboBox comboBoxClients;
    }
}
