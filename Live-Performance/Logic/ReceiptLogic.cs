using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Classes;
using Live_Performance.Repositories.Context;
using Live_Performance.Repositories.MSSQLRepository;

namespace Live_Performance.Logic
{
    public class ReceiptLogic
    {
        private BestellingContext BestellingContext = new BestellingContext(new MSSQLBestellingRepository());

        private string GetTarget()
        {
            string path = "";

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    path = folderBrowser.SelectedPath;
                }
            }

            return path;
        }

        public List<Bestelling> GetAll()
        {
            return BestellingContext.GetAll();
        }

        public void ExportReceipt(Bestelling bestelling)
        {
            // Get the target
            string target = GetTarget();

            // Set up the money
            decimal brutoprijs = 0;
            decimal btw = 0;
            decimal nettoprijs = 0;

            // Set up the strings
            List<String> receipt = new List<string>();

            receipt.Add("Pizzeria La Crosta Insapore");
            if (bestelling.Klant == null)
            {
                receipt.Add("Klantbon voor anonieme klant");
            }
            else
            {
                receipt.Add($"Klantbon voor {bestelling.Klant.Naam}");
            }
            receipt.Add("");

            foreach (Product product in bestelling.Producten)
            {
                receipt.Add($"{product.Naam} {product.Verkoopprijs}");
                brutoprijs = brutoprijs + (product.Verkoopprijs / 100 * 79);
            }

            receipt.Add("");

            nettoprijs = brutoprijs / 79 * 100;
            btw = nettoprijs - brutoprijs;

            receipt.Add($"Prijs exclusief btw: {brutoprijs}");
            receipt.Add($"BTW bedrag: {btw}");
            receipt.Add($"Te betalen bedrag: {nettoprijs}");

            // write file
            File.WriteAllLines($"{bestelling.ID}.txt", receipt);
        }
    }
}
