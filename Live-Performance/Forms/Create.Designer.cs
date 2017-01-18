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
            this.Drank = new System.Windows.Forms.TabPage();
            this.Salade = new System.Windows.Forms.TabPage();
            this.Ingredient = new System.Windows.Forms.TabPage();
            this.Klant = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.Pizza.Location = new System.Drawing.Point(4, 25);
            this.Pizza.Name = "Pizza";
            this.Pizza.Padding = new System.Windows.Forms.Padding(3);
            this.Pizza.Size = new System.Drawing.Size(592, 410);
            this.Pizza.TabIndex = 0;
            this.Pizza.Text = "Pizza";
            this.Pizza.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pizza;
        private System.Windows.Forms.TabPage Drank;
        private System.Windows.Forms.TabPage Salade;
        private System.Windows.Forms.TabPage Ingredient;
        private System.Windows.Forms.TabPage Klant;
    }
}