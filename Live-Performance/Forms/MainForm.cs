using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Performance.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
