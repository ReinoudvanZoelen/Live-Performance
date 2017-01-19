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
    public partial class MainForm : Form
    {
        private MainFormLogic logic = new MainFormLogic();
        private List<Pizza> Pizzas = new List<Pizza>();
        private List<Drank> Dranken = new List<Drank>();
        private List<Salade> Salades = new List<Salade>();

        public MainForm()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            listbox_Oven.Items.Clear();
            listbox_Dranken.Items.Clear();
            listbox_Pizzas.Items.Clear();
            listbox_Salades.Items.Clear();
            listbox_Bestelling.Items.Clear();
            combobox_Klanten.Items.Clear();

            foreach (Bestelling bestelling in logic.GetOvenList())
            {
                listbox_Oven.Items.Add(bestelling);
            }
            foreach (Pizza pizza in logic.PizzaContext.GetAll())
            {
                listbox_Pizzas.Items.Add(pizza);
            }

            foreach (Drank drank in logic.DrankContext.GetAll())
            {
                listbox_Dranken.Items.Add(drank);
            }

            foreach (Salade salade in logic.SaladeContext.GetAll())
            {
                listbox_Salades.Items.Add(salade);
            }
            
            foreach (Klant klant in logic.KlantContext.GetAll())
            {
                combobox_Klanten.Items.Add(klant);
            }

            foreach (Pizza product in Pizzas)
            {
                listbox_Bestelling.Items.Add(product);
            }
            foreach (Drank product in Dranken)
            {
                listbox_Bestelling.Items.Add(product);
            }
            foreach (Salade product in Salades)
            {
                listbox_Bestelling.Items.Add(product);
            }
        }

        private void button_Receipt_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.Show();
        }

        private void button_NewItem_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
        }



        private void button_SaveBestelling_Click(object sender, EventArgs e)
        {
            if (Pizzas.Count != 0 || Dranken.Count != 0 || Salades.Count != 0)
            {
                Klant klant = combobox_Klanten.SelectedItem as Klant;

                logic.NewBestelling(klant, Pizzas, Dranken, Salades);

                Pizzas.Clear();
                Dranken.Clear();
                Salades.Clear();

                Fill();
            }
        }

        private void listbox_Pizzas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = ((ListBox)sender).IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Pizza product = (Pizza)((ListBox)sender).SelectedItem;

                Pizzas.Add(product);

                Fill();
            }
        }

        private void listbox_Dranken_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = ((ListBox)sender).IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Drank product = (Drank)((ListBox)sender).SelectedItem;

                Dranken.Add(product);

                Fill();
            }
        }

        private void listbox_Salades_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = ((ListBox)sender).IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Salade product = (Salade)((ListBox)sender).SelectedItem;

                Salades.Add(product);

                Fill();
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void listbox_Pizzas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
