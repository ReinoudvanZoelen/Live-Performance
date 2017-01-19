using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Classes;
using Live_Performance.Logic;

namespace Live_Performance.Forms
{
    public partial class Create : Form
    {
        public CreateLogic logic = new CreateLogic();
        private List<Ingredient> ingredienten = new List<Ingredient>();

        public Create()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            listbox_Ingredienten.Items.Clear();
            listbox_PizzaIingredienten.Items.Clear();

            foreach (Ingredient ingredient in logic.GetIngredients())
            {
                listbox_Ingredienten.Items.Add(ingredient);
            }
            foreach (Ingredient ingredient in ingredienten)
            {
                listbox_PizzaIingredienten.Items.Add(ingredient);
            }
        }

        private void button_PizzaOpslaan_Click(object sender, EventArgs e)
        {
            if (numeric_AfmetingA.Value != 0
                && textbox_Pizzanaam.Text != ""
                && listbox_PizzaIingredienten.Items.Count != 0)
            {
                string naam = textbox_Pizzanaam.Text;
                bool custom = checkbox_Custom.Checked;
                bool glutenvrij = checkbox_Glutenvrij.Checked;
                int[] afmetingen = new int[3];
                afmetingen[0] = Convert.ToInt32(numeric_AfmetingA.Value);
                afmetingen[1] = Convert.ToInt32(numeric_AfmetingB.Value);
                afmetingen[2] = Convert.ToInt32(numeric_AfmetingC.Value);

                List<Ingredient> ingredienten = new List<Ingredient>();
                foreach (Ingredient ingredient in listbox_PizzaIingredienten.Items)
                {
                    ingredienten.Add(ingredient);
                }

                Pizza pizza = new Pizza(naam, custom, glutenvrij, afmetingen, ingredienten);

                logic.InsertPizza(pizza);

                MessageBox.Show($"De {naam} is succesvol aangemaakt");

                this.Close();
            }
            else
            {
                MessageBox.Show("Er is iets niet goed ingevuld");
            }
        }
        
        private void listbox_Ingredienten_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = ((ListBox)sender).IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Ingredient ingredient = (Ingredient)((ListBox)sender).SelectedItem;

                ingredienten.Add(ingredient);

                Fill();
            }
        }
    }
}
