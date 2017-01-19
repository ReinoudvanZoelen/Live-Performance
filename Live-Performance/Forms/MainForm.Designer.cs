namespace Live_Performance.Forms
{
    partial class MainForm
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
            this.groupbox_Oven = new System.Windows.Forms.GroupBox();
            this.listbox_Oven = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listbox_Bestelling = new System.Windows.Forms.ListBox();
            this.combobox_Klanten = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listbox_Salades = new System.Windows.Forms.ListBox();
            this.listbox_Dranken = new System.Windows.Forms.ListBox();
            this.listbox_Pizzas = new System.Windows.Forms.ListBox();
            this.button_NewItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Receipt = new System.Windows.Forms.Button();
            this.button_SaveBestelling = new System.Windows.Forms.Button();
            this.button_RefreshOven = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.groupbox_Oven.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_Oven
            // 
            this.groupbox_Oven.Controls.Add(this.listbox_Oven);
            this.groupbox_Oven.Location = new System.Drawing.Point(729, 68);
            this.groupbox_Oven.Name = "groupbox_Oven";
            this.groupbox_Oven.Size = new System.Drawing.Size(304, 283);
            this.groupbox_Oven.TabIndex = 0;
            this.groupbox_Oven.TabStop = false;
            this.groupbox_Oven.Text = "Oven";
            // 
            // listbox_Oven
            // 
            this.listbox_Oven.FormattingEnabled = true;
            this.listbox_Oven.ItemHeight = 16;
            this.listbox_Oven.Location = new System.Drawing.Point(7, 22);
            this.listbox_Oven.Name = "listbox_Oven";
            this.listbox_Oven.Size = new System.Drawing.Size(291, 244);
            this.listbox_Oven.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listbox_Bestelling);
            this.groupBox1.Controls.Add(this.combobox_Klanten);
            this.groupBox1.Location = new System.Drawing.Point(395, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bestelling";
            // 
            // listbox_Bestelling
            // 
            this.listbox_Bestelling.FormattingEnabled = true;
            this.listbox_Bestelling.ItemHeight = 16;
            this.listbox_Bestelling.Location = new System.Drawing.Point(6, 52);
            this.listbox_Bestelling.Name = "listbox_Bestelling";
            this.listbox_Bestelling.Size = new System.Drawing.Size(316, 276);
            this.listbox_Bestelling.TabIndex = 1;
            // 
            // combobox_Klanten
            // 
            this.combobox_Klanten.FormattingEnabled = true;
            this.combobox_Klanten.Location = new System.Drawing.Point(6, 22);
            this.combobox_Klanten.Name = "combobox_Klanten";
            this.combobox_Klanten.Size = new System.Drawing.Size(316, 24);
            this.combobox_Klanten.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listbox_Salades);
            this.groupBox2.Controls.Add(this.listbox_Dranken);
            this.groupBox2.Controls.Add(this.listbox_Pizzas);
            this.groupBox2.Location = new System.Drawing.Point(6, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 342);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invetaris";
            // 
            // listbox_Salades
            // 
            this.listbox_Salades.FormattingEnabled = true;
            this.listbox_Salades.ItemHeight = 16;
            this.listbox_Salades.Location = new System.Drawing.Point(6, 234);
            this.listbox_Salades.Name = "listbox_Salades";
            this.listbox_Salades.Size = new System.Drawing.Size(371, 100);
            this.listbox_Salades.TabIndex = 2;
            this.listbox_Salades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Salades_MouseDoubleClick);
            // 
            // listbox_Dranken
            // 
            this.listbox_Dranken.FormattingEnabled = true;
            this.listbox_Dranken.ItemHeight = 16;
            this.listbox_Dranken.Location = new System.Drawing.Point(6, 128);
            this.listbox_Dranken.Name = "listbox_Dranken";
            this.listbox_Dranken.Size = new System.Drawing.Size(371, 100);
            this.listbox_Dranken.TabIndex = 1;
            this.listbox_Dranken.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Dranken_MouseDoubleClick);
            // 
            // listbox_Pizzas
            // 
            this.listbox_Pizzas.FormattingEnabled = true;
            this.listbox_Pizzas.ItemHeight = 16;
            this.listbox_Pizzas.Location = new System.Drawing.Point(6, 22);
            this.listbox_Pizzas.Name = "listbox_Pizzas";
            this.listbox_Pizzas.Size = new System.Drawing.Size(371, 100);
            this.listbox_Pizzas.TabIndex = 0;
            this.listbox_Pizzas.SelectedIndexChanged += new System.EventHandler(this.listbox_Pizzas_SelectedIndexChanged);
            this.listbox_Pizzas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Pizzas_MouseDoubleClick);
            // 
            // button_NewItem
            // 
            this.button_NewItem.Location = new System.Drawing.Point(12, 12);
            this.button_NewItem.Name = "button_NewItem";
            this.button_NewItem.Size = new System.Drawing.Size(188, 50);
            this.button_NewItem.TabIndex = 3;
            this.button_NewItem.Text = "Toevoegen";
            this.button_NewItem.UseVisualStyleBackColor = true;
            this.button_NewItem.Click += new System.EventHandler(this.button_NewItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aanpassen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Receipt
            // 
            this.button_Receipt.Location = new System.Drawing.Point(425, 12);
            this.button_Receipt.Name = "button_Receipt";
            this.button_Receipt.Size = new System.Drawing.Size(187, 50);
            this.button_Receipt.TabIndex = 5;
            this.button_Receipt.Text = "Bonnetje";
            this.button_Receipt.UseVisualStyleBackColor = true;
            this.button_Receipt.Click += new System.EventHandler(this.button_Receipt_Click);
            // 
            // button_SaveBestelling
            // 
            this.button_SaveBestelling.Location = new System.Drawing.Point(618, 13);
            this.button_SaveBestelling.Name = "button_SaveBestelling";
            this.button_SaveBestelling.Size = new System.Drawing.Size(165, 49);
            this.button_SaveBestelling.TabIndex = 2;
            this.button_SaveBestelling.Text = "Bestelling opslaan";
            this.button_SaveBestelling.UseVisualStyleBackColor = true;
            this.button_SaveBestelling.Click += new System.EventHandler(this.button_SaveBestelling_Click);
            // 
            // button_RefreshOven
            // 
            this.button_RefreshOven.Location = new System.Drawing.Point(789, 12);
            this.button_RefreshOven.Name = "button_RefreshOven";
            this.button_RefreshOven.Size = new System.Drawing.Size(244, 49);
            this.button_RefreshOven.TabIndex = 3;
            this.button_RefreshOven.Text = "Ververs oven";
            this.button_RefreshOven.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(730, 358);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(300, 48);
            this.button_Refresh.TabIndex = 6;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 418);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_RefreshOven);
            this.Controls.Add(this.button_SaveBestelling);
            this.Controls.Add(this.button_Receipt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_NewItem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupbox_Oven);
            this.Name = "MainForm";
            this.Text = "La Crosta Insapore";
            this.groupbox_Oven.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_Oven;
        private System.Windows.Forms.ListBox listbox_Oven;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listbox_Bestelling;
        private System.Windows.Forms.ComboBox combobox_Klanten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listbox_Salades;
        private System.Windows.Forms.ListBox listbox_Dranken;
        private System.Windows.Forms.ListBox listbox_Pizzas;
        private System.Windows.Forms.Button button_NewItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Receipt;
        private System.Windows.Forms.Button button_SaveBestelling;
        private System.Windows.Forms.Button button_RefreshOven;
        private System.Windows.Forms.Button button_Refresh;
    }
}