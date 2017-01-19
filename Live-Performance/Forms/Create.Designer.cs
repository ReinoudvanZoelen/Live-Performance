namespace Live_Performance.Forms
{
    partial class Create
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pizza = new System.Windows.Forms.TabPage();
            this.button_PizzaOpslaan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_Glutenvrij = new System.Windows.Forms.CheckBox();
            this.numeric_AfmetingC = new System.Windows.Forms.NumericUpDown();
            this.numeric_AfmetingB = new System.Windows.Forms.NumericUpDown();
            this.numeric_AfmetingA = new System.Windows.Forms.NumericUpDown();
            this.checkbox_Custom = new System.Windows.Forms.CheckBox();
            this.textbox_Pizzanaam = new System.Windows.Forms.TextBox();
            this.listbox_PizzaIingredienten = new System.Windows.Forms.ListBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.listbox_Ingredienten = new System.Windows.Forms.ListBox();
            this.Drank = new System.Windows.Forms.TabPage();
            this.Salade = new System.Windows.Forms.TabPage();
            this.Ingredient = new System.Windows.Forms.TabPage();
            this.Klant = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Pizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AfmetingC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AfmetingB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AfmetingA)).BeginInit();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pizza);
            this.tabControl1.Controls.Add(this.Drank);
            this.tabControl1.Controls.Add(this.Salade);
            this.tabControl1.Controls.Add(this.Ingredient);
            this.tabControl1.Controls.Add(this.Klant);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // Pizza
            // 
            this.Pizza.Controls.Add(this.button_PizzaOpslaan);
            this.Pizza.Controls.Add(this.label1);
            this.Pizza.Controls.Add(this.checkbox_Glutenvrij);
            this.Pizza.Controls.Add(this.numeric_AfmetingC);
            this.Pizza.Controls.Add(this.numeric_AfmetingB);
            this.Pizza.Controls.Add(this.numeric_AfmetingA);
            this.Pizza.Controls.Add(this.checkbox_Custom);
            this.Pizza.Controls.Add(this.textbox_Pizzanaam);
            this.Pizza.Controls.Add(this.listbox_PizzaIingredienten);
            this.Pizza.Controls.Add(this.group);
            this.Pizza.Location = new System.Drawing.Point(4, 25);
            this.Pizza.Name = "Pizza";
            this.Pizza.Padding = new System.Windows.Forms.Padding(3);
            this.Pizza.Size = new System.Drawing.Size(592, 410);
            this.Pizza.TabIndex = 0;
            this.Pizza.Text = "Pizza";
            this.Pizza.UseVisualStyleBackColor = true;
            // 
            // button_PizzaOpslaan
            // 
            this.button_PizzaOpslaan.Location = new System.Drawing.Point(390, 103);
            this.button_PizzaOpslaan.Name = "button_PizzaOpslaan";
            this.button_PizzaOpslaan.Size = new System.Drawing.Size(196, 69);
            this.button_PizzaOpslaan.TabIndex = 10;
            this.button_PizzaOpslaan.Text = "Opslaan";
            this.button_PizzaOpslaan.UseVisualStyleBackColor = true;
            this.button_PizzaOpslaan.Click += new System.EventHandler(this.button_PizzaOpslaan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pizzanaam";
            // 
            // checkbox_Glutenvrij
            // 
            this.checkbox_Glutenvrij.AutoSize = true;
            this.checkbox_Glutenvrij.Location = new System.Drawing.Point(294, 151);
            this.checkbox_Glutenvrij.Name = "checkbox_Glutenvrij";
            this.checkbox_Glutenvrij.Size = new System.Drawing.Size(90, 21);
            this.checkbox_Glutenvrij.TabIndex = 8;
            this.checkbox_Glutenvrij.Text = "Glutenvrij";
            this.checkbox_Glutenvrij.UseVisualStyleBackColor = true;
            // 
            // numeric_AfmetingC
            // 
            this.numeric_AfmetingC.Location = new System.Drawing.Point(211, 234);
            this.numeric_AfmetingC.Name = "numeric_AfmetingC";
            this.numeric_AfmetingC.Size = new System.Drawing.Size(375, 22);
            this.numeric_AfmetingC.TabIndex = 7;
            // 
            // numeric_AfmetingB
            // 
            this.numeric_AfmetingB.Location = new System.Drawing.Point(211, 206);
            this.numeric_AfmetingB.Name = "numeric_AfmetingB";
            this.numeric_AfmetingB.Size = new System.Drawing.Size(375, 22);
            this.numeric_AfmetingB.TabIndex = 6;
            // 
            // numeric_AfmetingA
            // 
            this.numeric_AfmetingA.Location = new System.Drawing.Point(211, 178);
            this.numeric_AfmetingA.Name = "numeric_AfmetingA";
            this.numeric_AfmetingA.Size = new System.Drawing.Size(375, 22);
            this.numeric_AfmetingA.TabIndex = 5;
            // 
            // checkbox_Custom
            // 
            this.checkbox_Custom.AutoSize = true;
            this.checkbox_Custom.Location = new System.Drawing.Point(211, 151);
            this.checkbox_Custom.Name = "checkbox_Custom";
            this.checkbox_Custom.Size = new System.Drawing.Size(77, 21);
            this.checkbox_Custom.TabIndex = 4;
            this.checkbox_Custom.Text = "Custom";
            this.checkbox_Custom.UseVisualStyleBackColor = true;
            // 
            // textbox_Pizzanaam
            // 
            this.textbox_Pizzanaam.Location = new System.Drawing.Point(211, 123);
            this.textbox_Pizzanaam.Name = "textbox_Pizzanaam";
            this.textbox_Pizzanaam.Size = new System.Drawing.Size(173, 22);
            this.textbox_Pizzanaam.TabIndex = 3;
            // 
            // listbox_PizzaIingredienten
            // 
            this.listbox_PizzaIingredienten.FormattingEnabled = true;
            this.listbox_PizzaIingredienten.ItemHeight = 16;
            this.listbox_PizzaIingredienten.Location = new System.Drawing.Point(211, 262);
            this.listbox_PizzaIingredienten.Name = "listbox_PizzaIingredienten";
            this.listbox_PizzaIingredienten.Size = new System.Drawing.Size(375, 132);
            this.listbox_PizzaIingredienten.TabIndex = 2;
            // 
            // group
            // 
            this.group.Controls.Add(this.listbox_Ingredienten);
            this.group.Location = new System.Drawing.Point(6, 6);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(199, 398);
            this.group.TabIndex = 1;
            this.group.TabStop = false;
            this.group.Text = "Ingredienten";
            // 
            // listbox_Ingredienten
            // 
            this.listbox_Ingredienten.FormattingEnabled = true;
            this.listbox_Ingredienten.ItemHeight = 16;
            this.listbox_Ingredienten.Location = new System.Drawing.Point(6, 20);
            this.listbox_Ingredienten.Name = "listbox_Ingredienten";
            this.listbox_Ingredienten.Size = new System.Drawing.Size(187, 372);
            this.listbox_Ingredienten.TabIndex = 0;
            this.listbox_Ingredienten.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Ingredienten_MouseDoubleClick);
            // 
            // Drank
            // 
            this.Drank.Location = new System.Drawing.Point(4, 25);
            this.Drank.Name = "Drank";
            this.Drank.Padding = new System.Windows.Forms.Padding(3);
            this.Drank.Size = new System.Drawing.Size(592, 410);
            this.Drank.TabIndex = 1;
            this.Drank.Text = "Drank";
            this.Drank.UseVisualStyleBackColor = true;
            // 
            // Salade
            // 
            this.Salade.Location = new System.Drawing.Point(4, 25);
            this.Salade.Name = "Salade";
            this.Salade.Size = new System.Drawing.Size(592, 410);
            this.Salade.TabIndex = 2;
            this.Salade.Text = "Salade";
            this.Salade.UseVisualStyleBackColor = true;
            // 
            // Ingredient
            // 
            this.Ingredient.Location = new System.Drawing.Point(4, 25);
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.Size = new System.Drawing.Size(592, 410);
            this.Ingredient.TabIndex = 3;
            this.Ingredient.Text = "Ingredient";
            this.Ingredient.UseVisualStyleBackColor = true;
            // 
            // Klant
            // 
            this.Klant.Location = new System.Drawing.Point(4, 25);
            this.Klant.Name = "Klant";
            this.Klant.Size = new System.Drawing.Size(592, 410);
            this.Klant.TabIndex = 4;
            this.Klant.Text = "Klant";
            this.Klant.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "Create";
            this.Text = "Create";
            this.tabControl1.ResumeLayout(false);
            this.Pizza.ResumeLayout(false);
            this.Pizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AfmetingC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AfmetingB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AfmetingA)).EndInit();
            this.group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pizza;
        private System.Windows.Forms.TabPage Drank;
        private System.Windows.Forms.TabPage Salade;
        private System.Windows.Forms.TabPage Ingredient;
        private System.Windows.Forms.TabPage Klant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_Glutenvrij;
        private System.Windows.Forms.NumericUpDown numeric_AfmetingC;
        private System.Windows.Forms.NumericUpDown numeric_AfmetingB;
        private System.Windows.Forms.NumericUpDown numeric_AfmetingA;
        private System.Windows.Forms.CheckBox checkbox_Custom;
        private System.Windows.Forms.TextBox textbox_Pizzanaam;
        private System.Windows.Forms.ListBox listbox_PizzaIingredienten;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.ListBox listbox_Ingredienten;
        private System.Windows.Forms.Button button_PizzaOpslaan;
    }
}