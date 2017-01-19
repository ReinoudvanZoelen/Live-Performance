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
    public partial class Receipt : Form
    {
        private ReceiptLogic logic = new ReceiptLogic();

        public Receipt()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            listbox_Receipt.Items.Clear();

            foreach (Bestelling bestelling in logic.GetAll())
            {
                listbox_Receipt.Items.Add(bestelling);
            }
        }

        private void listbox_Receipt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = ((ListBox)sender).IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                logic.ExportReceipt((Bestelling)listbox_Receipt.SelectedItem);
            }
        }
    }
}
