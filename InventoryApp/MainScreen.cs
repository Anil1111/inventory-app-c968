using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {
            // PrePopulate some dummy data for testing
            string[] partRow0 = { "1", "Part 1", "16", "$12.00" };
            string[] partRow1 = { "2", "Part 2", "2", "$120.00" };
            string[] partRow2 = { "3", "Part 3", "1", "$1121542.00" };
            mainParts.Rows.Add(partRow0);
            mainParts.Rows.Add(partRow1);
            mainParts.Rows.Add(partRow2);

            string[] productRow0 = { "1", "Product 1", "16", "$12.00" };
            string[] productRow1 = { "2", "Product 2", "2", "$120.00" };
            string[] productRow2 = { "3", "Product 3", "1", "$1121542.00" };
            mainProducts.Rows.Add(productRow0);
            mainProducts.Rows.Add(productRow1);
            mainProducts.Rows.Add(productRow2);
        }
    }
}
