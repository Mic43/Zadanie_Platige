namespace Platigue.Gui
{
    partial class AddEditClientForm
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
            clientDetailsControl = new ClientDetailsControl();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // clientDetailsControl
            // 
            clientDetailsControl.AutoSize = true;
            clientDetailsControl.Location = new Point(12, 12);
            clientDetailsControl.Name = "clientDetailsControl";
            clientDetailsControl.Size = new Size(330, 197);
            clientDetailsControl.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(89, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(170, 215);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddEditClientForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(344, 248);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(clientDetailsControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddEditClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        public ClientDetailsControl clientDetailsControl;
    }
}