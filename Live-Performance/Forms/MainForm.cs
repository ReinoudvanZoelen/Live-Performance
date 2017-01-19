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
        private List<Product> Bestelling = new List<Product>();

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

            foreach (Product product in Bestelling)
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
    }
}
