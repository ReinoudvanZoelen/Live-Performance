namespace Live_Performance.Forms
{
    partial class Receipt
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
            this.listbox_Receipt = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbox_Receipt
            // 
            this.listbox_Receipt.FormattingEnabled = true;
            this.listbox_Receipt.ItemHeight = 16;
            this.listbox_Receipt.Location = new System.Drawing.Point(12, 44);
            this.listbox_Receipt.Name = "listbox_Receipt";
            this.listbox_Receipt.Size = new System.Drawing.Size(258, 196);
            this.listbox_Receipt.TabIndex = 0;
            this.listbox_Receipt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Receipt_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecteer een bon om uit te printen";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_Receipt);
            this.Name = "Receipt";
            this.Text = "Bonnetje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_Receipt;
        private System.Windows.Forms.Label label1;
    }
}