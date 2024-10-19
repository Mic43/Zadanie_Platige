namespace Platigue.Gui
{
    partial class ClientDetailsControl
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
            lblName = new Label();
            txtName = new TextBox();
            lblShortcut = new Label();
            txtShortcut = new TextBox();
            lblCountry = new Label();
            txtCountry = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblNIP = new Label();
            txtNIP = new TextBox();
            chkIsActive = new CheckBox();
            bindingSourceMain = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSourceMain).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // lblShortcut
            // 
            lblShortcut.AutoSize = true;
            lblShortcut.Location = new Point(12, 45);
            lblShortcut.Name = "lblShortcut";
            lblShortcut.Size = new Size(55, 15);
            lblShortcut.TabIndex = 2;
            lblShortcut.Text = "Shortcut:";
            // 
            // txtShortcut
            // 
            txtShortcut.Location = new Point(120, 42);
            txtShortcut.Name = "txtShortcut";
            txtShortcut.Size = new Size(200, 23);
            txtShortcut.TabIndex = 3;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(12, 75);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(53, 15);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(120, 72);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(200, 23);
            txtCountry.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 105);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 102);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblNIP
            // 
            lblNIP.AutoSize = true;
            lblNIP.Location = new Point(12, 135);
            lblNIP.Name = "lblNIP";
            lblNIP.Size = new Size(29, 15);
            lblNIP.TabIndex = 8;
            lblNIP.Text = "NIP:";
            // 
            // txtNIP
            // 
            txtNIP.Location = new Point(120, 132);
            txtNIP.Name = "txtNIP";
            txtNIP.Size = new Size(200, 23);
            txtNIP.TabIndex = 9;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(120, 162);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(70, 19);
            chkIsActive.TabIndex = 10;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // ClientDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkIsActive);
            Controls.Add(txtNIP);
            Controls.Add(lblNIP);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtCountry);
            Controls.Add(lblCountry);
            Controls.Add(txtShortcut);
            Controls.Add(lblShortcut);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "ClientDetailsControl";
            Size = new Size(351, 190);
            ((System.ComponentModel.ISupportInitialize)bindingSourceMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblShortcut;
        private System.Windows.Forms.TextBox txtShortcut;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblNIP;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;


        private BindingSource bindingSourceMain;
    }
}
